using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio8
    {
        public List<string> tarefas = new List<string>();

        public void Adicionar(string tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void Remover(string tarefa)
        {
            tarefas.Remove(tarefa);            
        }

        public bool Verificar(string tarefa)
        {
            if (tarefas.Contains(tarefa)){                
                return true;
            }
            else
            {                
                return false;
            }
        }

        public int Contar()
        {
            int quantidade = tarefas.Count();
            return quantidade;
        }

        public void Listar()
        {
            Console.WriteLine(string.Join(", ", tarefas));               
        }
    }
}
