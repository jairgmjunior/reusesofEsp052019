using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EstacaoMetereologica : Subject
    {
        private List<Observer> Observers = new List<Observer>();
        private decimal Temperatura;
        private decimal Pressao;
        private decimal Umidade;

        public void SetMedicoes(decimal temperatura, decimal umidade, decimal pressao)
        {
            this.Temperatura = temperatura;
            this.Umidade = umidade;
            this.Pressao = pressao;

            notifyObservers();
        }

        public void addObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void notifyObservers()
        {
            Observers.ForEach(p => p.Update(Temperatura, Umidade, Pressao));
        }

        public void removeObserver(Observer observer)
        {
            Observers.Remove(observer);
        }
    }
}
