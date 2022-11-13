class CRUDlivros
{
    //propriedade
    List<Livros> BaseDadosLivros = new List<Livros>();
    Tela tela;
    string titulo, editora, autor, genero;
    int serie;

    //construtor
    public CRUDlivros(Tela t)
    {
        this.tela = t;

        this.BaseDadosLivros.Add( new Livros("O Senhor dos Anéis: A Sociedade do Anel", "HarperCollins", "J.R.R TOLKIEN", "Fantasia Épica", 0010) );
        this.BaseDadosLivros.Add( new Livros("O Senhor dos Anéis: As Duas Torres", "HarperCollins", "J.R.R TOLKIEN", "Fantasia Épica", 0011));
    }


    public void controller()
    {
        while(true)
        {   

            this.montarTela(10,5,70,15);

            // solicita entrada do numero da conta
            Console.SetCursorPosition(22,8);
            this.titulo = Console.ReadLine();
            if(this.titulo == "") break;

            //procura a conta informada no banco de dados
            bool achou = false;
            int x;
            for(x=0; x<this.BaseDadosLivros.Count; x++){
                if (this.BaseDadosLivros[x].titulo == this.titulo)
                {
                    achou = true;
                    this.serie = x;
                    break;
                }
            }

            //se achou a conta, mostra os dados
            //caso contrário mostra a mensagem de não encontrado
            if(achou)
            {
                    //mostrar os dados conta encontradda
                    Console.SetCursorPosition(22,9);
                    Console.Write(this.BaseDadosLivros[this.serie].titulo);
                    Console.SetCursorPosition(22,10);
                    Console.Write(this.BaseDadosLivros[this.serie].quantidadeRestante);
                    Console.ReadKey();
            }else{
                //mostra a mensagem de conta não encontrada
                Console.SetCursorPosition(22,9);
                Console.Write("Livro não encontrado");

                //pergunta se o usuario deseja cadastrar nova conta
                Console.SetCursorPosition(22,12);
                Console.Write("Queres Adicionar (S/N)  :  ");
                
                string answer;
                answer = Console.ReadLine();

                //verifica a resposta do usuário 
                if( answer == "S" || answer == "s")
                {
                    // o usuário deseja realizar o cadastro da conta
                    this.tela.limparArea(21,9,69,9);

                    Console.SetCursorPosition(21,9);
                    this.titulo = Console.ReadLine();

                    decimal quantInicial;
                    Console.SetCursorPosition(21, 10);
                    quantInicial = Convert.ToDecimal( Console.ReadLine() );
                    // solicita confitmação para cadastro

                    Console.SetCursorPosition(21,22);
                    Console.Write("Confirma adição (S/N)  :  ");
                    answer = Console.ReadLine();

                    //se o usuário confirmou o cadastro 
                    if (answer == "S" || answer == "s"){
                        this.BaseDadosLivros.Add(new Livros(this.titulo, this.editora, this.autor, this.genero, this.serie));
                    }
                }


                Console.ReadKey();
            }
        }
    }

public void mostrarDadosLivro(){
        
        // este codigo será alterado no futuro
        this.tela.limparArea(1,4,70,24);

        // limpa a area dad tela para mostrar o extrato
        Console.SetCursorPosition(1,4);
        Console.Write("Titulo do livro : ");
        this.titulo = Console.ReadLine();
        if  (this.titulo != "")
        {
            // procura o livro informado no banco de dados
            bool achou = false;
            int x;
            for(x=0; x<this.BaseDadosLivros.Count; x++)
            {
                if (this.BaseDadosLivros[x].titulo == this.titulo)
                {
                    achou = true;
                    this.serie = x;
                    break;
                }
            }
            if(achou)
            {
                string dados = this.BaseDadosLivros[this.serie].mostrarDadosLivro();
                Console.SetCursorPosition(1,4);
                Console.Write(dados);
                Console.ReadKey();
            }
        }
    }

    public void montarTela(int ci, int li, int cf, int lf)
    {
        this.tela.montarMoldura(ci, li, cf,lf);
        this.tela.montarLinhaHor(li+2, ci, cf);
        this.tela.centralizar(li+1, ci , cf, "Adição Livros");
        Console.SetCursorPosition(11,8);
        Console.Write("Titulo  :");
        Console.SetCursorPosition(11,9);
        Console.Write("Editora  :");
        Console.SetCursorPosition(11,10);
        Console.Write("Autor   :");
        Console.SetCursorPosition(11,10);
        Console.Write("Genero   :");

    }
}
