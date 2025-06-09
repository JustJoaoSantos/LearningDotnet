Console.WriteLine("\n--------Arrays------------");
int[] arrayConst = new int[4]; //Declarando um array e o tamanho dele
int[] array = new int[] {42, 71, 22, 30}; //Declarando um array o tamanho pela quantidade de elementos adicinados durante a declaracao.

arrayConst[0] = 12; //Modificando o valor no index especificado, erro se index nao valido.
arrayConst[1] = 22;
arrayConst[2] = 32;
arrayConst[3] = 42;

foreach(int item in arrayConst) {
	Console.WriteLine(item); //Percorre a partir do primeiro (index 0)
}

for(int i = 0; i < array.Length; i++) {
	Console.WriteLine(array[i]); //percorrendo um array com Length().
}

Array.Resize(ref array, 8); //redimenciona o array 'array' para 8

Array.Copy(arrayConst, array, 4); //copia os items do arrayConst para array ate o index 4.

Console.WriteLine("\n--------Lista/List------------");
List<int> lista = new List<int>(); //Declarando uma lista 

lista.Add(12); //Adiciona um item ao final lista
lista.Add(45);
lista.Add(22);
lista.Add(30);

foreach(int item in lista) {
	Console.WriteLine(item); //Percorre a partir do primeiro
}

lista.Remove(45); //Remove o valor especificado


Console.WriteLine("\n--------Fila/Queue------------");
Queue<int> fila = new Queue<int>();  //Declarando uma fila

fila.Enqueue(21); //adicionando um elemento a fila
fila.Enqueue(30);
fila.Enqueue(42);
fila.Enqueue(12);

foreach(int item in fila) {
	Console.WriteLine(item); //Percorre a partir do primeiro elemento
}

fila.Dequeue(); //Remove o primeiro elemento da lista

Console.WriteLine("\n--------Pila/Stacks------------");
Stack<int> pilha = new Stack<int>(); //Declarando uma pilha

pilha.Push(22);
pilha.Push(32);
pilha.Push(52);
pilha.Push(12);

foreach(int item in pilha) {
	Console.WriteLine(item); //Percorre a partir do ultimo elemento
}

pilha.Pop(); //Remove o ultimo elemento da pilha

Console.WriteLine("\n--------Dicionarios------------");
Dictionary<string, string> estados = new Dictionary<string, string>(); //Declarando um Dicionario com chave 'string' e valor 'string'.

estados.Add("BA", "Bahia"); //Adicionando uma chave:valor para o dicionario.
estados.Add("SP", "Sao Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("AL", "Alagoas");

foreach(var item in estados) {  //var reconhece que Data Type e: KeyValuePair<string, string> item
	Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine(estados["SP"]); //retorna o valor com chave 'SP'.

estados["SP"] = "Sao Paulooooo"; //Altera o valor pela chave. NT* Chaves nao podem ser alteradas.

estados.Remove("BA"); //Remove elementos pela chave.

estados.ContainsKey("BA"); //Verifica se a Chave 'BA' ja existe.