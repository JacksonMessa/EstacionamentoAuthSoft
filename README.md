<h1>Estacionamento AuthSoft</h1> 

<h2>Como Executar</h2>

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/JacksonMessa/EstacionamentoAuthSoft

2. **Abra o arquivo .slxs na pasta do projeto com o Visual Studio**
   
3. **Adicione os pacores faltando** <br>
  Vá em projeto>Gerenciar pacotes do NuGet
  Clique em restaurar.

4. **Clique em iniciar para compilar e executar**

<h2>Decisões</h2>

1.  Fiz o passo a passo pelo Visual Studio porque tive problemas com dll do SqLite ao tentar compilar pelo terminal;
2.  Apesar de não falar que a placa é obrigatória no cadastro de veículos, coloquei ela como obrigatória, porque é a identificação do veículo;
3.  Permiti o hífen apenas na posição certa, pois acredito que diminui o número de erros;
4.  Decidi mostrar a placa na comboBox da entrada mesmo que o veículo estiver estacionado e depois mostrar que ele já está estacionado para que o usuário não tenha dúvida se a placa não está lá ou ele não está encontrando ela;
5.  Decidi mostrar o valor, após a registrar a saída para facilitar a cobrança;
6.  Coloquei a data de entrada como valor mínimo para a saída, assim não correndo o risco do usuário inserir errado;
7.  Ao invés de mostrar somente a arrecadação total decidi mostrar todas as arrecadações do dia para ter mais dados visíveis para o usuário
8.  Formatei a placa, também no filtro da tela de listagem de veículos para facilitar o usuário.
   
