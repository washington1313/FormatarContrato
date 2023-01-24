using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatarContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome, email, rua, bairro, cidade, estado, cpf;
            string sexo1 = null; 
            int dia, mes, ano, numeroResidencia;
            char sexo;
            var date = DateTime.Now;
            double valorImovel;

            Console.WriteLine("Digite o Nome: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o e-mail: ");
            email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite DIA de nascimento: ");
            dia = int.Parse ( Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite MÊS de nascimento: ");
            mes = int.Parse ( Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite ANO de nascimento: ");
            ano = int.Parse ( Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe o sexo: (M) Masculino ou (F) Feminino: ");
            sexo = char.Parse(Console.ReadLine ());
            Console.Clear();

            Console.WriteLine("Digite a RUA: ");   
            rua = Console.ReadLine ();
            Console.Clear();

            Console.WriteLine("Digite o Número da Residência: ");
            numeroResidencia= int.Parse ( Console.ReadLine ());
            Console.Clear();

            Console.WriteLine("Digite o Bairro: ");
            bairro = Console.ReadLine ();
            Console.Clear();

            Console.WriteLine("Digite a Cidade: ");
            cidade = Console.ReadLine ();
            Console.Clear();

            Console.WriteLine("Digite o Estado: ");
            estado = Console.ReadLine ();
            Console.Clear();

            Console.WriteLine("Digite o Valor do Imovel: ");
            valorImovel = double.Parse ( Console.ReadLine ());
            Console.Clear();

            if (sexo == 'M'||sexo =='m') 
            {
               sexo1 = "o Proprietário";            
            }

            else if (sexo == 'F'||sexo == 'f')
            {
                sexo1 = "a Proprietária";  
            }

            Console.WriteLine("* 1. Cláusula primeira de compra de imóvel *");
            Console.WriteLine("* O contrato atual está sendo firmado como intençao de venda do imóvel *");
            Console.WriteLine("* que está localizado no endereço " + rua + ", " +numeroResidencia+ ", " +bairro);
            Console.WriteLine(", " + cidade + ", " + estado + "está a venda pela quantia de R$" +valorImovel);
            Console.WriteLine("* sendo assim "+ sexo1 +", cujo o nome é "+ nome +" e o sobrenome é "+ sobrenome );
            Console.WriteLine("* que possui o CPF: "+ cpf +", cuja data de nascimento é: "+ dia +"/"+ mes +"/"+ano);
            Console.WriteLine("* aprova a inicialização do processo de venda deste imóvel e receberá as propostas *");
            Console.WriteLine("* no e-mail: "+ email + "*");
            Console.WriteLine("* Este contrato é válido por 2 doas úteis. Data atual do contrato "+ date);


            Console.ReadKey();






        }

    }
}
