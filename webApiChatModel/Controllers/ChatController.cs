using Microsoft.AspNetCore.Mvc;
using webApiChatModel.Models;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChatModel>>>  BuscarTodasConversas()
        {
           List<ChatModel> listChat = await _chatService.BuscarTodasConversas();

            return Ok(listChat);
        }

        [HttpGet("buscarPorId/{id}")]
        public async Task<ActionResult<ChatModel>> BuscarConversaPorId(int id)
        {
            ChatModel chat = await _chatService.BuscarConversaPorId(id);

            return Ok(chat);
        }

        [HttpGet("buscarPorPergunta/{pergunta}")]
        public async Task<ActionResult<ChatModel>> BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel chat = await _chatService.BuscarConversaPorPergunta(pergunta);

            return Ok(chat);
        }
    }
}
