# BH-Simulator

<h1>Descrição do jogo</h1> 
O jogo BH Simulator se passa na região metropolitana de Belo Horizonte e tem as suas fases inspiradas em locais conhecidos da cidade. A gameplay do jogo se baseia na aventura do nosso protagonista, "Capivarildo", que após cair na Lagoa da Pampulha acaba se teletransportando para um lugar distante. Seu objetivo é retornar ao seu ponto inicial, a Pampulha.

<h1>Proposta do jogo</h1> 
A proposta de "BH Simulator" é a criação de um jogo de plataforma acessível e que traga lugares conhecidos da Grande BH como forma de causar identificação por parte do público em relação aos desafios vividos pelo protagonista. O jogo é idealizado, inicialmente, para conter 8 fases que contem e ilustrem as aventuras do personagem no seu trajeto de volta ao lar.

<h1>Acessibilidade</h1> 
O jogo é idealizado para ser acessível para pessoas com deficiência visual e deficiência auditiva. A proposta de acessibilidade do projeto é fazer com que o jogo sofra o mínimo de alterações para os diferentes públicos e que as ferramentas de acessibilidade sejam, na verdade, complementares umas às outras, buscando a proporcionar o experiência mais próxima para todos os usuários.

<h2>Ferramentas de acessibilidade</h2>
<li>Opção de alto contraste</li>
<li>Instruções sonoras e visuais das ações do jogo</li>
<li>Tutorial explicativo sobre as mecânicas do jogo</li>

<h1>Mecânica</h1> 
"BH Simulator" é um jogo de plataforma que seguirá mecânicas ligeiramente diferentes a cada fase e terá duas categorias de fases: fases com embate direto com o vilão e fases de coleta de itens/embate indireto com o vilão.
<br><br>
<li>As fases indicarão as teclas correspondentes às ações que serão realizadas pelos jogadores</li>
<li>Presença de respostas sonoras que indicarão a posição dos obstáculos/itens/momento da movimentação/ação corretamente executada/ação incorretamente executada</li>
<li>Presença de respostas visuais que indicarão a posição dos obstáculos/itens/momento da movimentação/ação corretamente executada/ação incorretamente executada</li>
<br>
<h2>Exemplo</h2>
<img width="396" alt="image" src="https://user-images.githubusercontent.com/102993778/179447887-0c335afe-f1aa-48df-8ad3-49a63fe4299e.png">
<img width="580" alt="image" src="https://user-images.githubusercontent.com/102993778/179448390-011de8a8-d8e5-40a0-a2d4-5a4c19edd459.png">
O obstáculo terá sua posição indicada visualmente e através dos sons emitidos. O obstáculo arremessado na parte de cima emitirá um som X enquanto o obstáculo arremessado na parte de baixo emitirá um som Y. Essa funcionalidade utilizando sons também terá um indicativo de tempo para a realização da ação. Ou seja, a tecla indicada de acordo com o som só deve ser clicada após o intervalo de tempo indicado na fase. EX: se o tempo definido for de 1s, a tecla deverá ser pressionada 1s após o som ser emitido, conforme mostra a imagem.


<h1>Menu</h1>
A tela de Menu apresenta 6 botões clicáveis sendo eles:

Iniciar: O botão iniciar é responsável por começar a gameplay.
Tutorial: O tutorial apresenta instruções básicas para ajudar na jogabilidade e terá uma demonstração em vídeo de como as fases funcionam.
Créditos: Apresenta os créditos.
Sair: Responsável por encerrar a aplicação do jogo.
Volume: Regula a funcionalidade da saída do som (com volume ou sem volume).
Contraste: Traz ao jogo a funcionalidade de alto contraste.

Os botões ficam de cores diferentes quando pressionados, facilitando na diferenciação de cada um.

Menu:
<br>
<img src="https://user-images.githubusercontent.com/87147025/172286785-ff84cd25-38d3-44c0-a7f1-e599001fe95d.png" width="50%" height="50%">

Botão iniciar:
<br>
<img src="https://user-images.githubusercontent.com/87147025/172287596-8d3a4c26-22f3-4e45-9c42-16f396e02c7a.png" width="50%" height="50%">


Botão tutorial:
<br>
<img src="https://user-images.githubusercontent.com/87147025/172287899-06b244fa-ba7c-444f-8698-91b0b0f8474a.png" width="50%" height="50%">


Botão créditos:
<br>
<img src="https://user-images.githubusercontent.com/87147025/172288284-ef1f9f3f-52c1-418f-8169-b9fbc9506094.png" width="50%" height="50%">


Botão sair:
<br>
<img src="https://user-images.githubusercontent.com/87147025/172288426-1adc940f-401d-483a-855c-a2905825a843.png" width="50%" height="50%">


<h1>Fases</h1>
O jogo, como dito anteriormente, foi idealizado em 8 pequenas fases que narram a trajetória de Capivarildo de volta ao seu lar. Cada fase se passa em um diferente cenário.<br>
<br>
As fases são organizadas nas seguintes categorias:
<br>
<li>Ambientação inicial</li>
Acontecimentos que precedem a fase
<li>Objetivo</li>
Propósito da fase
<li>Vilão/Coleta</li>
ESpecificação do antagonista da fase ou da coleta de itens
<li>Quantidade de vidas</li>
Vidas disponíveis na fase
<li>Obstáculos/Itens</li>
Especificação dos obstáculos ou itens a serem coletados
<li>Cenário</li>
Ambiente da fase
<li>Conclusão</li>
Acontecimentos que procedem a fase

<h2>Fase 1 - Estação Cidade Industrial</h2>
<li>Ambientação inicial</li>
O personagem, após ser teletransportado, é abordado por um assaltante.
<li>Objetivo</li>
Após ser abordado, o objetivo do nosso personagem, nessa fase inicial, é desviar das facas atiradas pelo vilão. Para progredir no jogo, ele deve desviar de, no mínimo, 17 facas das 20 arremessadas.
<li>Vilão/Coleta</li>
Ladrão da estação
<li>Quantidade de vidas</li>
4 vidas
<li>Obstáculos/Itens</li>
20 facas
<li>Cenário</li>
Estação Cidade Industrial
<li>Conclusão</li>
Ao vencer o vilão, nosso personagem se dirige para a próxima fase: em busca de comida. Caso não consiga desviar das 17 facas e perca, a fase é reiniciada.
<br>
Esquematização da fase no item "Mecânica"
<br>


<h2>Fase 2 - "Lanchonete Contagense"</h2>
<li>Ambientação inicial</li>
Quando consegue escapar das facas do ladrão, o personagem caminha até a lanchonete mais próxima na cidade de Contagem para poder se alimentar.
<li>Objetivo</li>
O personagem deve coletar no mínimo 13 paẽs de queijo dos 15 que estiverem caindo para finalizar a fase.
<li>Vilão/Coleta</li>
O personagem deve coletar 13 paẽs de queijo
<li>Quantidade de vidas</li>
3 vidas
<li>Obstáculos/Itens</li>
15 pães de queijo
<li>Cenário</li>
Lanchonete Contagense
<li>Conclusão</li>
Depos de se alimentar, Capivarildo pede ajuda a um morador da cidade para voltar até a Pampulha. Caso não consiga recolher a quantidade mínima, a fase é reiniciada.
<br>
Esquematização da fase:
<br>
<img width="250" alt="image" src="https://user-images.githubusercontent.com/102993778/179449718-da54446a-c7dc-4ce0-8db2-da4dbed7ad1b.png">



<br>

<h2>Fase 3 - Estação Eldorado</h2>
<li>Ambientação inicial</li>
Capivarildo caminha até a estação eldorado para assim pegar o ônibus que o levará de volta para casa: o move 518R. 
<li>Objetivo</li>
É necessária a realização da coleta de de 60 cartões ótimos dentre os que estarão espalhados no cenário.
<li>Vilão/Coleta</li>
O vilão será o ônibus que está vindo em sua direção e a coleta será dos cartões para o embarque.
<li>Quantidade de vidas</li>
1 vida
<li>Obstáculos/Itens</li>
O obstáculo da fase é o 518R correndo atrás do personagem enquanto ele recolhe os cartões.
<li>Cenário</li>
Estação Eldorado
<li>Conclusão</li>
Caso consiga juntar pelo menos 60 cartões, Capivarildo entrará no ônibus e seguirá viagem. Se não conseguir, o ônibus atropela o personagem e a fase é reiniciada.
<br>
Esquematização da fase:
<br>
<img width="238" alt="image" src="https://user-images.githubusercontent.com/102993778/179449736-de97714e-007b-4cf5-87a7-1435a41b9464.png">


<br>

<h2>Fase 4 - Bairro da Lagoinha</h2>
Em desenvolvimento

<h2>Fase 5 - Oiapoque</h2>
Em desenvolvimento

<h2>Fase 6 - Parque Municipal</h2>
Em desenvolvimento

<h2>Fase 7 - Ratanabá</h2>
Em desenvolvimento

<h2>Fase 8 - Pirâmides de Ratanabá</h2>
Em desenvolvimento
