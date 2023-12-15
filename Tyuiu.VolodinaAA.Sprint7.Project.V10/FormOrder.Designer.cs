
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRight_VAA = new System.Windows.Forms.Panel();
            this.buttonNext_VAA = new System.Windows.Forms.Button();
            this.panelFill_VAA = new System.Windows.Forms.Panel();
            this.labelTowns_VAA = new System.Windows.Forms.Label();
            this.comboBoxTowns_VAA = new System.Windows.Forms.ComboBox();
            this.checkBoxCondition_VAA = new System.Windows.Forms.CheckBox();
            this.labelPhoneNumber_VAA = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber_VAA = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPatronymic_VAA = new System.Windows.Forms.TextBox();
            this.labelPatronymic_VAA = new System.Windows.Forms.Label();
            this.labelName_VAA = new System.Windows.Forms.Label();
            this.textBoxName_VAA = new System.Windows.Forms.TextBox();
            this.labelSurname_VAA = new System.Windows.Forms.Label();
            this.textBoxSurname_VAA = new System.Windows.Forms.TextBox();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.textBoxExplanation_VAA = new System.Windows.Forms.TextBox();
            this.openFileDialogNext_VAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCSV_VAA = new System.Windows.Forms.SaveFileDialog();
            this.buttonGoBack_VAA = new System.Windows.Forms.Button();
            this.textBoxPostIndex_VAA = new System.Windows.Forms.TextBox();
            this.labelPostIndex_VAA = new System.Windows.Forms.Label();
            this.textBoxAdress_VAA = new System.Windows.Forms.TextBox();
            this.labelAdress_VAA = new System.Windows.Forms.Label();
            this.panelRight_VAA.SuspendLayout();
            this.panelFill_VAA.SuspendLayout();
            this.panelTop_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight_VAA
            // 
            this.panelRight_VAA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRight_VAA.Controls.Add(this.buttonGoBack_VAA);
            this.panelRight_VAA.Controls.Add(this.buttonNext_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_VAA.Location = new System.Drawing.Point(933, 0);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(200, 549);
            this.panelRight_VAA.TabIndex = 0;
            // 
            // buttonNext_VAA
            // 
            this.buttonNext_VAA.Enabled = false;
            this.buttonNext_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext_VAA.Location = new System.Drawing.Point(15, 477);
            this.buttonNext_VAA.Name = "buttonNext_VAA";
            this.buttonNext_VAA.Size = new System.Drawing.Size(171, 53);
            this.buttonNext_VAA.TabIndex = 0;
            this.buttonNext_VAA.Text = "Продолжить";
            this.buttonNext_VAA.UseVisualStyleBackColor = true;
            this.buttonNext_VAA.Click += new System.EventHandler(this.buttonNext_VAA_Click);
            // 
            // panelFill_VAA
            // 
            this.panelFill_VAA.BackColor = System.Drawing.SystemColors.Window;
            this.panelFill_VAA.Controls.Add(this.labelAdress_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxAdress_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPostIndex_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxPostIndex_VAA);
            this.panelFill_VAA.Controls.Add(this.labelTowns_VAA);
            this.panelFill_VAA.Controls.Add(this.comboBoxTowns_VAA);
            this.panelFill_VAA.Controls.Add(this.checkBoxCondition_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPhoneNumber_VAA);
            this.panelFill_VAA.Controls.Add(this.maskedTextBoxPhoneNumber_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxPatronymic_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPatronymic_VAA);
            this.panelFill_VAA.Controls.Add(this.labelName_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxName_VAA);
            this.panelFill_VAA.Controls.Add(this.labelSurname_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxSurname_VAA);
            this.panelFill_VAA.Controls.Add(this.panelTop_VAA);
            this.panelFill_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_VAA.Name = "panelFill_VAA";
            this.panelFill_VAA.Size = new System.Drawing.Size(933, 549);
            this.panelFill_VAA.TabIndex = 1;
            // 
            // labelTowns_VAA
            // 
            this.labelTowns_VAA.AutoSize = true;
            this.labelTowns_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTowns_VAA.Location = new System.Drawing.Point(559, 122);
            this.labelTowns_VAA.Name = "labelTowns_VAA";
            this.labelTowns_VAA.Size = new System.Drawing.Size(140, 72);
            this.labelTowns_VAA.TabIndex = 11;
            this.labelTowns_VAA.Text = "Выберите \r\nнаселённый\r\nпункт:";
            // 
            // comboBoxTowns_VAA
            // 
            this.comboBoxTowns_VAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTowns_VAA.FormattingEnabled = true;
            this.comboBoxTowns_VAA.Items.AddRange(new object[] {
            "Абакан",
            "Азов",
            "Александров",
            "Алексин",
            "Альметьевск",
            "Анапа",
            "Ангарск",
            "Анжеро-Судженск",
            "Апатиты",
            "Арзамас",
            "Армавир",
            "Арсеньев",
            "Артем",
            "Архангельск",
            "Асбест",
            "Астрахань",
            "Ачинск",
            "Балаково",
            "Балахна",
            "Балашиха",
            "Балашов",
            "Барнаул",
            "Батайск",
            "Белгород",
            "Белебей",
            "Белово",
            "Белогорск (Амурская область)",
            "Белорецк",
            "Белореченск",
            "Бердск",
            "Березники",
            "Березовский (Свердловская область)",
            "Бийск",
            "Биробиджан",
            "Благовещенск (Амурская область)",
            "Бор",
            "Борисоглебск",
            "Боровичи",
            "Братск",
            "Брянск",
            "Бугульма",
            "Буденновск",
            "Бузулук",
            "Буйнакск",
            "Великие Луки",
            "Великий Новгород",
            "Верхняя Пышма",
            "Видное",
            "Владивосток",
            "Владикавказ",
            "Владимир",
            "Волгоград",
            "Волгодонск",
            "Волжск",
            "Волжский",
            "Вологда",
            "Вольск",
            "Воркута",
            "Воронеж",
            "Воскресенск",
            "Воткинск",
            "Всеволожск",
            "Выборг",
            "Выкса",
            "Вязьма",
            "Гатчина",
            "Геленджик",
            "Георгиевск",
            "Глазов",
            "Горно-Алтайск",
            "Грозный",
            "Губкин",
            "Гудермес",
            "Гуково",
            "Гусь-Хрустальный",
            "Дербент",
            "Дзержинск",
            "Димитровград",
            "Дмитров",
            "Долгопрудный",
            "Домодедово",
            "Донской",
            "Дубна",
            "Евпатория",
            "Егорьевск",
            "Ейск",
            "Екатеринбург",
            "Елабуга",
            "Елец",
            "Ессентуки",
            "Железногорск (Красноярский край)",
            "Железногорск (Курская область)",
            "Жигулевск",
            "Жуковский",
            "Заречный",
            "Зеленогорск",
            "Зеленодольск",
            "Златоуст",
            "Иваново",
            "Ивантеевка",
            "Ижевск",
            "Избербаш",
            "Иркутск",
            "Искитим",
            "Ишим",
            "Ишимбай",
            "Йошкар-Ола",
            "Казань",
            "Калининград",
            "Калуга",
            "Каменск-Уральский",
            "Каменск-Шахтинский",
            "Камышин",
            "Канск",
            "Каспийск",
            "Кемерово",
            "Керчь",
            "Кинешма",
            "Кириши",
            "Киров (Кировская область)",
            "Кирово-Чепецк",
            "Киселевск",
            "Кисловодск",
            "Клин",
            "Клинцы",
            "Ковров",
            "Когалым",
            "Коломна",
            "Комсомольск-на-Амуре",
            "Копейск",
            "Королев",
            "Кострома",
            "Котлас",
            "Красногорск",
            "Краснодар",
            "Краснокаменск",
            "Краснокамск",
            "Краснотурьинск",
            "Красноярск",
            "Кропоткин",
            "Крымск",
            "Кстово",
            "Кузнецк",
            "Кумертау",
            "Кунгур",
            "Курган",
            "Курск",
            "Кызыл",
            "Лабинск",
            "Лениногорск",
            "Ленинск-Кузнецкий",
            "Лесосибирск",
            "Липецк",
            "Лиски",
            "Лобня",
            "Лысьва",
            "Лыткарино",
            "Люберцы",
            "Магадан",
            "Магнитогорск",
            "Майкоп",
            "Махачкала",
            "Междуреченск",
            "Мелеуз",
            "Миасс",
            "Минеральные Воды",
            "Минусинск",
            "Михайловка",
            "Михайловск (Ставропольский край)",
            "Мичуринск",
            "Москва",
            "Мурманск",
            "Муром",
            "Мытищи",
            "Набережные Челны",
            "Назарово",
            "Назрань",
            "Нальчик",
            "Наро-Фоминск",
            "Находка",
            "Невинномысск",
            "Нерюнгри",
            "Нефтекамск",
            "Нефтеюганск",
            "Нижневартовск",
            "Нижнекамск",
            "Нижний Новгород",
            "Нижний Тагил",
            "Новоалтайск",
            "Новокузнецк",
            "Новокуйбышевск",
            "Новомосковск",
            "Новороссийск",
            "Новосибирск",
            "Новотроицк",
            "Новоуральск",
            "Новочебоксарск",
            "Новочеркасск",
            "Новошахтинск",
            "Новый Уренгой",
            "Ногинск",
            "Норильск",
            "Ноябрьск",
            "Нягань",
            "Обнинск",
            "Одинцово",
            "Озерск (Челябинская область)",
            "Октябрьский",
            "Омск",
            "Орел",
            "Оренбург",
            "Орехово-Зуево",
            "Орск",
            "Павлово",
            "Павловский Посад",
            "Пенза",
            "Первоуральск",
            "Пермь",
            "Петрозаводск",
            "Петропавловск-Камчатский",
            "Подольск",
            "Полевской",
            "Прокопьевск",
            "Прохладный",
            "Псков",
            "Пушкино",
            "Пятигорск",
            "Раменское",
            "Ревда",
            "Реутов",
            "Ржев",
            "Рославль",
            "Россошь",
            "Ростов-на-Дону",
            "Рубцовск",
            "Рыбинск",
            "Рязань",
            "Салават",
            "Сальск",
            "Самара",
            "Санкт-Петербург",
            "Саранск",
            "Сарапул",
            "Саратов",
            "Саров",
            "Свободный",
            "Севастополь",
            "Северодвинск",
            "Северск",
            "Сергиев Посад",
            "Серов",
            "Серпухов",
            "Сертолово",
            "Сибай",
            "Симферополь",
            "Славянск-на-Кубани",
            "Смоленск",
            "Соликамск",
            "Солнечногорск",
            "Сосновый Бор",
            "Сочи",
            "Ставрополь",
            "Старый Оскол",
            "Стерлитамак",
            "Ступино",
            "Сургут",
            "Сызрань",
            "Сыктывкар",
            "Таганрог",
            "Тамбов",
            "Тверь",
            "Тимашевск",
            "Тихвин",
            "Тихорецк",
            "Тобольск",
            "Тольятти",
            "Томск",
            "Троицк",
            "Туапсе",
            "Туймазы",
            "Тула",
            "Тюмень",
            "Узловая",
            "Улан-Удэ",
            "Ульяновск",
            "Урус-Мартан",
            "Усолье-Сибирское",
            "Уссурийск",
            "Усть-Илимск",
            "Уфа",
            "Ухта",
            "Феодосия",
            "Фрязино",
            "Хабаровск",
            "Ханты-Мансийск",
            "Хасавюрт",
            "Химки",
            "Чайковский",
            "Чапаевск",
            "Чебоксары",
            "Челябинск",
            "Черемхово",
            "Череповец",
            "Черкесск",
            "Черногорск",
            "Чехов",
            "Чистополь",
            "Чита",
            "Шадринск",
            "Шали",
            "Шахты",
            "Шуя",
            "Щекино",
            "Щелково",
            "Электросталь",
            "Элиста",
            "Энгельс",
            "Южно-Сахалинск",
            "Юрга",
            "Якутск",
            "Ялта",
            "Ярославль"});
            this.comboBoxTowns_VAA.Location = new System.Drawing.Point(563, 197);
            this.comboBoxTowns_VAA.Name = "comboBoxTowns_VAA";
            this.comboBoxTowns_VAA.Size = new System.Drawing.Size(190, 24);
            this.comboBoxTowns_VAA.TabIndex = 10;
            // 
            // checkBoxCondition_VAA
            // 
            this.checkBoxCondition_VAA.AutoSize = true;
            this.checkBoxCondition_VAA.Font = new System.Drawing.Font("TT Travels Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCondition_VAA.Location = new System.Drawing.Point(66, 453);
            this.checkBoxCondition_VAA.Name = "checkBoxCondition_VAA";
            this.checkBoxCondition_VAA.Size = new System.Drawing.Size(431, 21);
            this.checkBoxCondition_VAA.TabIndex = 9;
            this.checkBoxCondition_VAA.Text = "Вы согласны на обработку ваших персональных данных\r\n";
            this.checkBoxCondition_VAA.UseVisualStyleBackColor = true;
            this.checkBoxCondition_VAA.CheckedChanged += new System.EventHandler(this.checkBoxCondition_VAA_CheckedChanged);
            // 
            // labelPhoneNumber_VAA
            // 
            this.labelPhoneNumber_VAA.AutoSize = true;
            this.labelPhoneNumber_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber_VAA.Location = new System.Drawing.Point(62, 335);
            this.labelPhoneNumber_VAA.Name = "labelPhoneNumber_VAA";
            this.labelPhoneNumber_VAA.Size = new System.Drawing.Size(185, 48);
            this.labelPhoneNumber_VAA.TabIndex = 8;
            this.labelPhoneNumber_VAA.Text = "Введите ваш \r\nномер телефона:";
            // 
            // maskedTextBoxPhoneNumber_VAA
            // 
            this.maskedTextBoxPhoneNumber_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhoneNumber_VAA.Location = new System.Drawing.Point(66, 386);
            this.maskedTextBoxPhoneNumber_VAA.Mask = "+7(999) 000-0000";
            this.maskedTextBoxPhoneNumber_VAA.Name = "maskedTextBoxPhoneNumber_VAA";
            this.maskedTextBoxPhoneNumber_VAA.Size = new System.Drawing.Size(197, 31);
            this.maskedTextBoxPhoneNumber_VAA.TabIndex = 7;
            // 
            // textBoxPatronymic_VAA
            // 
            this.textBoxPatronymic_VAA.Location = new System.Drawing.Point(66, 291);
            this.textBoxPatronymic_VAA.Name = "textBoxPatronymic_VAA";
            this.textBoxPatronymic_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxPatronymic_VAA.TabIndex = 6;
            // 
            // labelPatronymic_VAA
            // 
            this.labelPatronymic_VAA.AutoSize = true;
            this.labelPatronymic_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic_VAA.Location = new System.Drawing.Point(66, 264);
            this.labelPatronymic_VAA.Name = "labelPatronymic_VAA";
            this.labelPatronymic_VAA.Size = new System.Drawing.Size(412, 24);
            this.labelPatronymic_VAA.TabIndex = 5;
            this.labelPatronymic_VAA.Text = "Введите ваше отчество (при наличии):\r\n";
            // 
            // labelName_VAA
            // 
            this.labelName_VAA.AutoSize = true;
            this.labelName_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_VAA.Location = new System.Drawing.Point(66, 195);
            this.labelName_VAA.Name = "labelName_VAA";
            this.labelName_VAA.Size = new System.Drawing.Size(284, 24);
            this.labelName_VAA.TabIndex = 4;
            this.labelName_VAA.Text = "Введите ваше полное имя:\r\n";
            // 
            // textBoxName_VAA
            // 
            this.textBoxName_VAA.Location = new System.Drawing.Point(66, 222);
            this.textBoxName_VAA.Name = "textBoxName_VAA";
            this.textBoxName_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxName_VAA.TabIndex = 3;
            // 
            // labelSurname_VAA
            // 
            this.labelSurname_VAA.AutoSize = true;
            this.labelSurname_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname_VAA.Location = new System.Drawing.Point(62, 122);
            this.labelSurname_VAA.Name = "labelSurname_VAA";
            this.labelSurname_VAA.Size = new System.Drawing.Size(258, 24);
            this.labelSurname_VAA.TabIndex = 2;
            this.labelSurname_VAA.Text = "Введите вашу фамилию:";
            // 
            // textBoxSurname_VAA
            // 
            this.textBoxSurname_VAA.Location = new System.Drawing.Point(66, 149);
            this.textBoxSurname_VAA.Name = "textBoxSurname_VAA";
            this.textBoxSurname_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxSurname_VAA.TabIndex = 1;
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.textBoxExplanation_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(933, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // textBoxExplanation_VAA
            // 
            this.textBoxExplanation_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExplanation_VAA.Font = new System.Drawing.Font("TT Travels Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExplanation_VAA.Location = new System.Drawing.Point(0, 0);
            this.textBoxExplanation_VAA.Multiline = true;
            this.textBoxExplanation_VAA.Name = "textBoxExplanation_VAA";
            this.textBoxExplanation_VAA.ReadOnly = true;
            this.textBoxExplanation_VAA.Size = new System.Drawing.Size(933, 100);
            this.textBoxExplanation_VAA.TabIndex = 0;
            this.textBoxExplanation_VAA.Text = "Для продолжения совершения заказа заполните следующие поля:";
            // 
            // openFileDialogNext_VAA
            // 
            this.openFileDialogNext_VAA.FileName = "openFileDialog1";
            // 
            // buttonGoBack_VAA
            // 
            this.buttonGoBack_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoBack_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoBack_VAA.Location = new System.Drawing.Point(29, 12);
            this.buttonGoBack_VAA.Name = "buttonGoBack_VAA";
            this.buttonGoBack_VAA.Size = new System.Drawing.Size(148, 64);
            this.buttonGoBack_VAA.TabIndex = 1;
            this.buttonGoBack_VAA.Text = "Вернуться на предыдущую страницу";
            this.buttonGoBack_VAA.UseVisualStyleBackColor = true;
            this.buttonGoBack_VAA.Click += new System.EventHandler(this.buttonGoBack_VAA_Click);
            // 
            // textBoxPostIndex_VAA
            // 
            this.textBoxPostIndex_VAA.Location = new System.Drawing.Point(564, 291);
            this.textBoxPostIndex_VAA.Name = "textBoxPostIndex_VAA";
            this.textBoxPostIndex_VAA.Size = new System.Drawing.Size(190, 22);
            this.textBoxPostIndex_VAA.TabIndex = 12;
            // 
            // labelPostIndex_VAA
            // 
            this.labelPostIndex_VAA.AutoSize = true;
            this.labelPostIndex_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostIndex_VAA.Location = new System.Drawing.Point(563, 240);
            this.labelPostIndex_VAA.Name = "labelPostIndex_VAA";
            this.labelPostIndex_VAA.Size = new System.Drawing.Size(191, 48);
            this.labelPostIndex_VAA.TabIndex = 13;
            this.labelPostIndex_VAA.Text = "Введите ваш \r\nпочтовый индекс:\r\n";
            // 
            // textBoxAdress_VAA
            // 
            this.textBoxAdress_VAA.Location = new System.Drawing.Point(335, 386);
            this.textBoxAdress_VAA.Multiline = true;
            this.textBoxAdress_VAA.Name = "textBoxAdress_VAA";
            this.textBoxAdress_VAA.Size = new System.Drawing.Size(419, 31);
            this.textBoxAdress_VAA.TabIndex = 14;
            // 
            // labelAdress_VAA
            // 
            this.labelAdress_VAA.AutoSize = true;
            this.labelAdress_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress_VAA.Location = new System.Drawing.Point(331, 335);
            this.labelAdress_VAA.Name = "labelAdress_VAA";
            this.labelAdress_VAA.Size = new System.Drawing.Size(212, 48);
            this.labelAdress_VAA.TabIndex = 16;
            this.labelAdress_VAA.Text = "Введите ваш \r\nадрес проживания:";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 549);
            this.Controls.Add(this.panelFill_VAA);
            this.Controls.Add(this.panelRight_VAA);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОКНО РЕГИСТРАЦИИ";
            this.panelRight_VAA.ResumeLayout(false);
            this.panelFill_VAA.ResumeLayout(false);
            this.panelFill_VAA.PerformLayout();
            this.panelTop_VAA.ResumeLayout(false);
            this.panelTop_VAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight_VAA;
        private System.Windows.Forms.Button buttonNext_VAA;
        private System.Windows.Forms.Panel panelFill_VAA;
        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.TextBox textBoxExplanation_VAA;
        private System.Windows.Forms.Label labelSurname_VAA;
        private System.Windows.Forms.TextBox textBoxSurname_VAA;
        private System.Windows.Forms.TextBox textBoxPatronymic_VAA;
        private System.Windows.Forms.Label labelPatronymic_VAA;
        private System.Windows.Forms.Label labelName_VAA;
        private System.Windows.Forms.TextBox textBoxName_VAA;
        private System.Windows.Forms.Label labelPhoneNumber_VAA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber_VAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogNext_VAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV_VAA;
        private System.Windows.Forms.CheckBox checkBoxCondition_VAA;
        private System.Windows.Forms.Label labelTowns_VAA;
        private System.Windows.Forms.ComboBox comboBoxTowns_VAA;
        private System.Windows.Forms.Button buttonGoBack_VAA;
        private System.Windows.Forms.Label labelPostIndex_VAA;
        private System.Windows.Forms.TextBox textBoxPostIndex_VAA;
        private System.Windows.Forms.Label labelAdress_VAA;
        private System.Windows.Forms.TextBox textBoxAdress_VAA;
    }
}