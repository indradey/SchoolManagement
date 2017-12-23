using System;
namespace SchoolManagementSystem.DAL.Contract
{
    interface IUnitofWork:IDisposable
    {
        void Dispose();
    }
}
