using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace LiMengLing1995.Model
{
    //MengLingUser
    [Serializable]
    [Table("MengLingUser")]
    public partial class MengLingUser : Entity
    {
        #region colomn
        public MengLingUser() : base("MengLingUser") { }
        private string _Id;
        private string _Account;
        private string _Pwd;
        private string _Name;
        private string _Email;
        private int _Sex;
        private int _UserSate;
        private string _Mobile;
        private DateTime _RegisterTime;
        private DateTime _UpdateTiem;

        /// <summary>
        /// Guid
        /// </summary>
        public string Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
            }
        }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account
        {
            get { return _Account; }
            set
            {
                this.OnPropertyValueChange(_.Account, _Account, value);
                this._Account = value;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get { return _Pwd; }
            set
            {
                this.OnPropertyValueChange(_.Pwd, _Pwd, value);
                this._Pwd = value;
            }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set
            {
                this.OnPropertyValueChange(_.Email, _Email, value);
                this._Email = value;
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange(_.Sex, _Sex, value);
                this._Sex = value;
            }
        }
        /// <summary>
        /// 用户状态
        /// </summary>
        public int UserSate
        {
            get { return _UserSate; }
            set
            {
                this.OnPropertyValueChange(_.UserSate, _UserSate, value);
                this._UserSate = value;
            }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile
        {
            get { return _Mobile; }
            set
            {
                this.OnPropertyValueChange(_.Mobile, _Mobile, value);
                this._Mobile = value;
            }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime
        {
            get { return _RegisterTime; }
            set
            {
                this.OnPropertyValueChange(_.RegisterTime, _RegisterTime, value);
                this._RegisterTime = value;
            }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTiem
        {
            get { return _UpdateTiem; }
            set
            {
                this.OnPropertyValueChange(_.UpdateTiem, _UpdateTiem, value);
                this._UpdateTiem = value;
            }
        }
        #endregion
        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return null;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                                                       _.Id,
                                                };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                                _.Id,
                                _.Account,
                                _.Pwd,
                                _.Name,
                                _.Email,
                                _.Sex,
                                _.UserSate,
                                _.Mobile,
                                _.RegisterTime,
                                _.UpdateTiem,
                             };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                                this._Id,
                                this._Account,
                                this._Pwd,
                                this._Name,
                                this._Email,
                                this._Sex,
                                this._UserSate,
                                this._Mobile,
                                this._RegisterTime,
                                this._UpdateTiem,
                            };
        }
        /*
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._Id = DataUtils.ConvertValue<string>(reader["Id"]);
            this._Account = DataUtils.ConvertValue<string>(reader["Account"]);
            this._Pwd = DataUtils.ConvertValue<string>(reader["Pwd"]);
            this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
            this._Email = DataUtils.ConvertValue<string>(reader["Email"]);
            this._Sex = DataUtils.ConvertValue<int>(reader["Sex"]);
            this._UserSate = DataUtils.ConvertValue<int>(reader["UserSate"]);
            this._Mobile = DataUtils.ConvertValue<string>(reader["Mobile"]);
            this._RegisterTime = DataUtils.ConvertValue<DateTime>(reader["RegisterTime"]);
            this._UpdateTiem = DataUtils.ConvertValue<DateTime>(reader["UpdateTiem"]);

        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._Id = DataUtils.ConvertValue<string>(row["Id"]);
            this._Account = DataUtils.ConvertValue<string>(row["Account"]);
            this._Pwd = DataUtils.ConvertValue<string>(row["Pwd"]);
            this._Name = DataUtils.ConvertValue<string>(row["Name"]);
            this._Email = DataUtils.ConvertValue<string>(row["Email"]);
            this._Sex = DataUtils.ConvertValue<int>(row["Sex"]);
            this._UserSate = DataUtils.ConvertValue<int>(row["UserSate"]);
            this._Mobile = DataUtils.ConvertValue<string>(row["Mobile"]);
            this._RegisterTime = DataUtils.ConvertValue<DateTime>(row["RegisterTime"]);
            this._UpdateTiem = DataUtils.ConvertValue<DateTime>(row["UpdateTiem"]);

        }
        */
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "MengLingUser");
            public readonly static Field Id = new Field("Id", "MengLingUser", "Id");
            public readonly static Field Account = new Field("Account", "MengLingUser", "Account");
            public readonly static Field Pwd = new Field("Pwd", "MengLingUser", "Pwd");
            public readonly static Field Name = new Field("Name", "MengLingUser", "Name");
            public readonly static Field Email = new Field("Email", "MengLingUser", "Email");
            public readonly static Field Sex = new Field("Sex", "MengLingUser", "Sex");
            public readonly static Field UserSate = new Field("UserSate", "MengLingUser", "UserSate");
            public readonly static Field Mobile = new Field("Mobile", "MengLingUser", "Mobile");
            public readonly static Field RegisterTime = new Field("RegisterTime", "MengLingUser", "RegisterTime");
            public readonly static Field UpdateTiem = new Field("UpdateTiem", "MengLingUser", "UpdateTiem");
        }
        #endregion
    }
}

