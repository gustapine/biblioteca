
namespace BibliotecaCrud{
    class Livros{

    //propriedades
    private static string titulo, editora, autor, genero;
    private static int edicao; 





        // public Livros (string tit,string edit,string autor, int edic, string gen){

        //     this.titulo = tit;
        //     this.editora = edit;
        //     this.edicao = edic;
        //     this.autor = autor;
        //     this.genero = gen;
        // }



        private static void infoLivroEntrada()
        {

                        Console.Write("Título do livro: ");
                        titulo = Console.ReadLine().ToLower();
                        Console.Write("Nome do autor: ");
                        autor = Console.ReadLine().ToLower();
                        Console.Write("Coloque o genero: ");
                        genero = Console.ReadLine().ToLower();
                        Console.Write("Nome da editora: ");
                        editora = Console.ReadLine().ToLower();
                        Console.Write("Edição: ");
                        edicao = Convert.ToInt32(Console.ReadLine());
                        // edicao_str = edicao.ToString();
        }

        //   public static void AddBook()
        // {
        //     OpenConnection();
        //     InputBookInfo();
        //     string addBookQuery = "insert into tblBook (title, author, isbn ,price, genre) " +
        //                  "values('" + bookTitle + "', '" + bookAuthor + "', " +
        //                  "'" + bookISBN_str + "', '" + bookPrice + "', '" + bookGenre + "')";
        //     int ctr = ExecuteQueries(addBookQuery);
        //     if(ctr > 0)
        //         Console.WriteLine("\nNew book added....\n");
        //     CloseConnection();
        // }

        // public static void DeleteBookByID(uint bookID)
        // {
        //     OpenConnection();
        //     string deleteBookbyId = "delete from tblBook where Id = '" + bookID + "'";
        //     int ctr = ExecuteQueries(deleteBookbyId);
        //     if(ctr > 0)
        //         Console.WriteLine("\nBook id: {0} deleted....\n", bookID);
        //     else
        //         Console.WriteLine("\nBook id: {0} available in the database....\n", bookID);
        //     CloseConnection();
        // }

        // public static void DeleteBookByTitle(string bookTitle)
        // {
        //     OpenConnection();
        //     string deleteBookbyTitle = "delete from tblBook where title = '" + bookTitle.ToLower() + "'";
        //     int ctr = ExecuteQueries(deleteBookbyTitle);
        //     if (ctr > 0)
        //         Console.WriteLine("\nNo. of books deleted: {0}\n", ctr.ToString());
        //     else
        //         Console.WriteLine("\nBook title: '{0}' not available in the database....\n", bookTitle);
        //     CloseConnection();
        // }

        // public static void ShowBookCount()
        // {
        //     Console.WriteLine("Available books: {0}\n", CountRecords().ToString());
        // }

        // public static void ShowAllBooks()
        // {
        //     OpenConnection();
        //     Console.WriteLine("\nSHOWING ALL BOOKS:\n");
        //     string[] val;
        //     var table = new ConsoleTable("ID", "Title", "Author", "Price");
        //     string showAllBooks = "select id, title, author, price from tblBook";
        //     SqlDataReader reader = DataReader(showAllBooks);
        //     if (reader.HasRows)
        //     {
        //         while (reader.Read())
        //         {
        //             val = new string[reader.FieldCount];
        //             for (int i = 0; i < reader.FieldCount; i++)
        //                 val[i] = Convert.ToString(reader.GetValue(i));
        //             table.AddRow(val[0], val[1], val[2], "$" + val[3].ToString());
        //         }
        //         table.Write();
        //         Console.WriteLine();
        //     }
        //     else
        //         Console.WriteLine("No Records available in the database....\n");
        //     CloseConnection();
        // }

        // public static void UpdateBookByID(uint bookID)
        // {
        //     if(CheckPkExists(bookID))
        //     {
        //         GetBookDetails(bookID);
        //         InputBookInfo();
        //         OpenConnection();
        //         string updateBookbyId = "update tblBook set title = '" + bookTitle + "', author = " +
        //                      "'" + bookAuthor + "', isbn = '" + bookISBN + "', price = " +
        //                      "'" + bookPrice + "', genre = '" + bookGenre + "' where Id = '" + bookID + "'";
        //         ExecuteQueries(updateBookbyId);
        //         Console.WriteLine("\nBook id: {0} updated sucessfully....\n", bookID);
        //         CloseConnection();
        //     }
        //     else
        //         Console.WriteLine("\nBook id: {0} does not exist in database....\n", bookID);
        // }

        // public static void GetBookDetails(uint bookID)
        // {
        //     OpenConnection();
        //     string[] val;
        //     string getBookDetails = "SELECT title, author, isbn, price, genre FROM tblBook where Id = " +
        //                  "'" + bookID + "'";
        //     SqlDataReader reader = DataReader(getBookDetails);
        //     if (reader.HasRows)
        //     {
        //         val = new string[reader.FieldCount];
        //         while (reader.Read())
        //         {
        //             for (int i = 0; i < reader.FieldCount; i++)
        //                 val[i] = Convert.ToString(reader.GetValue(i));
        //         }
        //         Console.WriteLine("\nTitle: {0}", val[0]);
        //         Console.WriteLine("Author: {0}", val[1]);
        //         Console.WriteLine("ISBN No.: {0}", val[2]);
        //         Console.WriteLine("Price: ${0}", val[3]);
        //         Console.WriteLine("Genre: {0}\n", val[4]);
        //     }
        //     else
        //         Console.WriteLine("\nBook id: {0} not availabe in the database....\n", bookID);
        //     CloseConnection();
        // }

        // public static uint pegaLivroID()
        // {
        //     Console.Write("Coloque ID: ");
        //     uint livroID = Convert.ToUInt16(Console.ReadLine());
        //     return livroID;
        // }

        // public static string pegaTituloLivro()
        // {
        //     Console.Write("Coloque o título: ");
        //     string tituloLivro = Console.ReadLine();
        //     return tituloLivro;
        // }
    }

}