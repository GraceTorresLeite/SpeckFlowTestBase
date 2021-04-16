# 5- Funcionalidade: Categoria - filtros e layout(EXERCÍCIO 4)

## Estória: 

*Persona Usuário:*

Eu como um usuário da loja virtual 

ao acessar a categoria “Women”

quero ter a habilidade de realizar filtros 

e alterar o modo como os produtos são apresentados.
___

*Persona site da loja:*

**Como**    uma  loja virtual ao acessar a categoria “Women”

**Quero**   apresentar um layout contendo um catálogo com os ítens disponíveis e filtros pelos cards individualmente.

**Para**    que o usuário tenha a habilidade de visualizar o produto que temos em estoque com a habilidade de filtrar pelos boxes disponíveis no card.



### Critério de Aceite 1: Layout com  prévia de ítens de sessão - com sucesso

**Dado**      que como um cliente quero ter a visibilidade geral das opções oferecidas pela loja

**Quando**    passar o mouse pela aba “Women” 

**Então**     um layout com anúncios promocionais serão exibidos , assim como uma lista de categorias e subcategorias serão habilitadas para visualização e navegação.


### Critério de Aceite 2: Layout com prévia de ítens de sessão - navegando por categoria com sucesso

**Dado**      que como um cliente quero acesso às opções de roupas superiores

**Quando**    passar o mouse pela opção “Tops”

**Então**     devo ser direcionado a página contendo catálogo com as subcategorias, filtros e formas de visibilidade


### Critério de Aceite 3: Layout com prévia de ítens de sessão - navegando por anúncios promocionais sem sucesso

**Dado**     que como um cliente quero acesso rápido as promoções anunciadas 

**Quando**   clicar sobre a promoção 

**Então**    não terei resposta


### Critério de Aceite 4: Sessão “Women”  - com sucesso

**Dado**         que tenho interesse na visibilidade detalhada de todos os ítens da sessão feminina 

**Quando**    selecionado a aba “Women”

**Então**        carregará um catálogo contendo as categorias, subcategorias e filtros com escolhas disponíveis, faixa de preço, assim como a quantidade do estoque oferecido pela loja virtual.


### Critério de Aceite 5:  Filtro Categoria >subcategoria  - com sucesso

**Dado**      que tenho interesse em uma blusa

**Quando**    selecionado a (categoria) ” Tops > Blouses” (subcategoria)

**Então**     arregará um catálogo contendo filtros com escolhas disponíveis, faixa de preço, assim como a quantidade do estoque.


### Critério de Aceite 6: Filtro Categoria >subcategoria  - filtros com  sucesso

**Dado**      que tenho interesse em uma blusa na cor branca

**Quando**    selecionado a categoria Tops > Blouses 

**E**         uma lista de produtos com a foto e suas descrições forem exibidas no corpo da página ao lado direito do catálogo com filtros

**Quando**    clicar no box contendo a cor white logo abaixo do preço no ítem escolhido

**Então**     terei a visibilidade do ítem na cor filtrada (branca)



### Critério de Aceite 7:  Filtro Categoria >subcategoria  - filtros sem  sucesso

**Dado**    que tenho interesse em uma blusa na cor branca

Quando**    selecionado a categoria Tops > Blouses 

**E**       uma lista de produtos com a foto e suas descrições forem exibidas no corpo da página ao lado direito do catálogo com filtros

**Quando**  clicar no box contendo a cor white listado no catálogo através da sessão “Color”

**Então**   a página apresentará o comportamento - de carregamento sem término de execução.



### Critério de Aceite 8:  Filtro Categoria >subcategoria  - filtros sem  sucesso

**Dado**      que tenho interesse em uma blusa na cor branca

**Quando**   selecionado a categoria Tops > Blouses 

**E**        uma lista de produtos com a foto e suas descrições forem exibidas no corpo da página ao lado direito do catálogo com filtros

**Quando**   clicar no box contendo a cor white listado no catálogo através da sessão “Color”

**Então**    a página apresentará o comportamento - de carregamento sem término de execução.


### Critério de Aceite 9: Sessão “Women”  -  selecionando modo de visualização com sucesso

**Dado**      que tenho interesse em alterar a visibilidade detalhada de todos os ítens da sessão feminina 

**Quando**    selecionar na VIEW  a opção “List”

**Então**     a visibilidade atual de grid será alterada para uma lista sequencial.


### Critério de Aceite 10: Sessão “Women”  -  lista de ordenação visível  com  sucesso

**Dado**      que tenho interesse em alterar a ordenação dos itens da sessão feminina 

**Quando**    selecionar “Sort by”

**Então**     uma lista de opções para ordenação serão visualizadas 


### Critério de Aceite 11: Sessão “Women”  -  seleção lista de ordenação sem sucesso

**Dado**      que tenho interesse em alterar a ordenação dos itens da sessão feminina 

**Quando**    selecionar “Sort by”

**E**         clicar em uma das opções apresentadas

**Então**     a página apresentará o comportamento - de carregamento sem término de execução.

