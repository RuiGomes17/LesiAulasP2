using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aulas.Models;

namespace Aulas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class PlataformaController
    {
        private Menu _menuState;
        
        public PlataformaController()
        {
        }
        // TODO: 
        // Hack: 
        //
        public void InicializarPlataformaController()
        {
            while (_menuState != Menu.Sair)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine(((int)Menu.Sair)+" Para saír");
                string opcao = Console.ReadLine();

                if (Menu.TryParse(opcao, out _menuState))
                {
                    Console.WriteLine("Ok");
                    Console.WriteLine("Prima qualquer tecla para continuar");
                }
                else
                {
                    _menuState = Menu.Invalido;
                    Console.WriteLine("Not ok");
                    Console.WriteLine("Prima qualquer tecla para continuar");
                }

                switch (_menuState)
                {
                    case Menu.InserirArtigo:
                        Console.WriteLine("Insira o artigo desejado...");
                        Console.ReadLine();
                        break;
                    case Menu.ListarArtigos:
                        Console.WriteLine("Listar o artigo desejado...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
