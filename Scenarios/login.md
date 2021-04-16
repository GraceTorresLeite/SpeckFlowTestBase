# 2- Funcionalidade: Login(EXERCÍCIO 1)

## Estória: 
Eu enquanto um cliente que já tem cadastro no site quero acessar a página Sign In 
e conseguir realizar login durante minhas compras na loja virtual.



### Critério de Aceite 1:  Login com sucesso

**Dado**        que desejo finalizar minha compra após incluir um item ao meu carrinho 

**Quando**      clicar em “Proceed to checkout”

**Então**       serei direcionado ao “Sign in”

**Quando**      digitar o e-mail e password válidos

**E**           clicar no botão “Sign in”

**Então**       meu nome completo será sinalizado na parte superior direita do navbar e o fluxo da transação é liberado para as demais etapas.



### Critério de Aceite 2: Login com erro – senha errada

**Dado**           que digito um email válido, sinalizado pela cor verde

**Quando**      digito uma senha diferente ao armazenado em sistema para este e-mail

**E**                  ao clicar em “Sign in”

**Então**         a mesma página ao carregar mostra em tela um box com a mensagem em vermelho “here is 1 error 1.Authentication failed.”



### Critério de Aceite 3: Login com erro – senha diverge ao requerido

**Dado**      que digito um email válido, sinalizado pela cor verde

**Quando**    digito uma senha com menos de cinco dígitos

**E**         ao clicar em “Sign in”

**Então**     a mesma página ao carregar mostra em tela um box com a mensagem em vermelho “here is 1 error     1.Invalid password.”



### Critério de Aceite 4: Login com erro – e-mail diverge ao requerido

**Dado**       que estou finalizando minha compra

**Quando**     logar informando um e-mail diferente do padrão juntamente com a senha válida

**Então**      meu campo ficará na cor vermelha e uma mensagem em tela será exibida em vermelho“There is 1 error    1. Invalid email address”



### Critério de Aceite 5: Login com erro – e-mail não cadastrado

**Dado**        que estou finalizando minha compra

**Quando**      logar informando um e-mail válido porém diferente ao cadastrado em sistema juntamente com a senha

**E**           clicar no botão “Sign in ”

**Então**       uma mensagem em tela será exibida em vermelho“There is 1 error    1. Authentication failed”
