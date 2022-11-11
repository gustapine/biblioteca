class Adicionar
{
    public string nome, editora, autor;
    public int edicao; 
    public DateTime data;


    public Adicionar(string nom,string edit,string autor, int edic, DateTime data)
    {
        this.nome = nom;
        this.editora = edit;
        this.edicao = edic;
        this.autor = autor;
    }
}