public class Fila{
    public No inicio;
    public No fim;

    public Fila(){
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia(){
        if(this.inicio == null && this.fim == null){
            return(true);
        }
        return(false);
    }

    public void enfileirar(int valor){
        
        No novoNo = new No(valor);

        if(this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public Boolean desenfileirar(){

        if(this.estaVazia()){
            return(false);
        }
        else{
            this.inicio = this.inicio.prox;
            return(true);
        }
    }

    public void percurso(){

        No noAtual = this.inicio;

        while(noAtual != null){
            Console.Write(noAtual.valor + "-> ");
            noAtual = noAtual.prox;
        }
        Console.WriteLine("\n");
    }
}