using System;

namespace SalesControl.BackEnd.Components {

    public enum Position {
        kAttendant,
        kManager
    }

    [Serializable]
    public class Employee : Person {
        private User user;
        private Position position;

        public Employee(uint id, string name, string phone, string social_number, Position position) : base(id, name, phone, social_number) {
            this.position = position;
        }
        public bool IsManager() {
            return position == Position.kManager;
        }

        public bool HasUser() {
            return user != null;
        }

        public void RemoveUser() {
            if (user is null) {
                throw new InvalidOperationException("У сотрудника нет пользователя.");
            }
            user = null;
        }

        public User GetUser() {
            return user;
        }

        public void SetUser(string login, string password) {
            if (user != null) {
                throw new InvalidOperationException("У сотрудника уже есть пользователь.");
            }
            user = new User(login, password);
        }

        public Position GetPosition() {
            return position;
        }

        public void SetPosition(Position position) {
            this.position = position;
        }

        public override string ToString() {
            string employee_str = string.Format(
                "{0} / {1}",
                base.ToString(),
                PositionToString(position)
            );

            if (user != null) {
                employee_str += " (" + user.GetLogin() + ")";
            }

            return employee_str;
        }

        public static string PositionToString(Position position) {
            switch (position) {
                case Position.kAttendant:
                    return "Сопровождающий";
                case Position.kManager:
                    return "Менеджер";
                default:
                    throw new ArgumentException("Недопустимая позиция.");
            }
        }

        public static Position StringToPosition(string position_str) {
            if (position_str.Equals("Сопровождающий")) {
                return Position.kAttendant;
            }
            else if (position_str.Equals("Менеджер")) {
                return Position.kManager;
            }
            else {
                throw new ArgumentException("Недопустимая позиция. " + position_str);
            }
        }

    }
}
