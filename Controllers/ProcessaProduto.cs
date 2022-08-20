using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Aula03_MVC_02.Controllers
{
    public class ProcessaProduto
    {
        public static string cadastraProduto(int id, string nome, string param3, string tipo)
        {
            using (var stream = new StreamWriter(caminhoArquivo, true))
            {
                try
                {
                    stream.Write($"{tipo}|{id}|{nome}|{param3}\r\n");
                    return "Cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static int obterIndiceAtual()
        {
            using (var stream = new StreamReader(caminhoArquivo, true))
            {
                var indiceAtual = 0;
                try
                {
                    while (!stream.EndOfStream)
                    {
                        var retorno = stream.ReadLine();
                        if(retorno.Split('|') != null)
                            indiceAtual = int.Parse(retorno.Split('|')[1]) > indiceAtual ? int.Parse(retorno.Split('|')[1]) : indiceAtual;
                    }
                    return indiceAtual + 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static List<string> mostraProdutos()
        {
            using (var stream = new StreamReader(caminhoArquivo, true))
            {
                var dicionarioProdutos = new List<string>();
                try
                {
                    while (!stream.EndOfStream)
                    {
                        var retorno = stream.ReadLine();
                        dicionarioProdutos.Add(retorno);
                    }
                    return dicionarioProdutos;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private static string caminhoArquivo
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/produtos.txt");
            }
        }
    }
}