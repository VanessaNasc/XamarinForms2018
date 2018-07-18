using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;


namespace App01_ConsultarCEP.Servico
{
   public class ViaCEPServico
    {
        private static string EnderecoURL =
            "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)//captura o cep digitado pelo usuario na tela
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);//substitui o ep cep digitado pelo usuário na URL

            //Busca na internet
            //classe webclient
            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);


           Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);
            if (end.cep == null) return null;
            return end;
        }

    }
}
