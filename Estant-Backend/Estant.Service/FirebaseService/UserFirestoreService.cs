using Estant.Material.Model.DTOModel;
using Estant.Service.Interface;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.FirebaseService
{
    public class UserFirestoreService : IUserService
    {
        FirestroreRepository<User> repository;

        public UserFirestoreService(IVocabularyService vocabularyService)
        {
            repository = new FirestroreRepository<User>("User");
        }
        public async Task<User> Get(string uid)
        {
            return await repository.Get(uid);
        }
        public void Add(string uid)
        {
            repository.Set(new User()
            {
                id = uid,
            });
        }
    }
}
