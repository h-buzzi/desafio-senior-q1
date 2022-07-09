## WebAPI em .NET 6 para Desafio de Programação Senior Mega
Esta aplicação, desenvolvida em .NET 6, é uma API que faz chamada para uma API de filmes, onde esta API desenvolvida irá retornar uma json com a total de entradas e uma lista de anos, em ordem crescente, com a respectiva quantidade de filmes encontrados naquele ano.

# Importante

Abaixo você encontra algumas intruções de como estar com sua máquina do mesmo jeito que a minha, garantindo que você terá o mesmo ambiente para execução que o meu, e no qual o software foi desenvolvido.

## Instalação

A primeira etapa é baixar o Visual Studio Community 2022, disponível em [https://visualstudio.microsoft.com/pt-br/vs/community/](https://visualstudio.microsoft.com/pt-br/vs/community/), e instalá-lo.

Durante a instalação, marque a opção 'ASP.NET e Desenvolvimento Web', e mantenha as caixas que já vieram marcadas no opcional. De resto, podes seguir com a instalação padrão do Visual Studio Community 2022.

Uma vez com ele instalado, abra este repositório no VSCommunity, e selecione no topo a aba 'Ferramentas', e na lista que abre posicione seu mouse sobre a opção 'Gerenciador de Pacotes do Nuget', irá expandir uma outra lista pequena, então clique sobre a opção 'Gerenciar Pacotes do NuGet para a Solução...'. Uma nova janela irá aparecer na sua tela, nela, clique perto do canto esquerdo superior na opção 'Instalado', e certifique-se que os seguintes pacotes estão instalados 'coverlet.collector', 'Microsoft.Net.Test.Sdk', 'Newtonsoft.Json', 'Swashbucle.AspNetCore', 'xunit' e 'xunit.runner.visualstudio'. Caso algum não esteja, clique em 'Procurar' ao lado de 'Instalado' e instale os pacotes.

## Executando
Após instalar o VSCommunity 2022, execute o mesmo e abra este repositório aqui. Uma vez com este repositório aberto, selecione no topo, perto da aba janela, sobre o botão de 'play' verde com o nome FilmesSeniorAPI para executar em modo debug, ou, o botão de 'play' verde não-preenchido para rodar FilmesSeniorApi mas sem estar em modo debug (sem depuração). Com isto, espera-se que abra um prompt de comando informando o endereço que API está rodando localmente.

Para utilizar a API, utilize o endereço provido no cmd em seu navegador de escolha, e após a porta, coloque /filmes/$Nome que você deseja pesquisar. No fim, é esperado que tenha um endereço no mesmo formato que 'http//localhost:7131/filmes/Waterworld', onde obviamente, 'Waterworld' seria substituido pela sua string de busca.

## Aviso
Caso esteja tendo algum problema com o fato de você já estar usando o endereço 'localhost:7131' ou 'localhost:5131', é possível alterar o endreço em launchSettings.json dentro de properties. Ali terá os campos 'applicationUrl', onde você poderá prover um novo endereço.
