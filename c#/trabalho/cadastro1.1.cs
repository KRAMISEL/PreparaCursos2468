using System;
class cadastro1{
    static int N_deCadastro = 0;
    static int[] quantiCadastro = new int[0],idade = new int[0];
    static string[] nome = new string[0];
    static float[] peso = new float[0],altura = new float[0];
    static char[] sexo = new char[0];
    static void Main(){
        Console.WriteLine("<========================================>\n<=| Atendimento de cadastro ao cliente |=>\n<========================================>\n O que deseja fazer:");
        Menu();
    }
    static void Menu(){
        Console.WriteLine("\n Cadastrar________________________:(1)\n Alteração de cadastro____________:(2)\n Impressão de cadastros____________:(3)\n Excluir cadastro_________________:(4)\n Limpar a tela____________________:(5)\n Sair_____________________________:(6)");
        string execução = Console.ReadLine();
        switch(execução){
            case"1":
            Cadastrar();
            break;
            case"2":
            Alteraçãodecadastro();
            break;
            case"3":
            Impressãodecadastro();
            break;
            case"4":
            Excluircadastro();
            break;
            case"5":
            Limparatela();
            break;
            case"6":
            Sair();
            break;
            default:
            Main();
            break;
        }
    }
    static void Cadastrar(){
        Console.WriteLine("\n<===============>\n<=| Cadastrar |=>\n<===============>\n");
        string[] armazenamentoDeNomes = new string[nome.Length];
        int[] armazenamentoDeCadastros = new int[quantiCadastro.Length],armazenamentoDeIdades = new int[idade.Length];
        float[] armazenamentoDePesos = new float[peso.Length],armazenamentoDeAlturas = new float[altura.Length];
        char[] armazenamentoDeSexos = new char[sexo.Length];
        Array.Copy(quantiCadastro, armazenamentoDeCadastros, quantiCadastro.Length);
        Array.Copy(nome, armazenamentoDeNomes, nome.Length);
        Array.Copy(idade, armazenamentoDeIdades, idade.Length);
        Array.Copy(peso, armazenamentoDePesos, peso.Length);
        Array.Copy(altura, armazenamentoDeAlturas, altura.Length);
        Array.Copy(sexo, armazenamentoDeSexos, sexo.Length);
        if(quantiCadastro.Length > 0){
            Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Length);
        }
        Console.Write(" Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantiCadastro = new int[quantiCadastro.Length + quantidadeDeCadastro];
        nome = new string[nome.Length + quantidadeDeCadastro];
        idade = new int[idade.Length + quantidadeDeCadastro];
        peso = new float[peso.Length + quantidadeDeCadastro];
        altura = new float[altura.Length + quantidadeDeCadastro];
        sexo = new char[sexo.Length + quantidadeDeCadastro];
        if(quantidadeDeCadastro == 0){
            goto avançar;
        }
        Array.Copy(armazenamentoDeCadastros, quantiCadastro, quantiCadastro.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeNomes, nome, nome.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeIdades, idade, idade.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDePesos, peso, peso.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeAlturas, altura, altura.Length - quantidadeDeCadastro);
        Array.Copy(armazenamentoDeSexos, sexo, sexo.Length - quantidadeDeCadastro);
        for(int i = N_deCadastro; i < quantiCadastro.Length; i++){
            Console.WriteLine("\n Cadastro de número__.: |{0}| :.",quantiCadastro[i] = N_deCadastro++ + 1);
            Console.Write(" Digite o seu nome___.: ");
            nome[i] = Console.ReadLine();
            Console.Write(" Digite a sua idade__.: ");
            idade[i] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso___.: ");
            peso[i] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura_.: ");
            altura[i] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo___.: ");
            sexo[i] = char.Parse(Console.ReadLine());
            Console.WriteLine(" ==================================>");
        }
        avançar:
        Console.WriteLine();
        Main();
    }
    static void Alteraçãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Alteração de cadastro |=>\n<===========================>\n");
        if(quantiCadastro.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar0;
        }else if(quantiCadastro.Length == 1){
            Console.Write(" Digite o seu nome___.: ");
            nome[0] = Console.ReadLine();
            Console.Write(" Digite a sua idade__.: ");
            idade[0] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso___.: ");
            peso[0] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura_.: ");
            altura[0] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo___.: ");
            sexo[0] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro alterado.\n ====================>");
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Length);
        Console.Write(" Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] altCadastro = new int[alterarCadastro];
        if(alterarCadastro > quantiCadastro.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(alterarCadastro == 0){
            goto avançar2;
        }else if(alterarCadastro == quantiCadastro.Length){
            for(int i = 0; i < alterarCadastro; i++){
                Console.Write("\n Digite o seu nome___.: ");
                nome[i] = Console.ReadLine();
                Console.Write(" Digite a sua idade__.: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso___.: ");
                peso[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura_.: ");
                altura[i] = float.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo___.: ");
                sexo[i] = char.Parse(Console.ReadLine());
                Console.WriteLine(" Cadastro |{0}| alterado.\n ========================================>",quantiCadastro[i]);
            }
        Console.ReadLine();
        goto avançar3;
        }
        voltar:
        if(alterarCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja alterar: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja alterar: ");
        }
        for(int i = 0; i < altCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            altCadastro[i] = A - 1;
            if(altCadastro[i] >= quantiCadastro.Length || altCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000001.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        for(int i = 0; i < altCadastro.Length; i++){
            Console.Write("\n Digite o seu nome___.: ");
            nome[altCadastro[i]] = Console.ReadLine();
            Console.Write(" Digite a sua idade__.: ");
            idade[altCadastro[i]] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso___.: ");
            peso[altCadastro[i]] = float.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura_.: ");
            altura[altCadastro[i]] = float.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo___.: ");
            sexo[altCadastro[i]] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro |{0}| alterado.\n ========================================>",altCadastro[i] + 1);
        }
        Console.WriteLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Impressãodecadastro(){
        Console.WriteLine("\n<===========================>\n<=| Impressão de cadastros |=>\n<===========================>\n");
        if(quantiCadastro.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar0;
        }else if(quantiCadastro.Length == 1){
            Console.WriteLine(" Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n ===============================>",quantiCadastro[0],nome[0],idade[0],peso[0],altura[0],sexo[0]);
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Length);
        Console.Write(" Quantos cadastros deseja imprimir: ");
        int imprimirCadastro = int.Parse(Console.ReadLine());
        int[] impCadastro = new int[imprimirCadastro];
        if(imprimirCadastro > quantiCadastro.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem imprimidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(imprimirCadastro == 0){
            goto avançar2;
        }else if(imprimirCadastro == quantiCadastro.Length){
            for(int i = 0; i < quantiCadastro.Length; i++){
                Console.Write("\n Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n ===============================>\n",quantiCadastro[i],nome[i],idade[i],peso[i],altura[i],sexo[i]);
            }
            Console.ReadLine();
            goto avançar3;
        }
        voltar:
        if(imprimirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja imprimir: ");
        }else{
            Console.WriteLine("\n Quais cadastros deseja imprimir: ");
        }
        for(int i = 0; i < impCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            impCadastro[i] = A - 1;
            if(impCadastro[i] >= quantiCadastro.Length || impCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000002.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        for(int i = 0; i < impCadastro.Length; i++){
            Console.Write("\n Cadastro..: |{0}| :.\n Nome...: {1}\n Idade..: {2}\n Peso...: {3}\n Altura.: {4}\n Sexo...: {5}\n =============================>\n",impCadastro[i] + 1,nome[impCadastro[i]],idade[impCadastro[i]],peso[impCadastro[i]],altura[impCadastro[i]],sexo[impCadastro[i]]);
        }
        Console.ReadLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Excluircadastro(){
        Console.WriteLine("\n<======================>\n<=| Excluir cadastro |=>\n<======================>\n");
        if(quantiCadastro.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar0;
        }else if(quantiCadastro.Length == 1){
            quantiCadastro = new int[quantiCadastro.Length - 1];
            nome = new string[nome.Length - 1];
            idade = new int[idade.Length - 1];
            peso = new float[peso.Length - 1];
            altura = new float[altura.Length - 1];
            sexo = new char[sexo.Length - 1];
            N_deCadastro -= 1;
            Console.WriteLine(" Cadastro excluido.");
            Console.ReadLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Quantidade de cadastros.: <( {0} )>\n",quantiCadastro.Length);
        Console.Write(" Quantos cadastros deseja excluir: ");
        int excluirCadastro = int.Parse(Console.ReadLine());
        int[] excCadastro = new int[excluirCadastro], armazenamentoDeCadastros = new int[quantiCadastro.Length - excluirCadastro], armazenamentoDeIdades = new int[idade.Length - excluirCadastro];
        string[] armazenamentoDeNomes = new string[nome.Length - excluirCadastro];
        float[] armazenamentoDePesos = new float[peso.Length - excluirCadastro], armazenamentoDeAlturas = new float[altura.Length - excluirCadastro];
        char[] armazenamentoDeSexos = new char[sexo.Length - excluirCadastro];
        if(excluirCadastro > quantiCadastro.Length){
            Console.WriteLine(" A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }else if(excluirCadastro == 0){
            goto avançar2;
        }else if(excluirCadastro == quantiCadastro.Length){
            quantiCadastro = new int[quantiCadastro.Length - excluirCadastro];
            nome = new string[nome.Length - excluirCadastro];
            idade = new int[idade.Length - excluirCadastro];
            peso = new float[peso.Length - excluirCadastro];
            altura = new float[altura.Length - excluirCadastro];
            sexo = new char[sexo.Length - excluirCadastro];
            N_deCadastro -= excluirCadastro;
            Console.Write("\n Todos os cadastros foram excluidos.");
            Console.ReadLine();
            goto avançar3;
        }
        voltar:
        if(excluirCadastro == 1){
            Console.WriteLine("\n Qual cadastro deseja excluir:");
        }else{
            Console.WriteLine("\n Quais cadastros deseja excluir:");
        }
        for(int i = 0; i < excCadastro.Length; i++){
            int A = int.Parse(Console.ReadLine());
            excCadastro[i] = A - 1;
            if(excCadastro[i] >= quantiCadastro.Length || excCadastro[i] == -1){
                Console.WriteLine("\n ERRO:/0000003.0\n Falha na indentificação do cadastro.");
                Console.ReadLine();
                goto voltar;
            }
        }
        Array.Sort(excCadastro);
        Array.Reverse(excCadastro);
        for(int i = 0; i < excCadastro.Length; i++){
            for(int ia = excCadastro[i]; ia < quantiCadastro.Length - 1; ia++){
                nome[ia] = nome[ia + 1];
                idade[ia] = idade[ia + 1];
                peso[ia] = peso[ia + 1];
                altura[ia] = altura[ia + 1];
                sexo[ia] = sexo[ia + 1];
            }
        }
        Array.Copy(quantiCadastro, armazenamentoDeCadastros, quantiCadastro.Length - excluirCadastro);
        Array.Copy(nome, armazenamentoDeNomes, nome.Length - excluirCadastro);
        Array.Copy(idade, armazenamentoDeIdades, idade.Length - excluirCadastro);
        Array.Copy(peso, armazenamentoDePesos, peso.Length - excluirCadastro);
        Array.Copy(altura, armazenamentoDeAlturas, altura.Length - excluirCadastro);
        Array.Copy(sexo, armazenamentoDeSexos, sexo.Length - excluirCadastro);
        quantiCadastro = new int[quantiCadastro.Length - excluirCadastro];
        nome = new string[nome.Length - excluirCadastro];
        idade = new int[idade.Length - excluirCadastro];
        peso = new float[peso.Length - excluirCadastro];
        altura = new float[altura.Length - excluirCadastro];
        sexo = new char[sexo.Length - excluirCadastro];
        Array.Copy(armazenamentoDeCadastros, quantiCadastro, quantiCadastro.Length);
        Array.Copy(armazenamentoDeNomes, nome, nome.Length);
        Array.Copy(armazenamentoDeIdades, idade, idade.Length);
        Array.Copy(armazenamentoDePesos, peso, peso.Length);
        Array.Copy(armazenamentoDeAlturas, altura, altura.Length);
        Array.Copy(armazenamentoDeSexos, sexo, sexo.Length);
        Array.Sort(excCadastro);
        for(int i = 0; i < excCadastro.Length; i++){
            Console.WriteLine("\n Cadastro |{0}| excluido.",excCadastro[i] + 1);
        }
        N_deCadastro -= excCadastro.Length;
        Console.ReadLine();
        avançar0:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Limparatela(){
        Console.Clear();
        Main();
    }
    static void Sair(){
        Console.WriteLine("\n Volte sempre.");
    }   
}