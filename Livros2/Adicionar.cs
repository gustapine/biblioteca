class Adicionar
{

    
    public string titulo, editora, autor;
    public int quantidade;
    public DateTime data;


    public Adicionar(string tit, string edit,string autor, DateTime data, int quant)
    {
        this.titulo = tit;
        this.editora = edit;
        this.autor = autor;
        this.data = data;
        this.quantidade = quant;
        
    }
}