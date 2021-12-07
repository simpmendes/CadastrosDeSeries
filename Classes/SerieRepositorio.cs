using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
       private List<Series> listaSerie = new List<Series>();

       public List<Series> Lista(){
           return listaSerie;
       }
       public void Atualiza(int id, Series entidade){
           listaSerie[id]= entidade;
       }
       public void Excluir(int id){
           listaSerie[id].Excluir();
       }
       public void Insere(Series entidade){
           listaSerie.Add(entidade);
       }
       public int ProximoId(){
           return listaSerie.Count;
       }

       public Series RetornaPorId(int id){
           return listaSerie[id];
       }
    }
}