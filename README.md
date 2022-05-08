# Decorator Pattern
 
Decorator, wrapper, é um padrão de projeto de software que permite adicionar um comportamento a um objeto já existente em tempo de execução, ou seja, agrega dinamicamente responsabilidades adicionais a um objeto. Decorators oferecem uma alternativa flexível ao uso de herança para estender uma funcionalidade, com isso adiciona-se uma responsabilidade ao objeto e não à classe.
***
## Problema
O Decorator surgiu da necessidade de adicionar um comportamento, funcionalidade ou estado extra a um objeto em tempo de execução, por exemplo quando Herança não é concebível por ser um caso que geraria um número muito alto de sub-classes. Suponha que existe um objeto Pizza, ela pode ter comportamentos diferentes dependendo dos seus ingredientes. Imagine criar agora uma sub classe para cada combinação possível de seus ingredientes, o número de classes aumenta exponencialmente para cada opção a mais que você tiver. É aí que entra o Decorator. São diversos os exemplos nos sistemas que usamos no dia-a-dia, cuja função é adicionar responsabilidades e comportamentos a um objeto dinamicamente e que sem esse padrão, a capacidade de personalizar e editar classes tornaria-se inviável.
***
## Solução
O Decorator resolve problemas que a herança gera em determinados momentos, em que classes precisam ser muito especificadas e detalhadas de diferentes formas, gerando excessivas subclasses. Nestes momentos o decorator é aplicado. Diminuindo drasticamente as classes geradas e permitindo flexibilidade aos atributos e métodos. Isto acontece, pois, a solução por de trás deste padrão é encapsular o objeto original dentro de uma interface. Ambos os objetos decorator e o objeto principal herdam essa interface. A interface utiliza composição recursiva para permitir que os ilimitados números de “decorações” possam ser adicionados ao objeto principal. Esta solução traz ao projeto uma flexibilidade maior, em que pode se adicionar ou remover responsabilidades sem que seja necessário editar o código-fonte, alta coesão e fraco acoplamento.
***
## Aplicabilidade
Acrescentar ou remover responsabilidades a objetos individuais dinamicamente, de forma transparente
Evitar a explosão de subclasses para prover todas as combinações de responsabilidades
Acrescentar responsabilidades a um objeto dinamicamente
Prover alternativa flexível ao uso de subclasses para se estender a funcionalidade de uma classe
Pode-se utilizar Decorator quando a herança seria uma boa alternativa mas a definição da classe está escondida ou não disponível para herança
pode usar um ou mais decoradores para englobar um objeto
Os padrões Decorador e Composite podem ser visto como similares, uma vez que ambos usam o princípio de recursividade. O decorator pode ser visto como uma versão simplificada do padrão Composite, porém o Decorator apenas adiciona responsabilidades adicionais e não é usado para agregar objetos
***
## Exemplo

Um exemplo simples e prático da aplicação do Decorator seria colocar ingredientes em uma pizza, como bacon e cebola. Um modo de se contornar esse problema seria criar uma interface e criar pizzas que implementam essa interface (Figura 1), porém isso faria com que tivéssemos muitas classes que implementam essa interface, para apenas dois ingredientes teríamos que criar 4 classes (Pizza sem extras, pizzas com bacon, pizzas com bacon cebola e pizzas com bacon e cebola) tornando essa uma alternativa ruim. Além disso, essa alternativa viola os princípios de baixa acoplação e alta coesão.

(Figura 1)![image](https://user-images.githubusercontent.com/47763472/167274205-c0d87f34-0340-472c-9731-4238a5ae342f.png)
                                                                  

 
Outra solução seria utilizar o Design Pattern Decorator, com esse Design Pattern será possível contornar esse problema de uma forma simples e que não viole nenhum princípio de design. Além disso, ele possibilita que sejam adicionados N ingredientes durante o tempo de execução. A aplicação do padrão Decorator seria a seguinte (Figura 2).

(Figura 2)![image](https://user-images.githubusercontent.com/47763472/167274197-02706d0e-4fcd-4ff1-a17d-d783405d51e4.png)

 




 ###### Referências
 <ul>
   <li>https://djesusnet.medium.com/design-patterns-c-aprendendo-decorator-pattern-em-net-core-5e62c4a30814<br> </li>
   <li>https://medium.com/xp-inc/desing-patterns-parte-11-decorator-ba348f44142f<br></li>
   <li>Decorator in Java - Source Making. <br></li>
   <li>Decorators in PHP - Source Making.<br></li>
   <li>The decorator pattern in PHP.<br></li>
  </ul>




