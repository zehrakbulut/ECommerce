﻿using ECommerce.DtoLayer.DiscountDtos;
using ECommerce.DtoLayer.MessageDtos;

namespace ECommerce.WebUI.Services.MessageServices
{
    public class MessageService : IMessageService
    {

        private readonly HttpClient _httpClient;

        public MessageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("http://localhost:5000/services/Message/UserMessage/GetMessageInbox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultInboxMessageDto>>();
            return values;
        }

        public async Task<List<ResultSendboxMessageDto>> GetSendboxMessageAsync(string id)
        {

            var responseMessage = await _httpClient.GetAsync("http://localhost:5000/services/Message/UserMessage/GetMessageSendbox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSendboxMessageDto>>();
            return values;
        }
    }
}
// http://localhost:7098/api/UserMessage/GetMessageSendbox?id=a
