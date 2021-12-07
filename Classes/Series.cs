namespace DIO.Series
{
    using System;
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido{get; set;}

        public Series(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero= genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido= false;

        }
        public override string ToString(){
            string retorno = "";
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno += "Descricao: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano de Início"+ this.Ano;
            retorno += "Excluído: "+ this.Excluido;
            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;
        }
        
    }
}