namespace choices
{
    public partial class Form1 : Form
    {
        // �༶����
        string[] questions = {
        "1. ����������봦���������ʲô��",
        "2. ���������ǲ���ϵͳ��",
        "3. �����ƵĻ�����λ����������",
        "4. C# �����������͵ı�����ԣ�",
        "5. �������������ݿ����ϵͳ��"
    };

        string[,] options = {
        { "CPU", "GPU", "RAM" },
        { "Windows", "Photoshop", "Word" },
        { "0 �� 1", "1 �� 2", "A �� B" },
        { "������", "������", "�ű���" },
        { "MySQL", "HTML", "Excel" }
    };
        int[] answers = { 0, 0, 0, 1, 0 };  // ��ȷѡ����±�
        int[] selected = { -1, -1, -1, -1, -1 }; // ���ڴ洢�û�ѡ��Ĵ�
        int currentQuestionIndex = 0;
        bool isProgrammaticChange = false;

        string ResultText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowQuestion(int index)
        {
            lblQuestion.Text = questions[index];
            radA.Text = options[index, 0];
            radB.Text = options[index, 1];
            radC.Text = options[index, 2];

            // ȡ��ѡ��
            isProgrammaticChange = true;
            radA.Checked = selected[index] == 0;
            radB.Checked = selected[index] == 1;
            radC.Checked = selected[index] == 2;
            isProgrammaticChange = false;

            UpdateNavigationButtons(); // �� ���������°�ť��ɫ
        }

        // ��������������λ�ø��°�ť״̬����ɫ
        private void UpdateNavigationButtons()
        {
            // ��һ��ʱ���á���һ�⡱��ť���ɫ
            if (currentQuestionIndex == 0)
            {
                btnLast.Enabled = false;
                btnLast.BackColor = Color.LightGray;
            }
            else
            {
                btnLast.Enabled = true;
                btnLast.BackColor = SystemColors.Control;
            }

            // ���һ��ʱ���á���һ�⡱��ť���ɫ
            if (currentQuestionIndex == questions.Length - 1)
            {
                btnNext.Enabled = false;
                btnNext.BackColor = Color.LightGray;
            }
            else
            {
                btnNext.Enabled = true;
                btnNext.BackColor = SystemColors.Control;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                if (selected[i] == -1)
                {
                    MessageBox.Show($"��{i + 1}�⻹δ����");
                    ShowQuestion(i); // ��ʾδ�������Ŀ
                    return;
                }
            }

            int cnt = 0;
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] == answers[i])
                {
                    cnt++;
                }
            }

            if (cnt == questions.Length)
            {
                MessageBox.Show("��ϲ�㣬ȫ������ˣ�");
                return;
            }

            //���ûȫ��
            ResultText = $"������ {cnt} ����Ŀ��\n";
            for (int i = 0; i < answers.Length; i++)
            {
                if (selected[i] != answers[i])
                {
                    ResultText += $"��{i + 1}��ش������ȷ���ǣ�{options[i, answers[i]]}\n";
                }

            }
            MessageBox.Show(ResultText, "���", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResultText = ""; // ��ս���ı�
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowQuestion(currentQuestionIndex);

            radA.Tag = 0;
            radB.Tag = 1;
            radC.Tag = 2;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex == questions.Length -1) 
            {
                return;
            }
            currentQuestionIndex += 1;
            ShowQuestion(currentQuestionIndex);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex == 0)
            {
                return;
            }
            currentQuestionIndex -= 1;
            ShowQuestion(currentQuestionIndex);
        }


        // ��ѡ��ťѡ��״̬�仯�¼�������
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // ����ǳ������õ�ѡ��״̬���򲻴���
            if (isProgrammaticChange) return;

            // �� sender ת��Ϊ RadioButton ����
            var radio = sender as RadioButton;

            // �����ǰ��ѡ��ť��ѡ��
            if (radio != null && radio.Checked)
            {
                // ��¼��ǰ��Ŀ���û�ѡ��
                selected[currentQuestionIndex] = (int)radio.Tag;
            }
        }


    }
}
