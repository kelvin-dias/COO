using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System;
using System.Linq;

namespace Servico.Entidades
{
    public class OcorrenciaServico
    {
        OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();

        public IQueryable ObterOcorrenciasClassificadasPorDataHora()
        {
            return ocorrenciaDAL.ObterOcorrenciasClassificadasPorDataHora();
        }

        public Ocorrencia ObterOcorrenciaPorId(long? id)
        {
            return ocorrenciaDAL.ObterOcorrenciaPorId(id);
        }

        public void GravarOcorrencia(Ocorrencia ocorrencia)
        {
            ocorrenciaDAL.GravarOcorrencia(ocorrencia);
        }

        public Ocorrencia ObterOcorrenciaPorNumero(long numeroOcorrencia)
        {
            return ocorrenciaDAL.ObterOcorrenciaPorNumero(numeroOcorrencia);
        }

        public long GerarNumeroOcorrencia() {

            /*GERANDO NÚMERO DE OCORRENCIA E VALIDANDO NO BANCO DE DADOS */
            long numeroOcorrencia = 0;
            Random randNum = new Random();
            bool statusValidacao = false;
            do
            {
                long numero = randNum.Next(100000, 999999);
                if (ObterOcorrenciaPorNumero(numero) == null)

                {
                    numeroOcorrencia = numero;
                    statusValidacao = true;
                }

            } while (statusValidacao == false);

            return numeroOcorrencia;
        }
    }
}
