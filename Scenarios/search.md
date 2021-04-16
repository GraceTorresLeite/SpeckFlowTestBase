# 4- Funcionalidade: Busca(EXERCÍCIO 3)

## Estória: 
 Dado que sou cliente do gênero feminino em busca de um novo look,
ao passar o mouse  na      modalidade “Women” visualizo algumas categorias 
e suas promoções 


### Critérios de Aceite 1: Busca digitada - com sucesso por itens catalogados por categoria

**Dado**     que  desejo comprar uma blusa,  digito no campo de pesquisa  a palavra “blouses”

**Quando**   clicar na lupa

**Então**    serei direcionada a uma tela que me fornecerá uma lista de ítens disponíveis


### Critérios de Aceite 2: Busca digitada - com sucesso por ofertas

**Dado**     que  desejo aproveitar liquidações anunciadas,  digito no campo de pesquisa  a palavra “offers”

**Quando**   clicar na lupa

**Então**    serei direcionada a uma tela que me fornecerá uma lista de ítens com e sem descontos em destaque


### Critérios de Aceite 3: Busca digitada -  sem  as expectativas atendidas pelo usuário

**Dado**     que  estimulada a chamada de promoção de sapatos  digito no campo de pesquisa  a palavra “shoes”

**Quando**   clicar na lupa

**Então**    serei direcionada a uma tela com vários ítens exceto sapatos


### Critérios de Aceite 4: Busca digitada - não localizada

**Dado**     que sou uma cliente em busca de acessórios femininos

**Quando**   quando digitar “accessory” 

**Então**    uma mensagem de texto será exibida “No results were found for your search "accessory"”


### Critérios de Aceite 5: Busca digitada - esperando uma lista de opções com sucesso

**Dado**     que sou uma cliente em busca de sugestões de seleção como ponto de partida na navegação em busca de um ítem que me chame a atenção

**Quando**   quando digitar no campo de busca as inicias com o mínimo de 3 letras de um item catalogado

**Então**    uma lista de opções serão disponibilizadas para seleção no campo de busca


### Critérios de Aceite 6: Busca digitada - sem sucesso por descontos

**Dado**     que  ao consultar uma categoria visualizei a possibilidade de visualizar os descontos através do título “Price Drop”

**Quando**   clicar na lupa com a palavra “Price Drop” digitada

**Então**    surgirá uma mensagem na tela “No results were found for your search “”Price Drop”
