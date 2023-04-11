using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos de Array C#
////TestesBuscarPalavra();

////void TestesBuscarPalavra()
////{
////    string[] arrayDePalavras = new string[5];

////    for (int i = 0; i < arrayDePalavras.Length; i++)
////    {
////        Console.WriteLine($"Digitar {i + 1}ª Palavrar");

////        arrayDePalavras[i] = Console.ReadLine();

////    }

////    Console.WriteLine("Digita a palavra a ser encontrada");
////    var xBusca = Console.ReadLine();

////    foreach (string palavra in arrayDePalavras)
////    {
////        if (palavra.Equals(xBusca))
////        {
////            Console.WriteLine($"Palavra encontrado igual {xBusca}");

////            break;
////        }

////    }
////}

////Array amostra = Array.CreateInstance(typeof(double), 5);

////amostra.SetValue(5.9, 0);
////amostra.SetValue(1.8, 1);
////amostra.SetValue(7.1, 2);
////amostra.SetValue(10, 3);
////amostra.SetValue(6.9, 4);
////TestarMediana(amostra);


////void TestarMediana(Array array)
////{
////    if (array == null || array.Length == 0)
////    {
////        Console.WriteLine("Array para calculo da mediana está vazio ou nulo");
////    }

////    double[] numerosOrdenados = (double[])array.Clone();

////    Array.Sort(numerosOrdenados);


////    int xTamanho = numerosOrdenados.Length;

////    int meio = xTamanho / 2;

////    double mediana = (xTamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;


////    Console.WriteLine($"A mediana é {mediana}");
////}
//TestarArryDeCOntasCorrentes();

//void TestarArryDeCOntasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(884));
//    listaDeContas.Adicionar(new ContaCorrente(894));
//    listaDeContas.Adicionar(new ContaCorrente(994));
//    listaDeContas.Adicionar(new ContaCorrente(844));
//    listaDeContas.Adicionar(new ContaCorrente(844));

//    var contaDoAndre = new ContaCorrente(968);
//    listaDeContas.Adicionar(contaDoAndre);


//    //listaDeContas.ExibeLista();

//    //Console.WriteLine("===========================");
//    //listaDeContas.Remover(contaDoAndre);
//    //Console.WriteLine("===========================");
//    //listaDeContas.ExibeLista();
//    //Console.WriteLine("===========================");

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");

//    }


//}



//#endregion

#endregion


new BytebankAtendimento().AtendimentoCliente();

//List<ContaCorrente> listaDeContas = new List<ContaCorrente>()
//{
//    new ContaCorrente(123){Saldo= 100, Titular = new Cliente{Cpf= "111111",Nome ="Henrique"} },
//    new ContaCorrente(43){Saldo= 200, Titular = new Cliente{Cpf= "222222",Nome ="Pedro"}},
//    new ContaCorrente(43){Saldo= 400, Titular = new Cliente{Cpf= "333333",Nome ="Marisa"}}
//};
//AtendimentoCliente();

//void AtendimentoCliente()
//{
//    try
//    {
//        char opcao = '0';
//        while (opcao != '6')
//        {
//            Console.Clear();
//            Console.WriteLine("==================================");
//            Console.WriteLine("===        Atendimento         ===");
//            Console.WriteLine("===  1 - Cadastrar Conta       ===");
//            Console.WriteLine("===  2 - Listar Contas         ===");
//            Console.WriteLine("===  3 - Remover Conta         ===");
//            Console.WriteLine("===  4 - Ordenar Contas        ===");
//            Console.WriteLine("===  5 - Pesquisar Conta       ===");
//            Console.WriteLine("===  6 - Sair de Sistema       ===");
//            Console.WriteLine("==================================");
//            Console.WriteLine("\n\n");
//            Console.WriteLine("Difite a opção desejada :  ");
//            try
//            {
//                opcao = Console.ReadLine()[0];
//            }
//            catch (Exception ex)
//            {

//                throw new ByteBankExceptions(ex.Message);
//            }

//            switch (opcao)
//            {
//                case '1':
//                    CadastrarConta();
//                    break;
//                case '2':
//                    ListarContas();
//                    break;
//                case '3':
//                    RemoverContas();
//                    break;
//                case '4':
//                    OrdenarContas();
//                    break;
//                case '5':
//                    PesquisarConta();
//                    break;
//                default:
//                    Console.WriteLine("Opção não implementada.");
//                    break;

//            }
//        }
//    }

//    catch (ByteBankExceptions ex)
//    {

//        Console.WriteLine($"{ex.Message}");
//    }

//    void ListarContas()
//    {
//        Console.Clear();
//        Console.WriteLine("==================================");
//        Console.WriteLine("====     LISTA DE CONTAS      ====");
//        Console.WriteLine("==================================");
//        Console.WriteLine("\n");

//        if (listaDeContas.Count <= 0)
//        {
//            Console.WriteLine("... Não há Contas Cadastradas");
//            Console.ReadKey();
//            return;
//        }

//        foreach (ContaCorrente item in listaDeContas)
//        {

//            Console.WriteLine("==================================");
//            //Console.WriteLine("====       DADOS DA CONTA     ====");
//            //Console.WriteLine("Numero da conta : " + item.Conta);
//            //Console.WriteLine("Saldo da conta : " + item.Saldo);
//            //Console.WriteLine("Titular da Conta : " + item.Titular.Nome);
//            //Console.WriteLine("CPF do Titular : " + item.Titular.Cpf);
//            //Console.WriteLine("Professição do Titular : " + item.Titular.Profissao);

//            Console.WriteLine(item.ToString());
//            Console.WriteLine("==================================");

//        }
//        Console.ReadKey();
//    }

//    void CadastrarConta()
//    {
//        Console.Clear();
//        Console.WriteLine("==================================");
//        Console.WriteLine("====    CADASTRO DE CONTAS    ====");
//        Console.WriteLine("==================================");
//        Console.WriteLine("\n");
//        Console.WriteLine("==== Informe os dados da Conta ====");
//        Console.Write("Numero da Conta:  ");
//        string numeroConta = Console.ReadLine();

//        Console.Write("Numero da Agencia:  "); // Aqui ele vai digar o  numero da agencia
//        int numeroAgencia = int.Parse(Console.ReadLine()); // Aqui o sistema vai converte no tipo int

//        ContaCorrente conta = new ContaCorrente(numeroAgencia);

//        Console.Write("Informe o Saldo Inicial :  ");
//        conta.Saldo = double.Parse(Console.ReadLine());

//        Console.Write("Informe do nome do Titular:  ");
//        conta.Titular.Nome = Console.ReadLine();

//        Console.Write("Informe o CPF do Titular:  ");
//        conta.Titular.Cpf = Console.ReadLine();

//        Console.Write("Informe a Profissão do TItular:  ");
//        conta.Titular.Profissao = Console.ReadLine();

//        listaDeContas.Add(conta);

//        Console.WriteLine("... Conta Cadastrada com sucesso! ....");
//        Console.ReadKey();




//    }




//}

//void PesquisarConta()
//{

//    Console.Clear();
//    Console.WriteLine("==================================");
//    Console.WriteLine("====    PESQUISAR CONTAS    ====");
//    Console.WriteLine("==================================");
//    Console.WriteLine("\n");
//    Console.WriteLine("DESEJA PESQUISAR PELO NUMERO DA CONTA 1 OU 2 CPF DO TITULAR OU  3  Nº DA AGENCIA? ");
//    switch (int.Parse(Console.ReadLine()))
//    {
//        case 1:
//            {
//                Console.WriteLine("Informe o numero da Conta: ");
//                string numeroConta = Console.ReadLine();
//                ContaCorrente consultarConta = ConsultarPorNumeroDaConta(numeroConta);
//                Console.WriteLine(consultarConta.ToString());
//                Console.ReadKey();
//                break;
//            }
//        case 2:
//            {
//                Console.WriteLine("Informe o CPF do Titular: ");
//                string cpf = Console.ReadLine();
//                ContaCorrente consultarCPF = ConsultarPorCPFDoTitular(cpf);
//                Console.WriteLine(consultarCPF.ToString());
//                Console.ReadKey();
//                break;
//            }
//        case 3:
//            {
//                Console.WriteLine("Informe o Nº da Agencia: ");
//                int xNumeroDaAgencia = int.Parse(Console.ReadLine());
//                //ContaCorrente xConta = listaDeContas.Where(conta => conta.Numero_agencia == xNumeroDaAgencia).FirstOrDefault();
//                var xConta = ConsultarPorAgencia(xNumeroDaAgencia);
//                ExibirListaDeContas(xConta);
//                Console.ReadKey();
//                break;
//            }
//        default:
//            Console.WriteLine("Opção Não Implementrada.");
//            break;

//    }
//}

//void ExibirListaDeContas(List<ContaCorrente> xConta)
//{
//    if (xConta.Count == 0 || xConta == null)
//    {
//        Console.WriteLine("... A Consulta não retornou Dados ...");
//    }
//    else
//    {
//        foreach(var item in xConta)
//        {
//            Console.WriteLine(item.ToString());
//        }

//    }
//}

//List<ContaCorrente> ConsultarPorAgencia(int numeroDaAgencia)
//{
//    var consulta = (
//            from conta in listaDeContas
//            where conta.Numero_agencia == numeroDaAgencia
//            select conta).ToList();

//    return consulta;
//}
//ContaCorrente ConsultarPorCPFDoTitular(string? cpf)
//{
//    //ContaCorrente conta = null;
//    //for (int i= 0; i< listaDeContas.Count; i++)
//    //{
//    //    if(listaDeContas[i].Titular.Cpf == cpf)
//    //    {
//    //        conta = listaDeContas[i];
//    //    }
//    //}
//    //return conta;
//    return listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();

//}

//ContaCorrente ConsultarPorNumeroDaConta(string? numeroConta)
//{
//    //ContaCorrente conta = null;
//    //for (int i = 0; i < listaDeContas.Count; i++)
//    //{
//    //    if (listaDeContas[i].Conta.Equals(numeroConta))
//    //    {
//    //        conta = listaDeContas[i];
//    //    }
//    //}
//    //return conta;
//    return listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
//}

//void OrdenarContas()
//{
//    listaDeContas.Sort();
//    Console.WriteLine("... Lista de Contas Ordenada ...");
//    Console.ReadKey();


//}

//void RemoverContas()
//{
//    Console.Clear();
//    Console.WriteLine("==================================");
//    Console.WriteLine("====    REMOVER CONTAS    ====");
//    Console.WriteLine("==================================");
//    Console.WriteLine("\n");
//    Console.WriteLine("INFORME O NUMERO DA CONTA:");
//    string numeroConta = Console.ReadLine();
//    ContaCorrente conta = null;

//    foreach (var xItem in listaDeContas)
//    {
//        if (xItem.Conta.Equals(numeroConta)) conta = xItem;

//    }
//    if (conta != null)
//    {
//        listaDeContas.Remove(conta);
//        Console.WriteLine("... COnta Removida da Lista! ...");
//    }
//    else
//    {
//        Console.WriteLine(".... COnta pra remoção não encontrada ....");
//    }
//    Console.ReadKey();

//}