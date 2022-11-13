class Livros{

    public static int quantLivros = 0;

    public List<Adicionar> adicao = new List<Adicionar>();
    public string titulo, editora, autor, genero;
    public int quantidadeRestante{
        get{
            int quantidadeFinal = 0;
            foreach(Adicionar adicionar in adicao){
                quantidadeFinal += adicionar.quantidade;
            }
            return quantidadeFinal;
        }

    }

    public Livros(string tit, string edit, string aut, string gen, int quantRest)
    {
        this.titulo = tit;
        this.editora = edit;
        this.autor = aut;
        this.genero = gen;
        this.retornarLivro( tit, edit, autor, DateTime.Now, 2);

        quantLivros++;
    }

    public void retornarLivro (string tit, string edit,string autor, DateTime data, int quant)
    {
        Adicionar retorno = new(tit, edit, autor, data, quant);
        this.adicao.Add(retorno);
    }

    public string mostrarDados()
    {
            string texto ="";

            texto += "O livr é " + this.titulo;
            texto += " da editora " + this.editora;
            texto += " com isto na prateleira: " + this.quantidadeRestante.ToString();

            return texto;
    }

    public string mostrarDadosLivro(){
        var dados = new System.Text.StringBuilder();
        int quantidadeRestante = 0;

        dados.AppendLine( this.mostrarDados());
        dados.AppendLine( "Titulo\t\t\tAutor\t\t\t\tEstoque\t\tEditora"); 

        for(int x=0; x< adicao.Count; x++){
            
            quantidadeRestante+= this.adicao[x].quantidade;
            dados.AppendLine(

                //TIRAR dados cadastro
                this.adicao[x].data.ToShortDateString()+"\t\t"+
                this.adicao[x].autor.ToString()+"\t\t"+
                quantidadeRestante.ToString()+"\t\t"+
                this.adicao[x].editora


            );// vai conter os dados do cadastro
        }
        dados.AppendLine(quantidadeRestante.ToString());//mostrar o RESTANTE lá na tela


        return dados.ToString();
    }


}