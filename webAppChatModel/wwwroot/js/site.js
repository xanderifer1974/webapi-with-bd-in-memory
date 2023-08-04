let divMensagem = document.querySelector(".chat-body")
let buttonEnviar = document.querySelector("#send-message");
let buttonUpload = document.getElementById('file-input');
let inputMensage = document.querySelector("input#mensagem");
let arquivoSelecionado;

function saudacao() {
    var hora = new Date().getHours();
    var saudacao;

    if (hora >= 5 && hora < 12) {
        saudacao = "Bom dia";
    } else if (hora >= 12 && hora < 18) {
        saudacao = "Boa tarde";
    } else {
        saudacao = "Boa noite";
    }

    return saudacao;
}

let comprimentos = saudacao();


function criarMensagem(mensagem) {
    const divPrincipal = document.createElement('div');

    const divMensagem = document.createElement('div');
    divMensagem.classList.add('message', 'incoming');

    const divConteudoMensagem = document.createElement('div');
    divConteudoMensagem.classList.add('message-content');

    const paragrafo = document.createElement('p');
    paragrafo.innerHTML = mensagem;

    divConteudoMensagem.appendChild(paragrafo);
    divMensagem.appendChild(divConteudoMensagem);

    const divTimestamp = document.createElement('div');
    divTimestamp.style.display = 'block';
    divTimestamp.style.textAlign = 'right';

    const spanTimestamp = document.createElement('span');
    spanTimestamp.classList.add('message-timestamp');
    spanTimestamp.textContent = criarHoraAtual();

    divTimestamp.appendChild(spanTimestamp);

    divPrincipal.appendChild(divMensagem);
    divPrincipal.appendChild(divTimestamp);

    return divPrincipal;
}

function criarHoraAtual() {

    let date = new Date();

    let hours = date.getHours();
    let minutes = date.getMinutes();
    let amOrPm = hours >= 12 ? 'PM' : 'AM';
    hours = hours % 12;
    hours = hours ? hours : 12;
    minutes = minutes < 10 ? '0' + minutes : minutes;

    return currentTime = hours + ':' + minutes + ' ' + amOrPm;

}

function ResponderMensagem(texto) {
    let horario = criarHoraAtual();
    var divMensagem = document.createElement('div');
    divMensagem.id = 'mensagem-e-horario-resposta';

    var divOutgoing = document.createElement('div');
    divOutgoing.classList.add('message', 'outgoing');

    var divContent = document.createElement('div');
    divContent.classList.add('message-content');

    var paragrafo = document.createElement('p');
    paragrafo.innerHTML = texto;

    divContent.appendChild(paragrafo);
    divOutgoing.appendChild(divContent);
    divMensagem.appendChild(divOutgoing);

    var divHorario = document.createElement('div');
    divHorario.style.display = 'block';
    divHorario.style.textAlign = 'left';

    var spanHorario = document.createElement('span');
    spanHorario.classList.add('message-timestamp');
    spanHorario.textContent = horario;

    divHorario.appendChild(spanHorario);
    divMensagem.appendChild(divHorario);

    return divMensagem;
}

MensagemInicialChat();

function handleFileUpload(event) {


    const file = event.target.files[0];   
    arquivoSelecionado = `Arquivo selecionado: ${file.name}`
    document.querySelector("input#mensagem").value = arquivoSelecionado; 
    event.target.value = '';
}

buttonUpload.addEventListener('click', function (e) {
    const input = document.createElement('input');
    input.type = 'file';
    input.click();
    input.addEventListener("change", handleFileUpload);
});


buttonEnviar.addEventListener("click", async (e) => {
    e.preventDefault();
    pergunta = document.querySelector("input#mensagem").value; 
    Chat(pergunta); 
});

function MensagemInicialChat() {
    let mensagemInicial = `<p>${comprimentos}, sou a Funny. Sua atendente virtual da FunTV.
                               Favor informar seu CPF.</p>`
    divMensagem.appendChild(ResponderMensagem(mensagemInicial));
}

inputMensage.addEventListener('input', function () {
    if (inputMensage.value.trim() != '') {
        buttonEnviar.disabled = false;       
    } else {
        buttonEnviar.disabled = true;       
    }
})

function Chat(pergunta) {
    if (pergunta.trim() !== '') {
        divMensagem.appendChild(criarMensagem(pergunta));
        let url = `https://localhost:7173/api/Chat/buscarPorPergunta/${encodeURIComponent(pergunta)}`
        fetch(url)
            .then(response => response.json())
            .then(data => {
                let resposta = data.resposta;
                divMensagem.appendChild(ResponderMensagem(resposta));
                divMensagem.scrollTop = divMensagem.scrollHeight;
            })
            .catch(error => {
                divMensagem.appendChild(ResponderMensagem("Não temos resposta para a sua pergunta."));
                divMensagem.scrollTop = divMensagem.scrollHeight;
            });
        document.querySelector("input#mensagem").value = "";
    }
}

