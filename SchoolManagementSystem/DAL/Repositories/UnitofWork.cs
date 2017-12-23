using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.DAL.Contract;
using SchoolManagementSystem.Models.Entities;

namespace SchoolManagementSystem.DAL.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private SchooManagementContext context = new SchooManagementContext();

        private GenericRepository<Student> _studentRePository;
        private GenericRepository<Teacher> _teacherRepository;
        private GenericRepository<UserInfo> _userInfoRepository;
        private GenericRepository<Subject> _subjectRepository;
        private GenericRepository<Parent> _parentRepository;
        private GenericRepository<Parent_Student_Link> _parentStudentLinkRepository;

        public GenericRepository<Student> StudentRePository
        {
            get
            {
                return this._studentRePository ?? new GenericRepository<Student>(context);
            }
        }

        public GenericRepository<Teacher> TeacherRepository
        {
            get
            {
                return this._teacherRepository ?? new GenericRepository<Teacher>(context);
            }
        }

        public GenericRepository<UserInfo> UserInfoRepository
        {
            get
            {
                return this._userInfoRepository ?? new GenericRepository<UserInfo>(context);
            }
        }

        public GenericRepository<Subject> SubjectRepository
        {
            get
            {
                return this._subjectRepository ?? new GenericRepository<Subject>(context);
            }
        }

        public GenericRepository<Parent> ParentRepository
        {
            get
            {
                return this._parentRepository ?? new GenericRepository<Parent>(context);
            }
        }
        public GenericRepository<Parent_Student_Link> ParentStudentLinkRepository
        {
            get
            {
                return this._parentStudentLinkRepository ?? new GenericRepository<Parent_Student_Link>(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
