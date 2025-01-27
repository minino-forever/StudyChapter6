using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //сотрудник
    internal abstract class Employee
    {
        //имя сотрудника
        private string _empName;
        //индификатр сотрудника
        private int _empId;
        //возраст сотрудника
        private int _empAge;
        //текущая зп сотрудника
        private float _currPay;
        //номер социального страхования
        private string _empSSN;
        //тип оплаты труда
        private EmployeePayTypeEnum _payType;

        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public double GetBenefitCost() => EmpBenefits.ComputerPayDeduction();
        public BenefitPackage Benefits
        {
            get{ return EmpBenefits; }
            set{ EmpBenefits = value; }
        }

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name Length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get { return _empId; }
            set {_empId = value; }
        }

        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public string SSN
        {
            get { return _empSSN; }
            set { _empSSN = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public Employee(){}
        public Employee(string name, int id, float pay, string ssn) :this(name, 0, id, pay, ssn, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SSN = ssn;
            PayType = payType;
        }

        //премиальные бонусы сотруднику
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }

        //служебная информация сотрудника
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"SSN: {SSN}");
        }
    }
}
