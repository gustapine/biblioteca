Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
CRUDlivros crudLivros = new CRUDlivros (tela);



List<string> menu = new List<string>();
List<string> press = new List<string>();
string opcao;
string pressi;




menu.Add("1 - Ver Livros     ");
menu.Add("2 - Pesquisar por livro");
menu.Add("3 - Adicionar livro     ");
menu.Add("4 - Ver o endereço da Biblioteca ");
menu.Add("0 - Sair        ");

press.Add("Pressione ENTER para começar:");



while(true)
{
    tela.montarTelaGeral();     
    tela.montarLinhaHor(2,0,79);
    tela.centralizar(1,0,79,"Biblioteca");
    pressi = tela.pressStart(26,8,press);
    Console.Clear();

    tela.montarTelaGeral();     
    tela.montarLinhaHor(2,0,79);
    tela.centralizar(1,0,79,"Biblioteca");
    opcao = tela.mostrarMenu(26,8,menu);
    Console.Clear();


    if(opcao == "0") break;
    //if(opcao == "1") 
    if(opcao == "2") crudLivros.controller();
    if(opcao == "3") crudLivros.mostrarDadosLivro();
    if(opcao == "4"){
        Console.Write("Av. Rio Branco, 219 - Centro, Rio de Janeiro - RJ, 20040-008");
        Console.ReadKey();     
    }

}
Console.Clear();