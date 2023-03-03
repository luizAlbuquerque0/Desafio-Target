# Desafio-Target
<h3> Informações sobre o projeto: </h2>
<h2>A pasta DesafioTarge contem 3 classes: </h2>
<h2>1. FibonacciSequence.cs </h2>
  
 <p>A classe FibonacciSequence é responsável por gerar e validar uma sequência de Fibonacci até um determinado número informado pelo usuário.</p>
 <p> A sequência de Fibonacci é uma série de números em que cada número subsequente é a soma dos dois números anteriores. A sequência começa com 0 e 1 e continua indefinidamente, podendo ser expressa como: 0, 1, 1, 2, 3, 5, 8, 13, 21, ... </p>
 
 <h3>A classe FibonacciSequence possui três métodos:</h3>
 <h3>1.1 public void GetFibonacciSequence() </h3>
 <p>O método GetFibonacciSequence solicita ao usuário um número inteiro e, em seguida, valida se o número é maior ou igual a zero. Caso seja negativo, é exibida uma mensagem de erro. Em seguida, o método chama o método CalculateFibonacciSequence para gerar a sequência de Fibonacci até o número informado pelo usuário. Por fim, o método exibe se o número informado pertence à sequência de Fibonacci gerada e a própria sequência até o número informado. </p>
 <h3>1.2 public List<int> CalculateFibonacciSequence(int target) </h3>
 <p>O método CalculateFibonacciSequence recebe um número inteiro target como entrada e retorna uma lista de inteiros que representa a sequência de Fibonacci até o número informado. O método utiliza um laço while para calcular cada número subsequente da sequência, adicionando-o à lista res. </p>
 <h3>1.3 private bool InputValidation(int input) </h3>
 <p>O método InputValidation recebe um número inteiro input como entrada e retorna um valor booleano true se o número for maior ou igual a zero e false caso contrário. </p>
 
 
 <h2>2. StringInverter.cs </h2>
 <p>A classe StringInverter, contém um método GetStringInverted(). Ao chamar este método, o usuário é solicitado a inserir uma string. Em seguida, o programa usa um loop for para iterar por cada caractere da string inserida, começando do último caractere até o primeiro, e concatena cada caractere em uma nova string chamada invertedString. Finalmente, o programa exibe a string invertida na tela.</p>
 
 
 <h2>3. Program.cs </h2>
 <p>Este arquivo tem como objetivo testar as duas outras classes do projeto. Para fazer isso, é necessário primeiro instanciar a classe desejada e, em seguida, chamar o método correspondente.

Se a classe instanciada for uma subclasse de FibonacciSequence, o método a ser chamado é GetFibonacciSequence(). Por outro lado, se a classe instanciada for uma subclasse de StringInverter, o método a ser chamado é GetStringInverted().

Por fim, basta executar o programa no Visual Studio para testar as classes.</p>
 

 


