using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Persistence;
using ProjetoTematico.Dto;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace ProjetoTematico.Service;

public class UserService : BaseService<User, UserDto>
{
    public UserService(MyGardenCareContext context) : base(context)
    {
        
    }

    public List<UserDto> GetAllToUpdate()
    {
        try
        {
            List<int> principals = _context.AccessProfiles.AsNoTracking()
                .Where(x => x.PermissaoLevel != Permissao.Admin && x.PermissaoLevel != Permissao.ManagerChief)
                .Select(x => x.Id)
                .ToList();

            List<User> entries = _context.Set<User>().AsNoTracking()
                .Where(x => x.AccessProfileId != null && !principals.Contains(x.AccessProfileId.Value))
                .ToList();

            return entries.MapToList<User, UserDto>();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool isManagers(int profileID)
    {
        var status = _context.AccessProfiles.FirstOrDefault(x => x.Id == profileID);

        if (status == null) return false;

        return status.PermissaoLevel is Permissao.Admin || status.PermissaoLevel is Permissao.ManagerChief || status.PermissaoLevel is Permissao.Manager;
    }

    public bool isSysAdmin(int profileID)
    {
        var status = _context.AccessProfiles.FirstOrDefault(x => x.Id == profileID);

        if (status == null) return false;

        return status.PermissaoLevel is Permissao.Admin;
    }

    public bool isManagerChief(int profileID)
    {
        var status = _context.AccessProfiles.FirstOrDefault(x => x.Id == profileID);

        if (status == null) return false;

        return status.PermissaoLevel is Permissao.ManagerChief;
    }

    public bool isManager(int profileID)
    {
        var status = _context.AccessProfiles.FirstOrDefault(x => x.Id == profileID);

        if (status == null) return false;

        return status.PermissaoLevel is Permissao.Manager;
    }

    public bool isJardineiro(int profileID)
    {
        var status = _context.AccessProfiles.FirstOrDefault(x => x.Id == profileID);

        if (status == null) return false;

        return status.PermissaoLevel is Permissao.Jardineiro;
    }
}
