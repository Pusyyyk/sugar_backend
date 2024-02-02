using Sugar_backend.Application.Models.Users;

namespace Sugar_backend.Application.Abstractions.Repositories;

public interface IUserRepository
{
    User? AddUser(
        string login, 
        string password,  
        string name, 
        DateTime birthday, 
        Gender gender, 
        int weight, 
        int carbohydrateRatio, 
        int breadUnit
        );
    
    void DeleteUserById(long id);
    
    User? FindUserByLogin(string login);
    
    bool ChangeName(string login, string newName); 
    bool ChangeBirthday(string login, DateTime newBirthday);
    bool ChangeGender(string login, Gender newGender);
    bool ChangeWeight(string login, int newWeight);
    bool ChangeCarbohydrateRatio(string login, int newCarbohydrateRatio);
    bool ChangeBreadUnit(string login, int newBreadUnit);
}