using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface ITopicService
    {
        public Task<TopicViewModel> GetTopic(string topic);
        public Task<List<TopicViewModel>> GetAll();
        public void Add(TopicDTO dto);
        public void AddWord(string topic, string word);
        public void DeleteWord(string topic, string word);
    }
}
