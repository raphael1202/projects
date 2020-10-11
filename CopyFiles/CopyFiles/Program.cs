using System;
using System.Configuration;
using System.IO;

namespace CopyFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pegando arquivos do diretório de origem e copiando para o de destino");
            Console.WriteLine("data informada: " + ConfigurationManager.AppSettings["data"]);
            Console.WriteLine("extensão informada: " + ConfigurationManager.AppSettings["extensao"]);
            Console.WriteLine("Pegando arquivos do diretório de origem e copiando para o de destino");
            TransfArquivos();
            Console.WriteLine("Transferencia de arquivos concluida");
            Console.ReadKey();
        }

        public static void TransfArquivos()
        {
            DirectoryInfo origem = new DirectoryInfo(ConfigurationManager.AppSettings["pastaOrigem"]);
            Console.WriteLine("Pasta de origem: " + origem.FullName);
            DirectoryInfo destino = new DirectoryInfo(ConfigurationManager.AppSettings["pastaDestino"]);
            Console.WriteLine("Pasta de destino: " + destino.FullName);

            foreach (FileInfo item in origem.GetFiles((ConfigurationManager.AppSettings["extensao"])))
            {
                DateTime arquivoCriado = item.CreationTime;
                var data = (ConfigurationManager.AppSettings["data"]);

                if (data == "")
                    data = DateTime.Today.Date.ToString();

                if (arquivoCriado.Date != Convert.ToDateTime(data).Date)
                    continue;
                else
                {
                    try
                    {
                        item.CopyTo(destino.FullName + "/" + item.Name, true);
                        Console.WriteLine("Arquivo: " + item.Name + " copiado com sucesso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("O arquivo: " + item.Name + " não foi copiado, erro: " + ex.Message);
                    }
                }
            }
        }
    }
}
