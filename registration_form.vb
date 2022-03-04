Imports System.Data.SqlClient
Public Class registration_form
    Dim PersianCalendar As New System.Globalization.PersianCalendar()




    Dim connect_S As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\students.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_T As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\teachers.mdf;Integrated Security=True;Connect Timeout=30")

    Dim connect_m_i_farvardin As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_farvardin.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_ordibehesht As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_ordibehesht.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_khordad As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_khordad.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_tir As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_tir.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_mordad As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_mordad.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_shahrivar As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_shahrivar.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_mehr As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_mehr.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_aban As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_aban.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_azar As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_azar.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_dey As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_dey.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_bahman As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_bahman.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_i_esfand As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\mony_incoming_esfand.mdf;Integrated Security=True;Connect Timeout=30")

    Dim connect_m_o_farvardin As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_farvardin.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_ordibehesht As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_ordibehesht.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_khordad As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_khordad.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_tir As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_tir.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_mordad As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_mordad.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_shahrivar As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_shahrivar.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_mehr As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_mehr.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_aban As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_aban.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_azar As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_azar.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_dey As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_dey.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_bahman As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_bahman.mdf;Integrated Security=True;Connect Timeout=30")
    Dim connect_m_o_esfand As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Application.StartupPath & "\money_Output_esfand.mdf;Integrated Security=True;Connect Timeout=30")

    Dim DataTable As New DataTable

    Dim save_ID_number As Integer








    Dim count_row As Integer

    Dim Male As Integer
    Dim Female As Integer

    Dim language_English As Integer
    Dim language_Turkish As Integer
    Dim language_Spanish As Integer
    Dim language_Italian As Integer
    Dim language_French As Integer
    Dim language_Arabic As Integer
    Dim language_Chinese As Integer
    Dim language_Japanese As Integer
    Dim language_Korean As Integer

    Dim language_count_all As Integer
    Dim gender_count_all As Integer
    Dim birthday_count_all As String
    Dim date_of_registration_count_all As String

    Dim Part_level_test_choose_answer As String
    Dim Part_level_test_count_correct_answer As Integer
    Dim Part_level_test_go_next_question As String

    Dim Part_charts_color_students As Integer
    Dim Part_charts_color_teachers As Integer
    Dim Part_charts_color_all As Integer

    Dim Part_charts_type_students As Integer
    Dim Part_charts_type_teachers As Integer
    Dim Part_charts_type_all As Integer

    Dim birthday_count_chart_student As Integer
    Dim date_of_registration_count_chart_student As Integer
    Dim birthday_count_chart_teachers As Integer
    Dim date_of_registration_count_chart_teachers As Integer
    Dim birthday_count_chart_all As Integer
    Dim date_of_registration_count_chart_all As Integer

    Dim Accounting_edit As Integer
    Dim Accounting_choose_item As Integer
    Dim get_p_data As Integer







    Dim PictureBox_Accounting As New PictureBox
    Dim PictureBox_Accounting_back As New PictureBox
    Dim PictureBox_Accounting_money_Incoming As New PictureBox
    Dim PictureBox_Accounting_money_Output As New PictureBox
    Dim PictureBox_Accounting_money_Turnover As New PictureBox

    Dim Label_Accounting_farvardin As New Label
    Dim Label_Accounting_ordibehesht As New Label
    Dim Label_Accounting_khordad As New Label
    Dim Label_Accounting_tir As New Label
    Dim Label_Accounting_mordad As New Label
    Dim Label_Accounting_shahrivar As New Label
    Dim Label_Accounting_mehr As New Label
    Dim Label_Accounting_aban As New Label
    Dim Label_Accounting_azar As New Label
    Dim Label_Accounting_dey As New Label
    Dim Label_Accounting_bahman As New Label
    Dim Label_Accounting_esfand As New Label

    Dim PictureBox_Accounting_add As New PictureBox
    Dim PictureBox_Accounting_edit As New PictureBox
    Dim PictureBox_Accounting_delete As New PictureBox

    Dim Label_Accounting_money_add_1 As New Label
    Dim Label_Accounting_money_add_2 As New Label
    Dim Label_Accounting_money_add_3 As New Label
    Dim Label_Accounting_money_add_4 As New Label
    Dim Label_Accounting_money_add_5 As New Label
    Dim Label_Accounting_money_add_6 As New Label
    Dim Label_Accounting_money_add_7 As New Label

    Dim TextBox_Accounting_money_add_1 As New TextBox
    Dim TextBox_Accounting_money_add_2 As New TextBox
    Dim TextBox_Accounting_money_add_3 As New TextBox

    Dim PictureBox_Accounting_add_done As New PictureBox

    Dim PictureBox_Accounting_edit_choose As New PictureBox
    Dim PictureBox_Accounting_delete_choose As New PictureBox

    Dim PictureBox_Accounting_count_amount As New PictureBox
    Dim PictureBox_Accounting_count_amount_number As New PictureBox
    Dim Label_Accounting_count_amount As New Label
    Dim Label_Accounting_count_amount_number As New Label
   













    Dim ToolTip_main As New ToolTip
    Dim Timer_lock_app As New Timer

    Dim Button_students As New Button
    Dim Button_teachers As New Button
    Dim Button_delete_s As New Button
    Dim Button_edit_s As New Button
    Dim Button_add_s As New Button
    Dim Button_add_t As New Button
    Dim Button_edit_t As New Button
    Dim Button_delete_t As New Button

    Dim PictureBox_back_to_home_from_students_and_teachers_list As New PictureBox
    Dim PictureBox_complete_registration_students As New PictureBox
    Dim PictureBox_complete_registration_teachers As New PictureBox
    Dim PictureBox_back_to_home_from_registration_students As New PictureBox
    Dim PictureBox_back_to_home_from_registration_teachers As New PictureBox
    Dim PictureBox_more_students As New PictureBox
    Dim PictureBox_more_teachers As New PictureBox
    Dim PictureBox_edit_students As New PictureBox
    Dim PictureBox_edit_teachers As New PictureBox
    Dim PictureBox_delete_students As New PictureBox
    Dim PictureBox_delete_teachers As New PictureBox
    Dim PictureBox_about_us As New PictureBox
    Dim PictureBox_back_to_home_from_about_us As New PictureBox
    Dim PictureBox_Logo As New PictureBox
    Dim PictureBox_Logo_a As New PictureBox
    Dim PictureBox_logo_b As New PictureBox
    Dim PictureBox_programmer_name_D As New PictureBox
    Dim PictureBox_programmer_name_B As New PictureBox
    Dim PictureBox_programmer_phone_D As New PictureBox
    Dim PictureBox_programmer_phone_B As New PictureBox
    Dim PictureBox_programmer_gmail_D As New PictureBox
    Dim PictureBox_programmer_gmail_B As New PictureBox
    Dim PictureBox_change_password_done As New PictureBox
    Dim PictureBox_change_password_leave As New PictureBox
    Dim PictureBox_password As New PictureBox
    Dim PictureBox_change_passwors As New PictureBox
    Dim PictureBox_app_off As New PictureBox
    Dim PictureBox_home As New PictureBox
    '  Dim PictureBox_setting As New PictureBox
    Dim PictureBox_level_s As New PictureBox
    Dim PictureBox_search As New PictureBox
    Dim PictureBox_population_count As New PictureBox
    Dim PictureBox_boy_count As New PictureBox
    Dim PictureBox_girl_count As New PictureBox
    Dim PictureBox_select_language_item As New PictureBox
    Dim PictureBox_en As New PictureBox
    Dim PictureBox_tur As New PictureBox
    Dim PictureBox_spa As New PictureBox
    Dim PictureBox_ita As New PictureBox
    Dim PictureBox_fre As New PictureBox
    Dim PictureBox_arab As New PictureBox
    Dim PictureBox_chi As New PictureBox
    Dim PictureBox_japa As New PictureBox
    Dim PictureBox_kor As New PictureBox
    Dim PictureBox_select_language_next_level As New PictureBox
    Dim PictureBox_level_test As New PictureBox
    Dim PictureBox_b_f_level_test As New PictureBox
    Dim PictureBox_return_password As New PictureBox
    Dim PictureBox_back_to_password As New PictureBox
    Dim PictureBox_msg_box_left As New PictureBox
    Dim PictureBox_msg_box_right As New PictureBox
    Dim PictureBox_charts_show As New PictureBox
    Dim PictureBox_charts_show_choose_item As New PictureBox
    Dim PictureBox_charts_show_all As New PictureBox
    Dim PictureBox_charts_show_teachers As New PictureBox
    Dim PictureBox_charts_show_students As New PictureBox
    Dim PictureBox_charts_show_back As New PictureBox
    Dim PictureBox_charts_2d_3d As New PictureBox
    Dim PictureBox_charts_change_type As New PictureBox
    Dim PictureBox_charts_change_color As New PictureBox
    Dim PictureBox_Part_charts_tips As New PictureBox
    Dim PictureBox_Part_charts_restore_to_default As New PictureBox
    Dim PictureBox_music As New PictureBox

    Dim Label_password As New Label
    Dim Label_Timer_lock_app As New Label
    Dim Label_1_app_off As New Label
    Dim Label_2_app_off As New Label
    Dim Label_title As New Label
    Dim Label_language As New Label
    Dim Label_between1 As New Label
    Dim Label_music As New Label
    Dim Label_between2 As New Label
    Dim Label_change_password As New Label
    Dim Label_change_password_error As New Label
    Dim Label_change_password_1 As New Label
    Dim Label_change_password_2 As New Label
    Dim Label_programmer_name_D As New Label
    Dim Label_programmer_name_B As New Label
    Dim Label_programmer_phone_D As New Label
    Dim Label_programmer_phone_B As New Label
    Dim Label_programmer_gmail_D As New Label
    Dim Label_programmer_gmail_B As New Label
    Dim Label_edit As New Label
    Dim Label_students_teachers_count As New Label
    Dim Label_boy_count As New Label
    Dim Label_girl_count As New Label
    Dim Label_select_language_s As New Label
    Dim Label_select_language_t As New Label
    Dim Label_select_language_result As New Label
    Dim Label_name_s As New Label
    Dim Label_name_father_s As New Label
    Dim Label_name_mother_s As New Label
    Dim Label_phone_s As New Label
    Dim Label_phone_father_s As New Label
    Dim Label_phone_mother_s As New Label
    Dim Label_telephone As New Label
    Dim Label_address As New Label
    Dim Label_codemeli_s As New Label
    Dim Label_datebirth As New Label
    Dim Label_date As New Label
    Dim Label_gender_s As New Label
    Dim Label_level_s As New Label
    Dim Label_level_s_result As New Label
    Dim Label_language_s_edit As New Label
    Dim Label_name_t As New Label
    Dim Label_lastname_t As New Label
    Dim Label_phone_t As New Label
    Dim Label_telephone_t As New Label
    Dim Label_address_t As New Label
    Dim Label_codemeli_t As New Label
    Dim Label_evidence As New Label
    Dim Label_datebirth_t As New Label
    Dim Label_date_t As New Label
    Dim Label_gender_t As New Label
    Dim Label_language_t_edit As New Label
    Dim Label_level_test_explain As New Label
    Dim Label_l_t_number As New Label
    Dim Label_l_t_question As New Label
    Dim Label_l_t_answer_1 As New Label
    Dim Label_l_t_answer_2 As New Label
    Dim Label_l_t_answer_3 As New Label
    Dim Label_l_t_answer_4 As New Label
    Dim Label_l_t_result_percent As New Label
    Dim Label_l_t_result_score As New Label
    Dim Label_l_t_result_explain As New Label
    Dim Label_l_t_result_table_english As New Label
    Dim Label_l_t_result_table_persian As New Label
    Dim Label_forgotten_password As New Label
    Dim Label_return_password As New Label
    Dim Label_return_password_p_1 As New Label
    Dim Label_return_password_p_2 As New Label
    Dim Label_msg_box_title As New Label
    Dim Label_msg_box_detail As New Label
    Dim Label_msg_box_option_1 As New Label
    Dim Label_msg_box_option_2 As New Label
    Dim Label_charts_show_explain_in_all As New Label
    Dim Label_charts_choose_language As New Label
    Dim Label_charts_choose_gender As New Label
    Dim Label_charts_choose_birthday As New Label
    Dim Label_charts_choose_date_of_registration As New Label
    Dim Label_Part_charts_tips_1 As New Label
    Dim Label_Part_charts_tips_2 As New Label
    Dim Label_Part_charts_tips_3 As New Label
    Dim Label_Part_charts_tips_4 As New Label
    Dim Label_Part_charts_tips_5 As New Label

    Dim GroupBox_setting As New GroupBox

    Dim TrackBar_charts_type As New TrackBar
    Dim TrackBar_charts_color As New TrackBar

    Dim Panel_change_password As New Panel
    Dim Panel_msg_box As New Panel

    Dim Radio_persian As New RadioButton
    Dim Radio_english As New RadioButton
    Dim RadioButton_male_s As New RadioButton
    Dim RadioButton_female_s As New RadioButton
    Dim RadioButton_male_t As New RadioButton
    Dim RadioButton_female_t As New RadioButton

    Dim CheckBox_en As New CheckBox
    Dim CheckBox_tur As New CheckBox
    Dim CheckBox_spa As New CheckBox
    Dim CheckBox_ita As New CheckBox
    Dim CheckBox_fre As New CheckBox
    Dim CheckBox_arab As New CheckBox
    Dim CheckBox_chi As New CheckBox
    Dim CheckBox_japa As New CheckBox
    Dim CheckBox_kor As New CheckBox

    Dim TextBox_name_s As New TextBox
    Dim TextBox_name_father_s As New TextBox
    Dim TextBox_name_mother_s As New TextBox
    Dim TextBox_phone_s As New TextBox
    Dim TextBox_phone_father_s As New TextBox
    Dim TextBox_phone_mother_s As New TextBox
    Dim TextBox_telephone As New TextBox
    Dim TextBox_address As New TextBox
    Dim TextBox_codemeli_s As New TextBox
    Dim TextBox_datebirth_s_day As New TextBox
    Dim TextBox_datebirth_s_month As New TextBox
    Dim TextBox_datebirth_s_year As New TextBox
    Dim TextBox_datebirth_s_result As New TextBox
    Dim TextBox_date_s_day As New TextBox
    Dim TextBox_date_s_month As New TextBox
    Dim TextBox_date_s_year As New TextBox
    Dim TextBox_date_s_result As New TextBox
    Dim TextBox_gender_s As New TextBox
    Dim TextBox_level_s As New TextBox
    Dim TextBox_name_t As New TextBox
    Dim TextBox_lastname_t As New TextBox
    Dim TextBox_phone_t As New TextBox
    Dim TextBox_telephone_t As New TextBox
    Dim TextBox_address_t As New TextBox
    Dim TextBox_codemeli_t As New TextBox
    Dim TextBox_evidence As New TextBox
    Dim TextBox_datebirth_t_day As New TextBox
    Dim TextBox_datebirth_t_month As New TextBox
    Dim TextBox_datebirth_t_year As New TextBox
    Dim TextBox_datebirth_t_result As New TextBox
    Dim TextBox_date_t_day As New TextBox
    Dim TextBox_date_t_month As New TextBox
    Dim TextBox_date_t_year As New TextBox
    Dim TextBox_date_t_result As New TextBox
    Dim TextBox_gender_t As New TextBox
    Dim TextBox_password As New TextBox
    Dim TextBox_change_password_1 As New TextBox
    Dim TextBox_change_password_2 As New TextBox
    Dim TextBox_app_off As New TextBox
    Dim TextBox_search As New TextBox
    Dim Textbox_return_password As New TextBox
    Dim Textbox_return_password_p_1 As New TextBox
    Dim Textbox_return_password_p_2 As New TextBox

    Dim ComboBox_level_s As New ComboBox
    Dim ComboBox_language_s_edit As New ComboBox
    Dim ComboBox_language_t_edit As New ComboBox


    'subs
    Sub control_add()
        Me.Controls.Add(PictureBox_Accounting)
        Me.Controls.Add(PictureBox_Accounting_back)
        Me.Controls.Add(PictureBox_Accounting_money_Incoming)
        Me.Controls.Add(PictureBox_Accounting_money_Output)
        Me.Controls.Add(PictureBox_Accounting_money_Turnover)

        Me.Controls.Add(Label_Accounting_farvardin)
        Me.Controls.Add(Label_Accounting_ordibehesht)
        Me.Controls.Add(Label_Accounting_khordad)
        Me.Controls.Add(Label_Accounting_tir)
        Me.Controls.Add(Label_Accounting_mordad)
        Me.Controls.Add(Label_Accounting_shahrivar)
        Me.Controls.Add(Label_Accounting_mehr)
        Me.Controls.Add(Label_Accounting_aban)
        Me.Controls.Add(Label_Accounting_azar)
        Me.Controls.Add(Label_Accounting_dey)
        Me.Controls.Add(Label_Accounting_bahman)
        Me.Controls.Add(Label_Accounting_esfand)

        Me.Controls.Add(PictureBox_Accounting_add)
        Me.Controls.Add(PictureBox_Accounting_edit)
        Me.Controls.Add(PictureBox_Accounting_delete)

        Me.Controls.Add(Label_Accounting_money_add_1)
        Me.Controls.Add(Label_Accounting_money_add_2)
        Me.Controls.Add(Label_Accounting_money_add_3)
        Me.Controls.Add(Label_Accounting_money_add_4)
        Me.Controls.Add(Label_Accounting_money_add_5)
        Me.Controls.Add(Label_Accounting_money_add_6)
        Me.Controls.Add(Label_Accounting_money_add_7)

        Me.Controls.Add(TextBox_Accounting_money_add_1)
        Me.Controls.Add(TextBox_Accounting_money_add_2)
        Me.Controls.Add(TextBox_Accounting_money_add_3)

        Me.Controls.Add(PictureBox_Accounting_add_done)

        Me.Controls.Add(PictureBox_Accounting_edit_choose)
        Me.Controls.Add(PictureBox_Accounting_delete_choose)

        Me.Controls.Add(PictureBox_Accounting_count_amount)
        Me.Controls.Add(PictureBox_Accounting_count_amount_number)
        Me.Controls.Add(Label_Accounting_count_amount)
        Me.Controls.Add(Label_Accounting_count_amount_number)










        Me.Controls.Add(Button_students)
        Me.Controls.Add(Button_teachers)
        Me.Controls.Add(Button_delete_s)
        Me.Controls.Add(Button_edit_s)
        Me.Controls.Add(Button_add_s)
        Me.Controls.Add(Button_add_t)
        Me.Controls.Add(Button_edit_t)
        Me.Controls.Add(Button_delete_t)


        Me.Controls.Add(PictureBox_back_to_home_from_students_and_teachers_list)
        Me.Controls.Add(PictureBox_complete_registration_students)
        Me.Controls.Add(PictureBox_complete_registration_teachers)
        Me.Controls.Add(PictureBox_back_to_home_from_registration_students)
        Me.Controls.Add(PictureBox_back_to_home_from_registration_teachers)
        Me.Controls.Add(PictureBox_more_students)
        Me.Controls.Add(PictureBox_more_teachers)
        Me.Controls.Add(PictureBox_edit_students)
        Me.Controls.Add(PictureBox_edit_teachers)
        Me.Controls.Add(PictureBox_delete_students)
        Me.Controls.Add(PictureBox_delete_teachers)
        Me.Controls.Add(PictureBox_about_us)
        Me.Controls.Add(PictureBox_back_to_home_from_about_us)
        Me.Controls.Add(PictureBox_Logo)
        Me.Controls.Add(PictureBox_Logo_a)
        Me.Controls.Add(PictureBox_logo_b)
        Me.Controls.Add(PictureBox_programmer_name_D)
        Me.Controls.Add(PictureBox_programmer_name_B)
        Me.Controls.Add(PictureBox_programmer_phone_D)
        Me.Controls.Add(PictureBox_programmer_phone_B)
        Me.Controls.Add(PictureBox_programmer_gmail_D)
        Me.Controls.Add(PictureBox_programmer_gmail_B)
        Me.Controls.Add(PictureBox_change_password_done)
        Me.Controls.Add(PictureBox_change_password_leave)
        Me.Controls.Add(PictureBox_password)
        Me.Controls.Add(PictureBox_change_passwors)
        Me.Controls.Add(PictureBox_app_off)
        Me.Controls.Add(PictureBox_home)
        Me.Controls.Add(PictureBox_setting)
        Me.Controls.Add(PictureBox_level_s)
        Me.Controls.Add(PictureBox_search)
        Me.Controls.Add(PictureBox_population_count)
        Me.Controls.Add(PictureBox_boy_count)
        Me.Controls.Add(PictureBox_girl_count)
        Me.Controls.Add(PictureBox_select_language_item)
        Me.Controls.Add(PictureBox_en)
        Me.Controls.Add(PictureBox_tur)
        Me.Controls.Add(PictureBox_spa)
        Me.Controls.Add(PictureBox_ita)
        Me.Controls.Add(PictureBox_fre)
        Me.Controls.Add(PictureBox_arab)
        Me.Controls.Add(PictureBox_chi)
        Me.Controls.Add(PictureBox_japa)
        Me.Controls.Add(PictureBox_kor)
        Me.Controls.Add(PictureBox_select_language_next_level)
        Me.Controls.Add(PictureBox_level_test)
        Me.Controls.Add(PictureBox_b_f_level_test)
        Me.Controls.Add(PictureBox_return_password)
        Me.Controls.Add(PictureBox_back_to_password)
        Me.Controls.Add(PictureBox_charts_show)
        Me.Controls.Add(PictureBox_charts_show_choose_item)
        Me.Controls.Add(PictureBox_charts_show_all)
        Me.Controls.Add(PictureBox_charts_show_teachers)
        Me.Controls.Add(PictureBox_charts_show_students)
        Me.Controls.Add(PictureBox_charts_show_back)
        Me.Controls.Add(PictureBox_charts_2d_3d)
        Me.Controls.Add(PictureBox_charts_change_type)
        Me.Controls.Add(PictureBox_charts_change_color)
        Me.Controls.Add(PictureBox_Part_charts_tips)
        Me.Controls.Add(PictureBox_Part_charts_restore_to_default)
        Me.Controls.Add(PictureBox_music)


        Me.Controls.Add(Label_password)
        Me.Controls.Add(Label_Timer_lock_app)
        Me.Controls.Add(Label_1_app_off)
        Me.Controls.Add(Label_2_app_off)
        Me.Controls.Add(Label_title)
        Me.Controls.Add(Label_language)
        Me.Controls.Add(Label_between1)
        Me.Controls.Add(Label_music)
        Me.Controls.Add(Label_between2)
        Me.Controls.Add(Label_change_password)
        Me.Controls.Add(Label_change_password_error)
        Me.Controls.Add(Label_change_password_1)
        Me.Controls.Add(Label_change_password_2)
        Me.Controls.Add(Label_programmer_name_D)
        Me.Controls.Add(Label_programmer_name_B)
        Me.Controls.Add(Label_programmer_phone_D)
        Me.Controls.Add(Label_programmer_phone_B)
        Me.Controls.Add(Label_programmer_gmail_D)
        Me.Controls.Add(Label_programmer_gmail_B)
        Me.Controls.Add(Label_edit)
        Me.Controls.Add(Label_students_teachers_count)
        Me.Controls.Add(Label_boy_count)
        Me.Controls.Add(Label_girl_count)
        Me.Controls.Add(Label_select_language_s)
        Me.Controls.Add(Label_select_language_t)
        Me.Controls.Add(Label_select_language_result)
        Me.Controls.Add(Label_name_s)
        Me.Controls.Add(Label_name_father_s)
        Me.Controls.Add(Label_name_mother_s)
        Me.Controls.Add(Label_phone_s)
        Me.Controls.Add(Label_phone_father_s)
        Me.Controls.Add(Label_phone_mother_s)
        Me.Controls.Add(Label_telephone)
        Me.Controls.Add(Label_address)
        Me.Controls.Add(Label_codemeli_s)
        Me.Controls.Add(Label_datebirth)
        Me.Controls.Add(Label_date)
        Me.Controls.Add(Label_gender_s)
        Me.Controls.Add(Label_level_s)
        Me.Controls.Add(Label_level_s_result)
        Me.Controls.Add(Label_language_s_edit)
        Me.Controls.Add(Label_name_t)
        Me.Controls.Add(Label_lastname_t)
        Me.Controls.Add(Label_phone_t)
        Me.Controls.Add(Label_telephone_t)
        Me.Controls.Add(Label_address_t)
        Me.Controls.Add(Label_codemeli_t)
        Me.Controls.Add(Label_evidence)
        Me.Controls.Add(Label_datebirth_t)
        Me.Controls.Add(Label_date_t)
        Me.Controls.Add(Label_gender_t)
        Me.Controls.Add(Label_language_t_edit)
        Me.Controls.Add(Label_level_test_explain)
        Me.Controls.Add(Label_l_t_number)
        Me.Controls.Add(Label_l_t_question)
        Me.Controls.Add(Label_l_t_answer_1)
        Me.Controls.Add(Label_l_t_answer_2)
        Me.Controls.Add(Label_l_t_answer_3)
        Me.Controls.Add(Label_l_t_answer_4)
        Me.Controls.Add(Label_l_t_result_percent)
        Me.Controls.Add(Label_l_t_result_score)
        Me.Controls.Add(Label_l_t_result_explain)
        Me.Controls.Add(Label_l_t_result_table_english)
        Me.Controls.Add(Label_l_t_result_table_persian)
        Me.Controls.Add(Label_forgotten_password)
        Me.Controls.Add(Label_return_password)
        Me.Controls.Add(Label_return_password_p_1)
        Me.Controls.Add(Label_return_password_p_2)
        Me.Controls.Add(Label_charts_show_explain_in_all)
        Me.Controls.Add(Label_charts_choose_language)
        Me.Controls.Add(Label_charts_choose_gender)
        Me.Controls.Add(Label_charts_choose_birthday)
        Me.Controls.Add(Label_charts_choose_date_of_registration)
        Me.Controls.Add(Label_Part_charts_tips_1)
        Me.Controls.Add(Label_Part_charts_tips_2)
        Me.Controls.Add(Label_Part_charts_tips_3)
        Me.Controls.Add(Label_Part_charts_tips_4)
        Me.Controls.Add(Label_Part_charts_tips_5)

        Me.Controls.Add(GroupBox_setting)

        Me.Controls.Add(TrackBar_charts_type)
        Me.Controls.Add(TrackBar_charts_color)

        Me.Controls.Add(Panel_change_password)

        Me.Controls.Add(Radio_persian)
        Me.Controls.Add(Radio_english)
        Me.Controls.Add(RadioButton_male_s)
        Me.Controls.Add(RadioButton_female_s)
        Me.Controls.Add(RadioButton_male_t)
        Me.Controls.Add(RadioButton_female_t)

        Me.Controls.Add(CheckBox_en)
        Me.Controls.Add(CheckBox_tur)
        Me.Controls.Add(CheckBox_spa)
        Me.Controls.Add(CheckBox_ita)
        Me.Controls.Add(CheckBox_fre)
        Me.Controls.Add(CheckBox_arab)
        Me.Controls.Add(CheckBox_chi)
        Me.Controls.Add(CheckBox_japa)
        Me.Controls.Add(CheckBox_kor)

        Me.Controls.Add(TextBox_name_s)
        Me.Controls.Add(TextBox_name_father_s)
        Me.Controls.Add(TextBox_name_mother_s)
        Me.Controls.Add(TextBox_phone_s)
        Me.Controls.Add(TextBox_phone_father_s)
        Me.Controls.Add(TextBox_phone_mother_s)
        Me.Controls.Add(TextBox_telephone)
        Me.Controls.Add(TextBox_address)
        Me.Controls.Add(TextBox_codemeli_s)
        Me.Controls.Add(TextBox_datebirth_s_day)
        Me.Controls.Add(TextBox_datebirth_s_month)
        Me.Controls.Add(TextBox_datebirth_s_year)
        Me.Controls.Add(TextBox_datebirth_s_result)
        Me.Controls.Add(TextBox_date_s_day)
        Me.Controls.Add(TextBox_date_s_month)
        Me.Controls.Add(TextBox_date_s_year)
        Me.Controls.Add(TextBox_date_s_result)
        Me.Controls.Add(TextBox_gender_s)
        Me.Controls.Add(TextBox_level_s)
        Me.Controls.Add(TextBox_name_t)
        Me.Controls.Add(TextBox_lastname_t)
        Me.Controls.Add(TextBox_phone_t)
        Me.Controls.Add(TextBox_telephone_t)
        Me.Controls.Add(TextBox_address_t)
        Me.Controls.Add(TextBox_codemeli_t)
        Me.Controls.Add(TextBox_evidence)
        Me.Controls.Add(TextBox_datebirth_t_day)
        Me.Controls.Add(TextBox_datebirth_t_month)
        Me.Controls.Add(TextBox_datebirth_t_year)
        Me.Controls.Add(TextBox_datebirth_t_result)
        Me.Controls.Add(TextBox_date_t_day)
        Me.Controls.Add(TextBox_date_t_month)
        Me.Controls.Add(TextBox_date_t_year)
        Me.Controls.Add(TextBox_date_t_result)
        Me.Controls.Add(TextBox_gender_t)
        Me.Controls.Add(TextBox_password)
        Me.Controls.Add(TextBox_change_password_1)
        Me.Controls.Add(TextBox_change_password_2)
        Me.Controls.Add(TextBox_app_off)
        Me.Controls.Add(TextBox_search)
        Me.Controls.Add(Textbox_return_password)
        Me.Controls.Add(Textbox_return_password_p_1)
        Me.Controls.Add(Textbox_return_password_p_2)

        Me.Controls.Add(ComboBox_level_s)
        Me.Controls.Add(ComboBox_language_s_edit)
        Me.Controls.Add(ComboBox_language_t_edit)




        Me.Controls.Add(Panel_msg_box)
        Me.Controls.Add(PictureBox_msg_box_left)
        Me.Controls.Add(PictureBox_msg_box_right)
        Me.Controls.Add(Label_msg_box_title)
        Me.Controls.Add(Label_msg_box_detail)
        Me.Controls.Add(Label_msg_box_option_1)
        Me.Controls.Add(Label_msg_box_option_2)

    End Sub
    Sub add_handler()
        AddHandler PictureBox_Accounting.Click, AddressOf PictureBox_Accounting_Click
        AddHandler PictureBox_Accounting.MouseEnter, AddressOf PictureBox_Accounting_MouseEnter
        AddHandler PictureBox_Accounting.MouseLeave, AddressOf PictureBox_Accounting_MouseLeave
        AddHandler PictureBox_Accounting_back.Click, AddressOf PictureBox_Accounting_back_Click
        AddHandler PictureBox_Accounting_back.MouseEnter, AddressOf PictureBox_Accounting_back_MouseEnter
        AddHandler PictureBox_Accounting_back.MouseLeave, AddressOf PictureBox_Accounting_back_MouseLeave
        AddHandler PictureBox_Accounting_money_Incoming.Click, AddressOf PictureBox_Accounting_money_Incoming_Click
        AddHandler PictureBox_Accounting_money_Incoming.MouseEnter, AddressOf PictureBox_Accounting_money_Incoming_MouseEnter
        AddHandler PictureBox_Accounting_money_Incoming.MouseLeave, AddressOf PictureBox_Accounting_money_Incoming_MouseLeave
        AddHandler PictureBox_Accounting_money_Output.Click, AddressOf PictureBox_Accounting_money_Output_Click
        AddHandler PictureBox_Accounting_money_Output.MouseEnter, AddressOf PictureBox_Accounting_money_Output_MouseEnter
        AddHandler PictureBox_Accounting_money_Output.MouseLeave, AddressOf PictureBox_Accounting_money_Output_MouseLeave
        AddHandler PictureBox_Accounting_money_Turnover.Click, AddressOf PictureBox_Accounting_money_Turnover_Click
        AddHandler PictureBox_Accounting_money_Turnover.MouseEnter, AddressOf PictureBox_Accounting_money_Turnover_MouseEnter
        AddHandler PictureBox_Accounting_money_Turnover.MouseLeave, AddressOf PictureBox_Accounting_money_Turnover_MouseLeave

        AddHandler Label_Accounting_farvardin.Click, AddressOf Label_Accounting_farvardin_Click
        AddHandler Label_Accounting_farvardin.MouseEnter, AddressOf Label_Accounting_farvardin_MouseEnter
        AddHandler Label_Accounting_farvardin.MouseLeave, AddressOf Label_Accounting_farvardin_MouseLeave
        AddHandler Label_Accounting_ordibehesht.Click, AddressOf Label_Accounting_ordibehesht_Click
        AddHandler Label_Accounting_ordibehesht.MouseEnter, AddressOf Label_Accounting_ordibehesht_MouseEnter
        AddHandler Label_Accounting_ordibehesht.MouseLeave, AddressOf Label_Accounting_ordibehesht_MouseLeave
        AddHandler Label_Accounting_khordad.Click, AddressOf Label_Accounting_khordad_Click
        AddHandler Label_Accounting_khordad.MouseEnter, AddressOf Label_Accounting_khordad_MouseEnter
        AddHandler Label_Accounting_khordad.MouseLeave, AddressOf Label_Accounting_khordad_MouseLeave
        AddHandler Label_Accounting_tir.Click, AddressOf Label_Accounting_tir_Click
        AddHandler Label_Accounting_tir.MouseEnter, AddressOf Label_Accounting_tir_MouseEnter
        AddHandler Label_Accounting_tir.MouseLeave, AddressOf Label_Accounting_tir_MouseLeave
        AddHandler Label_Accounting_mordad.Click, AddressOf Label_Accounting_mordad_Click
        AddHandler Label_Accounting_mordad.MouseEnter, AddressOf Label_Accounting_mordad_MouseEnter
        AddHandler Label_Accounting_mordad.MouseLeave, AddressOf Label_Accounting_mordad_MouseLeave
        AddHandler Label_Accounting_shahrivar.Click, AddressOf Label_Accounting_shahrivar_Click
        AddHandler Label_Accounting_shahrivar.MouseEnter, AddressOf Label_Accounting_shahrivar_MouseEnter
        AddHandler Label_Accounting_shahrivar.MouseLeave, AddressOf Label_Accounting_shahrivar_MouseLeave
        AddHandler Label_Accounting_mehr.Click, AddressOf Label_Accounting_mehr_Click
        AddHandler Label_Accounting_mehr.MouseEnter, AddressOf Label_Accounting_mehr_MouseEnter
        AddHandler Label_Accounting_mehr.MouseLeave, AddressOf Label_Accounting_mehr_MouseLeave
        AddHandler Label_Accounting_aban.Click, AddressOf Label_Accounting_aban_Click
        AddHandler Label_Accounting_aban.MouseEnter, AddressOf Label_Accounting_aban_MouseEnter
        AddHandler Label_Accounting_aban.MouseLeave, AddressOf Label_Accounting_aban_MouseLeave
        AddHandler Label_Accounting_azar.Click, AddressOf Label_Accounting_azar_Click
        AddHandler Label_Accounting_azar.MouseEnter, AddressOf Label_Accounting_azar_MouseEnter
        AddHandler Label_Accounting_azar.MouseLeave, AddressOf Label_Accounting_azar_MouseLeave
        AddHandler Label_Accounting_dey.Click, AddressOf Label_Accounting_dey_Click
        AddHandler Label_Accounting_dey.MouseEnter, AddressOf Label_Accounting_dey_MouseEnter
        AddHandler Label_Accounting_dey.MouseLeave, AddressOf Label_Accounting_dey_MouseLeave
        AddHandler Label_Accounting_bahman.Click, AddressOf Label_Accounting_bahman_Click
        AddHandler Label_Accounting_bahman.MouseEnter, AddressOf Label_Accounting_bahman_MouseEnter
        AddHandler Label_Accounting_bahman.MouseLeave, AddressOf Label_Accounting_bahman_MouseLeave
        AddHandler Label_Accounting_esfand.Click, AddressOf Label_Accounting_esfand_Click
        AddHandler Label_Accounting_esfand.MouseEnter, AddressOf Label_Accounting_esfand_MouseEnter
        AddHandler Label_Accounting_esfand.MouseLeave, AddressOf Label_Accounting_esfand_MouseLeave

        AddHandler PictureBox_Accounting_add.Click, AddressOf PictureBox_Accounting_add_Click
        AddHandler PictureBox_Accounting_add.MouseEnter, AddressOf PictureBox_Accounting_add_MouseEnter
        AddHandler PictureBox_Accounting_add.MouseLeave, AddressOf PictureBox_Accounting_add_MouseLeave
        AddHandler PictureBox_Accounting_edit.Click, AddressOf PictureBox_Accounting_edit_Click
        AddHandler PictureBox_Accounting_edit.MouseEnter, AddressOf PictureBox_Accounting_edit_MouseEnter
        AddHandler PictureBox_Accounting_edit.MouseLeave, AddressOf PictureBox_Accounting_edit_MouseLeave
        AddHandler PictureBox_Accounting_delete.Click, AddressOf PictureBox_Accounting_delete_Click
        AddHandler PictureBox_Accounting_delete.MouseEnter, AddressOf PictureBox_Accounting_delete_MouseEnter
        AddHandler PictureBox_Accounting_delete.MouseLeave, AddressOf PictureBox_Accounting_delete_MouseLeave

        AddHandler PictureBox_Accounting_add_done.Click, AddressOf PictureBox_Accounting_add_done_Click
        AddHandler PictureBox_Accounting_add_done.MouseEnter, AddressOf PictureBox_Accounting_add_done_MouseEnter
        AddHandler PictureBox_Accounting_add_done.MouseLeave, AddressOf PictureBox_Accounting_add_done_MouseLeave

        AddHandler PictureBox_Accounting_edit_choose.Click, AddressOf PictureBox_Accounting_edit_choose_Click
        AddHandler PictureBox_Accounting_edit_choose.MouseEnter, AddressOf PictureBox_Accounting_edit_choose_MouseEnter
        AddHandler PictureBox_Accounting_edit_choose.MouseLeave, AddressOf PictureBox_Accounting_edit_choose_MouseLeave
        AddHandler PictureBox_Accounting_delete_choose.Click, AddressOf PictureBox_Accounting_delete_choose_Click
        AddHandler PictureBox_Accounting_delete_choose.MouseEnter, AddressOf PictureBox_Accounting_delete_choose_MouseEnter
        AddHandler PictureBox_Accounting_delete_choose.MouseLeave, AddressOf PictureBox_Accounting_delete_choose_MouseLeave
       

















        AddHandler Timer_lock_app.Tick, AddressOf Timer_lock_app_Tick


        AddHandler Button_students.Click, AddressOf Button_students_Click
        AddHandler Button_teachers.Click, AddressOf Button_teachers_Click
        AddHandler Button_delete_s.Click, AddressOf Button_delete_s_Click
        AddHandler Button_edit_s.Click, AddressOf Button_edit_s_Click
        AddHandler Button_add_s.Click, AddressOf Button_add_s_Click
        AddHandler Button_add_t.Click, AddressOf Button_add_t_Click
        AddHandler Button_edit_t.Click, AddressOf Button_edit_t_Click
        AddHandler Button_delete_t.Click, AddressOf Button_delete_t_Click


        AddHandler PictureBox_back_to_home_from_students_and_teachers_list.Click, AddressOf PictureBox_back_to_home_from_students_and_teachers_list_Click
        AddHandler PictureBox_back_to_home_from_students_and_teachers_list.MouseEnter, AddressOf PictureBox_back_to_home_from_students_and_teachers_list_MouseEnter
        AddHandler PictureBox_back_to_home_from_students_and_teachers_list.MouseLeave, AddressOf PictureBox_back_to_home_from_students_and_teachers_list_MouseLeave
        AddHandler PictureBox_complete_registration_students.Click, AddressOf PictureBox_complete_registration_students_Click
        AddHandler PictureBox_complete_registration_students.MouseEnter, AddressOf PictureBox_complete_registration_students_MouseEnter
        AddHandler PictureBox_complete_registration_students.MouseLeave, AddressOf PictureBox_complete_registration_students_MouseLeave
        AddHandler PictureBox_complete_registration_teachers.Click, AddressOf PictureBox_complete_registration_teachers_Click
        AddHandler PictureBox_complete_registration_teachers.MouseEnter, AddressOf PictureBox_complete_registration_teachers_MouseEnter
        AddHandler PictureBox_complete_registration_teachers.MouseLeave, AddressOf PictureBox_complete_registration_teachers_MouseLeave
        AddHandler PictureBox_back_to_home_from_registration_students.Click, AddressOf PictureBox_back_to_home_from_registration_students_Click
        AddHandler PictureBox_back_to_home_from_registration_students.MouseEnter, AddressOf PictureBox_back_to_home_from_registration_students_MouseEnter
        AddHandler PictureBox_back_to_home_from_registration_students.MouseLeave, AddressOf PictureBox_back_to_home_from_registration_students_MouseLeave
        AddHandler PictureBox_back_to_home_from_registration_teachers.Click, AddressOf PictureBox_back_to_home_from_registration_teachers_Click
        AddHandler PictureBox_back_to_home_from_registration_teachers.MouseEnter, AddressOf PictureBox_back_to_home_from_registration_teachers_MouseEnter
        AddHandler PictureBox_back_to_home_from_registration_teachers.MouseLeave, AddressOf PictureBox_back_to_home_from_registration_teachers_MouseLeave
        AddHandler PictureBox_more_students.Click, AddressOf PictureBox_more_students_Click
        AddHandler PictureBox_more_students.MouseEnter, AddressOf PictureBox_more_students_MouseEnter
        AddHandler PictureBox_more_students.MouseLeave, AddressOf PictureBox_more_students_MouseLeave
        AddHandler PictureBox_more_teachers.Click, AddressOf PictureBox_more_teachers_Click
        AddHandler PictureBox_more_teachers.MouseEnter, AddressOf PictureBox_more_teachers_MouseEnter
        AddHandler PictureBox_more_teachers.MouseLeave, AddressOf PictureBox_more_teachers_MouseLeave
        AddHandler PictureBox_edit_students.Click, AddressOf PictureBox_edit_students_Click
        AddHandler PictureBox_edit_students.MouseEnter, AddressOf PictureBox_edit_students_MouseEnter
        AddHandler PictureBox_edit_students.MouseLeave, AddressOf PictureBox_edit_students_MouseLeave
        AddHandler PictureBox_edit_teachers.Click, AddressOf PictureBox_edit_teachers_Click
        AddHandler PictureBox_edit_teachers.MouseEnter, AddressOf PictureBox_edit_teachers_MouseEnter
        AddHandler PictureBox_edit_teachers.MouseLeave, AddressOf PictureBox_edit_teachers_MouseLeave
        AddHandler PictureBox_delete_students.Click, AddressOf PictureBox_delete_students_Click
        AddHandler PictureBox_delete_students.MouseEnter, AddressOf PictureBox_delete_students_MouseEnter
        AddHandler PictureBox_delete_students.MouseLeave, AddressOf PictureBox_delete_students_MouseLeave
        AddHandler PictureBox_delete_teachers.Click, AddressOf PictureBox_delete_teachers_Click
        AddHandler PictureBox_delete_teachers.MouseEnter, AddressOf PictureBox_delete_teachers_MouseEnter
        AddHandler PictureBox_delete_teachers.MouseLeave, AddressOf PictureBox_delete_teachers_MouseLeave
        AddHandler PictureBox_about_us.Click, AddressOf PictureBox_about_us_Click
        AddHandler PictureBox_about_us.MouseEnter, AddressOf PictureBox_about_us_MouseEnter
        AddHandler PictureBox_about_us.MouseLeave, AddressOf PictureBox_about_us_MouseLeave
        AddHandler PictureBox_back_to_home_from_about_us.Click, AddressOf PictureBox_back_to_home_from_about_us_Click
        AddHandler PictureBox_back_to_home_from_about_us.MouseEnter, AddressOf PictureBox_back_to_home_from_about_us_MouseEnter
        AddHandler PictureBox_back_to_home_from_about_us.MouseLeave, AddressOf PictureBox_back_to_home_from_about_us_MouseLeave
        AddHandler PictureBox_change_password_done.Click, AddressOf PictureBox_change_password_done_Click
        AddHandler PictureBox_change_password_done.MouseEnter, AddressOf PictureBox_change_password_done_MouseEnter
        AddHandler PictureBox_change_password_done.MouseLeave, AddressOf PictureBox_change_password_done_MouseLeave
        AddHandler PictureBox_change_password_leave.Click, AddressOf PictureBox_change_password_leave_Click
        AddHandler PictureBox_change_password_leave.MouseEnter, AddressOf PictureBox_change_password_leave_MouseEnter
        AddHandler PictureBox_change_password_leave.MouseLeave, AddressOf PictureBox_change_password_leave_MouseLeave
        AddHandler PictureBox_change_passwors.Click, AddressOf PictureBox_change_passwors_Click
        AddHandler PictureBox_change_passwors.MouseEnter, AddressOf PictureBox_change_passwors_MouseEnter
        AddHandler PictureBox_change_passwors.MouseLeave, AddressOf PictureBox_change_passwors_MouseLeave
        AddHandler PictureBox_password.Click, AddressOf PictureBox_password_Click
        AddHandler PictureBox_password.MouseEnter, AddressOf PictureBox_password_MouseEnter
        AddHandler PictureBox_password.MouseLeave, AddressOf PictureBox_password_MouseLeave
        AddHandler PictureBox_home.Click, AddressOf PictureBox_home_Click
        ' AddHandler PictureBox_setting.Click, AddressOf PictureBox_setting_Click
        ' AddHandler PictureBox_setting.MouseEnter, AddressOf PictureBox_setting_MouseEnter
        ' AddHandler PictureBox_setting.MouseLeave, AddressOf PictureBox_setting_MouseLeave
        AddHandler PictureBox_level_s.Click, AddressOf PictureBox_level_s_Click
        AddHandler PictureBox_level_s.MouseEnter, AddressOf PictureBox_level_s_MouseEnter
        AddHandler PictureBox_level_s.MouseLeave, AddressOf PictureBox_level_s_MouseLeave
        AddHandler PictureBox_search.Click, AddressOf PictureBox_search_Click
        AddHandler PictureBox_search.MouseEnter, AddressOf PictureBox_search_MouseEnter
        AddHandler PictureBox_search.MouseLeave, AddressOf PictureBox_search_MouseLeave
        AddHandler PictureBox_select_language_next_level.Click, AddressOf PictureBox_select_language_next_level_Click
        AddHandler PictureBox_select_language_next_level.MouseEnter, AddressOf PictureBox_select_language_next_level_MouseEnter
        AddHandler PictureBox_select_language_next_level.MouseLeave, AddressOf PictureBox_select_language_next_level_MouseLeave
        AddHandler PictureBox_level_test.Click, AddressOf PictureBox_level_test_Click
        AddHandler PictureBox_level_test.MouseEnter, AddressOf PictureBox_level_test_MouseEnter
        AddHandler PictureBox_level_test.MouseLeave, AddressOf PictureBox_level_test_MouseLeave
        AddHandler PictureBox_b_f_level_test.Click, AddressOf PictureBox_b_f_level_test_Click
        AddHandler PictureBox_b_f_level_test.MouseEnter, AddressOf PictureBox_b_f_level_test_MouseEnter
        AddHandler PictureBox_b_f_level_test.MouseLeave, AddressOf PictureBox_b_f_level_test_MouseLeave
        AddHandler PictureBox_return_password.Click, AddressOf PictureBox_return_password_Click
        AddHandler PictureBox_return_password.MouseEnter, AddressOf PictureBox_return_password_MouseEnter
        AddHandler PictureBox_return_password.MouseLeave, AddressOf PictureBox_return_password_MouseLeave
        AddHandler PictureBox_back_to_password.Click, AddressOf PictureBox_back_to_password_Click
        AddHandler PictureBox_back_to_password.MouseEnter, AddressOf PictureBox_back_to_password_MouseEnter
        AddHandler PictureBox_back_to_password.MouseLeave, AddressOf PictureBox_back_to_password_MouseLeave
        AddHandler PictureBox_charts_show.Click, AddressOf PictureBox_charts_show_Click
        AddHandler PictureBox_charts_show.MouseEnter, AddressOf PictureBox_charts_show_MouseEnter
        AddHandler PictureBox_charts_show.MouseLeave, AddressOf PictureBox_charts_show_MouseLeave
        AddHandler PictureBox_charts_show_all.Click, AddressOf PictureBox_charts_show_all_Click
        AddHandler PictureBox_charts_show_all.MouseEnter, AddressOf PictureBox_charts_show_all_MouseEnter
        AddHandler PictureBox_charts_show_all.MouseLeave, AddressOf PictureBox_charts_show_all_MouseLeave
        AddHandler PictureBox_charts_show_teachers.Click, AddressOf PictureBox_charts_show_teachers_Click
        AddHandler PictureBox_charts_show_teachers.MouseEnter, AddressOf PictureBox_charts_show_teachers_MouseEnter
        AddHandler PictureBox_charts_show_teachers.MouseLeave, AddressOf PictureBox_charts_show_teachers_MouseLeave
        AddHandler PictureBox_charts_show_students.Click, AddressOf PictureBox_charts_show_students_Click
        AddHandler PictureBox_charts_show_students.MouseEnter, AddressOf PictureBox_charts_show_students_MouseEnter
        AddHandler PictureBox_charts_show_students.MouseLeave, AddressOf PictureBox_charts_show_students_MouseLeave
        AddHandler PictureBox_charts_show_back.Click, AddressOf PictureBox_charts_show_back_Click
        AddHandler PictureBox_charts_show_back.MouseEnter, AddressOf PictureBox_charts_show_back_MouseEnter
        AddHandler PictureBox_charts_show_back.MouseLeave, AddressOf PictureBox_charts_show_back_MouseLeave
        AddHandler PictureBox_charts_2d_3d.Click, AddressOf PictureBox_charts_2d_3d_Click
        AddHandler PictureBox_charts_2d_3d.MouseEnter, AddressOf PictureBox_charts_2d_3d_MouseEnter
        AddHandler PictureBox_charts_2d_3d.MouseLeave, AddressOf PictureBox_charts_2d_3d_MouseLeave
        AddHandler PictureBox_Part_charts_tips.Click, AddressOf PictureBox_Part_charts_tips_Click
        AddHandler PictureBox_Part_charts_tips.MouseEnter, AddressOf PictureBox_Part_charts_tips_MouseEnter
        AddHandler PictureBox_Part_charts_tips.MouseLeave, AddressOf PictureBox_Part_charts_tips_MouseLeave
        AddHandler PictureBox_Part_charts_restore_to_default.Click, AddressOf PictureBox_Part_charts_restore_to_default_Click
        AddHandler PictureBox_Part_charts_restore_to_default.MouseEnter, AddressOf PictureBox_Part_charts_restore_to_default_MouseEnter
        AddHandler PictureBox_Part_charts_restore_to_default.MouseLeave, AddressOf PictureBox_Part_charts_restore_to_default_MouseLeave
        AddHandler PictureBox_music.Click, AddressOf PictureBox_music_Click
        AddHandler PictureBox_music.MouseEnter, AddressOf PictureBox_music_MouseEnter
        AddHandler PictureBox_music.MouseLeave, AddressOf PictureBox_music_MouseLeave


        AddHandler Label_title.Click, AddressOf Label_title_Click
        AddHandler Label_Timer_lock_app.TextChanged, AddressOf Label_Timer_lock_app_TextChanged
        AddHandler Label_l_t_answer_1.Click, AddressOf Label_l_t_answer_1_Click
        AddHandler Label_l_t_answer_1.MouseEnter, AddressOf Label_l_t_answer_1_MouseEnter
        AddHandler Label_l_t_answer_1.MouseLeave, AddressOf Label_l_t_answer_1_MouseLeave
        AddHandler Label_l_t_answer_2.Click, AddressOf Label_l_t_answer_2_Click
        AddHandler Label_l_t_answer_2.MouseEnter, AddressOf Label_l_t_answer_2_MouseEnter
        AddHandler Label_l_t_answer_2.MouseLeave, AddressOf Label_l_t_answer_2_MouseLeave
        AddHandler Label_l_t_answer_3.Click, AddressOf Label_l_t_answer_3_Click
        AddHandler Label_l_t_answer_3.MouseEnter, AddressOf Label_l_t_answer_3_MouseEnter
        AddHandler Label_l_t_answer_3.MouseLeave, AddressOf Label_l_t_answer_3_MouseLeave
        AddHandler Label_l_t_answer_4.Click, AddressOf Label_l_t_answer_4_Click
        AddHandler Label_l_t_answer_4.MouseEnter, AddressOf Label_l_t_answer_4_MouseEnter
        AddHandler Label_l_t_answer_4.MouseLeave, AddressOf Label_l_t_answer_4_MouseLeave
        AddHandler Label_forgotten_password.Click, AddressOf Label_forgotten_password_Click
        AddHandler Label_forgotten_password.MouseEnter, AddressOf Label_forgotten_password_MouseEnter
        AddHandler Label_forgotten_password.MouseLeave, AddressOf Label_forgotten_password_MouseLeave
        AddHandler Label_msg_box_option_1.Click, AddressOf Label_msg_box_option_1_Click
        AddHandler Label_msg_box_option_1.MouseEnter, AddressOf Label_msg_box_option_1_MouseEnter
        AddHandler Label_msg_box_option_1.MouseLeave, AddressOf Label_msg_box_option_1_MouseLeave
        AddHandler Label_msg_box_option_2.Click, AddressOf Label_msg_box_option_2_Click
        AddHandler Label_msg_box_option_2.MouseEnter, AddressOf Label_msg_box_option_2_MouseEnter
        AddHandler Label_msg_box_option_2.MouseLeave, AddressOf Label_msg_box_option_2_MouseLeave
        AddHandler Label_charts_choose_language.Click, AddressOf Label_charts_choose_language_Click
        AddHandler Label_charts_choose_language.MouseEnter, AddressOf Label_charts_choose_language_MouseEnter
        AddHandler Label_charts_choose_language.MouseLeave, AddressOf Label_charts_choose_language_MouseLeave
        AddHandler Label_charts_choose_gender.Click, AddressOf Label_charts_choose_gender_Click
        AddHandler Label_charts_choose_gender.MouseEnter, AddressOf Label_charts_choose_gender_MouseEnter
        AddHandler Label_charts_choose_gender.MouseLeave, AddressOf Label_charts_choose_gender_MouseLeave
        AddHandler Label_charts_choose_birthday.Click, AddressOf Label_charts_choose_birthday_Click
        AddHandler Label_charts_choose_birthday.MouseEnter, AddressOf Label_charts_choose_birthday_MouseEnter
        AddHandler Label_charts_choose_birthday.MouseLeave, AddressOf Label_charts_choose_birthday_MouseLeave
        AddHandler Label_charts_choose_date_of_registration.Click, AddressOf Label_charts_choose_date_of_registration_Click
        AddHandler Label_charts_choose_date_of_registration.MouseEnter, AddressOf Label_charts_choose_date_of_registration_MouseEnter
        AddHandler Label_charts_choose_date_of_registration.MouseLeave, AddressOf Label_charts_choose_date_of_registration_MouseLeave


        AddHandler TrackBar_charts_type.Scroll, AddressOf TrackBar_charts_type_Scroll
        AddHandler TrackBar_charts_color.Scroll, AddressOf TrackBar_charts_color_Scroll


        AddHandler Radio_persian.CheckedChanged, AddressOf Radio_persian_CheckedChanged
        AddHandler Radio_english.CheckedChanged, AddressOf Radio_english_CheckedChanged
        AddHandler RadioButton_male_s.CheckedChanged, AddressOf RadioButton_male_s_CheckedChanged
        AddHandler RadioButton_female_s.CheckedChanged, AddressOf RadioButton_female_s_CheckedChanged
        AddHandler RadioButton_male_t.CheckedChanged, AddressOf RadioButton_male_t_CheckedChanged
        AddHandler RadioButton_female_t.CheckedChanged, AddressOf RadioButton_female_t_CheckedChanged


        AddHandler CheckBox_en.CheckedChanged, AddressOf CheckBox_en_CheckedChanged
        AddHandler CheckBox_tur.CheckedChanged, AddressOf CheckBox_tur_CheckedChanged
        AddHandler CheckBox_spa.CheckedChanged, AddressOf CheckBox_spa_CheckedChanged
        AddHandler CheckBox_ita.CheckedChanged, AddressOf CheckBox_ita_CheckedChanged
        AddHandler CheckBox_fre.CheckedChanged, AddressOf CheckBox_fre_CheckedChanged
        AddHandler CheckBox_arab.CheckedChanged, AddressOf CheckBox_arab_CheckedChanged
        AddHandler CheckBox_chi.CheckedChanged, AddressOf CheckBox_chi_CheckedChanged
        AddHandler CheckBox_japa.CheckedChanged, AddressOf CheckBox_japa_CheckedChanged
        AddHandler CheckBox_kor.CheckedChanged, AddressOf CheckBox_kor_CheckedChanged


        AddHandler TextBox_datebirth_s_day.Click, AddressOf TextBox_datebirth_s_day_Click
        AddHandler TextBox_datebirth_s_day.TextChanged, AddressOf TextBox_datebirth_s_day_TextChanged
        AddHandler TextBox_datebirth_s_month.Click, AddressOf TextBox_datebirth_s_month_Click
        AddHandler TextBox_datebirth_s_month.TextChanged, AddressOf TextBox_datebirth_s_month_TextChanged
        AddHandler TextBox_datebirth_s_year.Click, AddressOf TextBox_datebirth_s_year_Click
        AddHandler TextBox_datebirth_s_year.TextChanged, AddressOf TextBox_datebirth_s_year_TextChanged
        AddHandler TextBox_date_s_day.Click, AddressOf TextBox_date_s_day_Click
        AddHandler TextBox_date_s_day.TextChanged, AddressOf TextBox_date_s_day_TextChanged
        AddHandler TextBox_date_s_month.Click, AddressOf TextBox_date_s_month_Click
        AddHandler TextBox_date_s_month.TextChanged, AddressOf TextBox_date_s_month_TextChanged
        AddHandler TextBox_date_s_year.Click, AddressOf TextBox_date_s_year_Click
        AddHandler TextBox_date_s_year.TextChanged, AddressOf TextBox_date_s_year_TextChanged
        AddHandler TextBox_level_s.TextChanged, AddressOf TextBox_level_s_TextChanged
        AddHandler TextBox_datebirth_t_day.Click, AddressOf TextBox_datebirth_t_day_Click
        AddHandler TextBox_datebirth_t_day.TextChanged, AddressOf TextBox_datebirth_t_day_TextChanged
        AddHandler TextBox_datebirth_t_month.Click, AddressOf TextBox_datebirth_t_month_Click
        AddHandler TextBox_datebirth_t_month.TextChanged, AddressOf TextBox_datebirth_t_month_TextChanged
        AddHandler TextBox_datebirth_t_year.Click, AddressOf TextBox_datebirth_t_year_Click
        AddHandler TextBox_datebirth_t_year.TextChanged, AddressOf TextBox_datebirth_t_year_TextChanged
        AddHandler TextBox_date_t_day.Click, AddressOf TextBox_date_t_day_Click
        AddHandler TextBox_date_t_day.TextChanged, AddressOf TextBox_date_t_day_TextChanged
        AddHandler TextBox_date_t_month.Click, AddressOf TextBox_date_t_month_Click
        AddHandler TextBox_date_t_month.TextChanged, AddressOf TextBox_date_t_month_TextChanged
        AddHandler TextBox_date_t_year.Click, AddressOf TextBox_date_t_year_Click
        AddHandler TextBox_date_t_year.TextChanged, AddressOf TextBox_date_t_year_TextChanged
        AddHandler TextBox_password.Click, AddressOf TextBox_password_Click
        AddHandler TextBox_app_off.DoubleClick, AddressOf TextBox_app_off_DoubleClick
        AddHandler TextBox_search.Click, AddressOf TextBox_search_Click
        AddHandler TextBox_search.LostFocus, AddressOf TextBox_search_LostFocus
        AddHandler TextBox_search.TextChanged, AddressOf TextBox_search_TextChanged
        AddHandler Textbox_return_password.Click, AddressOf Textbox_return_password_Click


        AddHandler ComboBox_level_s.SelectedIndexChanged, AddressOf ComboBox_level_s_SelectedIndexChanged
        AddHandler ComboBox_language_s_edit.SelectedIndexChanged, AddressOf ComboBox_language_s_edit_SelectedIndexChanged
        AddHandler ComboBox_language_t_edit.SelectedIndexChanged, AddressOf ComboBox_language_t_edit_SelectedIndexChanged
    End Sub
    Sub Cursor_change()
        PictureBox_Accounting.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_back.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_money_Incoming.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_money_Output.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_money_Turnover.Cursor = System.Windows.Forms.Cursors.Hand

        Label_Accounting_farvardin.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_ordibehesht.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_khordad.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_tir.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_mordad.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_shahrivar.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_mehr.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_aban.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_azar.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_dey.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_bahman.Cursor = System.Windows.Forms.Cursors.Hand
        Label_Accounting_esfand.Cursor = System.Windows.Forms.Cursors.Hand

        PictureBox_Accounting_add.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_edit.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_delete.Cursor = System.Windows.Forms.Cursors.Hand

        PictureBox_Accounting_add_done.Cursor = System.Windows.Forms.Cursors.Hand

        PictureBox_Accounting_edit_choose.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Accounting_delete_choose.Cursor = System.Windows.Forms.Cursors.Hand













        Button_students.Cursor = System.Windows.Forms.Cursors.Hand
        Button_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        Button_delete_s.Cursor = System.Windows.Forms.Cursors.Hand
        Button_edit_s.Cursor = System.Windows.Forms.Cursors.Hand
        Button_add_s.Cursor = System.Windows.Forms.Cursors.Hand
        Button_add_t.Cursor = System.Windows.Forms.Cursors.Hand
        Button_edit_t.Cursor = System.Windows.Forms.Cursors.Hand
        Button_delete_t.Cursor = System.Windows.Forms.Cursors.Hand


        PictureBox_back_to_home_from_students_and_teachers_list.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_complete_registration_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_complete_registration_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_back_to_home_from_registration_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_back_to_home_from_registration_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_more_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_more_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_edit_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_edit_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_delete_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_delete_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_about_us.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_back_to_home_from_about_us.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_change_password_done.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_change_password_leave.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_password.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_change_passwors.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_setting.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_level_s.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_search.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_select_language_next_level.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_level_test.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_b_f_level_test.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_return_password.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_back_to_password.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_show.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_show_all.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_show_teachers.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_show_students.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_show_back.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_charts_2d_3d.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Part_charts_tips.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_Part_charts_restore_to_default.Cursor = System.Windows.Forms.Cursors.Hand
        PictureBox_music.Cursor = System.Windows.Forms.Cursors.Hand


        Label_l_t_answer_1.Cursor = System.Windows.Forms.Cursors.Hand
        Label_l_t_answer_2.Cursor = System.Windows.Forms.Cursors.Hand
        Label_l_t_answer_3.Cursor = System.Windows.Forms.Cursors.Hand
        Label_l_t_answer_4.Cursor = System.Windows.Forms.Cursors.Hand
        Label_forgotten_password.Cursor = System.Windows.Forms.Cursors.Hand
        Label_msg_box_option_1.Cursor = System.Windows.Forms.Cursors.Hand
        Label_msg_box_option_2.Cursor = System.Windows.Forms.Cursors.Hand
        Label_charts_choose_language.Cursor = System.Windows.Forms.Cursors.Hand
        Label_charts_choose_gender.Cursor = System.Windows.Forms.Cursors.Hand
        Label_charts_choose_birthday.Cursor = System.Windows.Forms.Cursors.Hand
        Label_charts_choose_date_of_registration.Cursor = System.Windows.Forms.Cursors.Hand


        TrackBar_charts_type.Cursor = System.Windows.Forms.Cursors.Hand
        TrackBar_charts_color.Cursor = System.Windows.Forms.Cursors.Hand


        Radio_persian.Cursor = System.Windows.Forms.Cursors.Hand
        Radio_english.Cursor = System.Windows.Forms.Cursors.Hand
        RadioButton_male_s.Cursor = System.Windows.Forms.Cursors.Hand
        RadioButton_female_s.Cursor = System.Windows.Forms.Cursors.Hand
        RadioButton_male_t.Cursor = System.Windows.Forms.Cursors.Hand
        RadioButton_female_t.Cursor = System.Windows.Forms.Cursors.Hand


        CheckBox_en.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_tur.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_spa.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_ita.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_fre.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_arab.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_chi.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_japa.Cursor = System.Windows.Forms.Cursors.Hand
        CheckBox_kor.Cursor = System.Windows.Forms.Cursors.Hand


        ComboBox_level_s.Cursor = System.Windows.Forms.Cursors.Hand
        ComboBox_language_s_edit.Cursor = System.Windows.Forms.Cursors.Hand
        ComboBox_language_t_edit.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Sub database_show_student()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from student", connect_S)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        StudentDataGridView.DataSource = DataTable
    End Sub
    Sub database_add_s()
        Dim insert As String = "insert into student(name_s,father_name_s,mother_name_s,phone_s,phone_father_s,phone_mother_s,telephone_s,address_s,nationalcode_s,birthday_s,date_s,gender_s,booklevel_s,language_s) values (N'" & TextBox_name_s.Text & "',N'" & TextBox_name_father_s.Text & "',N'" & TextBox_name_mother_s.Text & "',N'" & TextBox_phone_s.Text & "',N'" & TextBox_phone_father_s.Text & "',N'" & TextBox_phone_mother_s.Text & "',N'" & TextBox_telephone.Text & "',N'" & TextBox_address.Text & "',N'" & TextBox_codemeli_s.Text & "',N'" & TextBox_datebirth_s_result.Text & "',N'" & TextBox_date_s_result.Text & "',N'" & TextBox_gender_s.Text & "',N'" & Label_level_s_result.Text & "',N'" & Label_select_language_result.Text & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_S)

        connect_S.Open()
        run.ExecuteNonQuery()
        connect_S.Close()

        database_show_student()

    End Sub
    Sub database_delete_s()
        Dim delete As String = "delete from student where id=" & StudentDataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_S)
        connect_S.Open()
        run.ExecuteNonQuery()
        connect_S.Close()
        database_show_student()
    End Sub
    Sub database_edit_s()
        Dim edit As String = "update student set name_s=N'" & TextBox_name_s.Text & "',father_name_s=N'" & TextBox_name_father_s.Text & "',mother_name_s=N'" & TextBox_name_mother_s.Text & "',phone_s=N'" & TextBox_phone_s.Text & "',phone_father_s=N'" & TextBox_phone_father_s.Text & "',phone_mother_s=N'" & TextBox_phone_mother_s.Text & "',telephone_s=N'" & TextBox_telephone.Text & "',address_s=N'" & TextBox_address.Text & "',nationalcode_s=N'" & TextBox_codemeli_s.Text & "',birthday_s=N'" & TextBox_datebirth_s_result.Text & "',date_s=N'" & TextBox_date_s_result.Text & "',gender_s=N'" & TextBox_gender_s.Text & "',booklevel_s=N'" & Label_level_s_result.Text & "',language_s=N'" & Label_select_language_result.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_S)
        connect_S.Open()
        run.ExecuteNonQuery()
        connect_S.Close()
        database_show_student()
    End Sub
    Sub database_search_s()
        Dim searchQuery As String = ("SELECT * From student WHERE CONCAT(id,name_s,father_name_s,mother_name_s,phone_s,phone_father_s,phone_mother_s,telephone_s,address_s,nationalcode_s,birthday_s,date_s,gender_s,booklevel_s,language_s) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_S)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        StudentDataGridView.DataSource = DataTable
    End Sub

    Sub database_show_teacher()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from teachers", connect_T)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        TeachersDataGridView.DataSource = DataTable
    End Sub
    Sub database_add_t()
        Dim insert As String = "insert into teachers(name_t,lastname_t,phone_t,telephone_t,address_t,nationalcode_t,evidence_t,birthday_t,data_t,gender_t,language_t) values (N'" & TextBox_name_t.Text & "',N'" & TextBox_lastname_t.Text & "',N'" & TextBox_phone_t.Text & "',N'" & TextBox_telephone_t.Text & "',N'" & TextBox_address_t.Text & "',N'" & TextBox_codemeli_t.Text & "',N'" & TextBox_evidence.Text & "',N'" & TextBox_datebirth_t_result.Text & "',N'" & TextBox_date_t_result.Text & "',N'" & TextBox_gender_t.Text & "',N'" & Label_select_language_result.Text & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_T)
        connect_T.Open()
        run.ExecuteNonQuery()
        connect_T.Close()
        database_show_teacher()

    End Sub
    Sub database_delete_t()
        Dim delete As String = "delete from teachers where id=" & TeachersDataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_T)
        connect_T.Open()
        run.ExecuteNonQuery()
        connect_T.Close()
        database_show_teacher()
    End Sub
    Sub database_edit_t()
        Dim edit As String = "update teachers set name_t=N'" & TextBox_name_t.Text & "',lastname_t=N'" & TextBox_lastname_t.Text & "',phone_t=N'" & TextBox_phone_t.Text & "',telephone_t=N'" & TextBox_telephone_t.Text & "',address_t=N'" & TextBox_address_t.Text & "',nationalcode_t=N'" & TextBox_codemeli_t.Text & "',evidence_t=N'" & TextBox_evidence.Text & "',birthday_t=N'" & TextBox_datebirth_t_result.Text & "',data_t=N'" & TextBox_date_t_result.Text & "',gender_t=N'" & TextBox_gender_t.Text & "',language_t=N'" & Label_select_language_result.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_T)
        connect_T.Open()
        run.ExecuteNonQuery()
        connect_T.Close()
        database_show_teacher()
    End Sub
    Sub database_search_t()
        Dim searchQuery As String = ("SELECT * From teachers WHERE CONCAT(id,name_t,lastname_t,phone_t,telephone_t,address_t,nationalcode_t,evidence_t,birthday_t,data_t,gender_t,language_t) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_T)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        TeachersDataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_farvardin()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_farvardin", connect_m_i_farvardin)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_farvardin_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_farvardin()
        Dim insert As String = "insert into mony_incoming_farvardin(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_farvardin)

        connect_m_i_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_i_farvardin.Close()

        database_show_m_i_farvardin()

    End Sub
    Sub database_delete_m_i_farvardin()
        Dim delete As String = "delete from mony_incoming_farvardin where id=" & mony_incoming_farvardin_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_farvardin)
        connect_m_i_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_i_farvardin.Close()
        database_show_m_i_farvardin()
    End Sub
    Sub database_edit_m_i_farvardin()
        Dim edit As String = "update mony_incoming_farvardin set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_farvardin)
        connect_m_i_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_i_farvardin.Close()
        database_show_m_i_farvardin()
    End Sub
    Sub database_search_m_i_farvardin()
        Dim searchQuery As String = ("SELECT * From mony_incoming_farvardin WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_farvardin)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_farvardin_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_ordibehesht()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_ordibehesht", connect_m_i_ordibehesht)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_ordibehesht_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_ordibehesht()
        Dim insert As String = "insert into mony_incoming_ordibehesht(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_ordibehesht)

        connect_m_i_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_i_ordibehesht.Close()

        database_show_m_i_ordibehesht()

    End Sub
    Sub database_delete_m_i_ordibehesht()
        Dim delete As String = "delete from mony_incoming_ordibehesht where id=" & mony_incoming_ordibehesht_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_ordibehesht)
        connect_m_i_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_i_ordibehesht.Close()
        database_show_m_i_ordibehesht()
    End Sub
    Sub database_edit_m_i_ordibehesht()
        Dim edit As String = "update mony_incoming_ordibehesht set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_ordibehesht)
        connect_m_i_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_i_ordibehesht.Close()
        database_show_m_i_ordibehesht()
    End Sub
    Sub database_search_m_i_ordibehesht()
        Dim searchQuery As String = ("SELECT * From mony_incoming_ordibehesht WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_ordibehesht)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_ordibehesht_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_khordad()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_khordad", connect_m_i_khordad)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_khordad_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_khordad()
        Dim insert As String = "insert into mony_incoming_khordad(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_khordad)

        connect_m_i_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_khordad.Close()

        database_show_m_i_khordad()

    End Sub
    Sub database_delete_m_i_khordad()
        Dim delete As String = "delete from mony_incoming_khordad where id=" & mony_incoming_khordad_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_khordad)
        connect_m_i_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_khordad.Close()
        database_show_m_i_khordad()
    End Sub
    Sub database_edit_m_i_khordad()
        Dim edit As String = "update mony_incoming_khordad set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_khordad)
        connect_m_i_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_khordad.Close()
        database_show_m_i_khordad()
    End Sub
    Sub database_search_m_i_khordad()
        Dim searchQuery As String = ("SELECT * From mony_incoming_khordad WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_khordad)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_khordad_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_tir()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_tir", connect_m_i_tir)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_tir_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_tir()
        Dim insert As String = "insert into mony_incoming_tir(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_tir)

        connect_m_i_tir.Open()
        run.ExecuteNonQuery()
        connect_m_i_tir.Close()

        database_show_m_i_tir()

    End Sub
    Sub database_delete_m_i_tir()
        Dim delete As String = "delete from mony_incoming_tir where id=" & mony_incoming_tir_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_tir)
        connect_m_i_tir.Open()
        run.ExecuteNonQuery()
        connect_m_i_tir.Close()
        database_show_m_i_tir()
    End Sub
    Sub database_edit_m_i_tir()
        Dim edit As String = "update mony_incoming_tir set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_tir)
        connect_m_i_tir.Open()
        run.ExecuteNonQuery()
        connect_m_i_tir.Close()
        database_show_m_i_tir()
    End Sub
    Sub database_search_m_i_tir()
        Dim searchQuery As String = ("SELECT * From mony_incoming_tir WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_tir)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_tir_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_mordad()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_mordad", connect_m_i_mordad)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_mordad_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_mordad()
        Dim insert As String = "insert into mony_incoming_mordad(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_mordad)

        connect_m_i_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_mordad.Close()

        database_show_m_i_mordad()

    End Sub
    Sub database_delete_m_i_mordad()
        Dim delete As String = "delete from mony_incoming_mordad where id=" & mony_incoming_mordad_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_mordad)
        connect_m_i_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_mordad.Close()
        database_show_m_i_mordad()
    End Sub
    Sub database_edit_m_i_mordad()
        Dim edit As String = "update mony_incoming_mordad set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_mordad)
        connect_m_i_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_i_mordad.Close()
        database_show_m_i_mordad()
    End Sub
    Sub database_search_m_i_mordad()
        Dim searchQuery As String = ("SELECT * From mony_incoming_mordad WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_mordad)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_mordad_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_shahrivar()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_shahrivar", connect_m_i_shahrivar)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_shahrivar_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_shahrivar()
        Dim insert As String = "insert into mony_incoming_shahrivar(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_shahrivar)

        connect_m_i_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_i_shahrivar.Close()

        database_show_m_i_shahrivar()

    End Sub
    Sub database_delete_m_i_shahrivar()
        Dim delete As String = "delete from mony_incoming_shahrivar where id=" & mony_incoming_shahrivar_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_shahrivar)
        connect_m_i_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_i_shahrivar.Close()
        database_show_m_i_shahrivar()
    End Sub
    Sub database_edit_m_i_shahrivar()
        Dim edit As String = "update mony_incoming_shahrivar set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_shahrivar)
        connect_m_i_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_i_shahrivar.Close()
        database_show_m_i_shahrivar()
    End Sub
    Sub database_search_m_i_shahrivar()
        Dim searchQuery As String = ("SELECT * From mony_incoming_shahrivar WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_shahrivar)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_shahrivar_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_mehr()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_mehr", connect_m_i_mehr)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_mehr_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_mehr()
        Dim insert As String = "insert into mony_incoming_mehr(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_mehr)

        connect_m_i_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_i_mehr.Close()

        database_show_m_i_mehr()

    End Sub
    Sub database_delete_m_i_mehr()
        Dim delete As String = "delete from mony_incoming_mehr where id=" & mony_incoming_mehr_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_mehr)
        connect_m_i_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_i_mehr.Close()
        database_show_m_i_mehr()
    End Sub
    Sub database_edit_m_i_mehr()
        Dim edit As String = "update mony_incoming_mehr set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_mehr)
        connect_m_i_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_i_mehr.Close()
        database_show_m_i_mehr()
    End Sub
    Sub database_search_m_i_mehr()
        Dim searchQuery As String = ("SELECT * From mony_incoming_mehr WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_mehr)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_mehr_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_aban()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_aban", connect_m_i_aban)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_aban_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_aban()
        Dim insert As String = "insert into mony_incoming_aban(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_aban)

        connect_m_i_aban.Open()
        run.ExecuteNonQuery()
        connect_m_i_aban.Close()

        database_show_m_i_aban()

    End Sub
    Sub database_delete_m_i_aban()
        Dim delete As String = "delete from mony_incoming_aban where id=" & mony_incoming_aban_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_aban)
        connect_m_i_aban.Open()
        run.ExecuteNonQuery()
        connect_m_i_aban.Close()
        database_show_m_i_aban()
    End Sub
    Sub database_edit_m_i_aban()
        Dim edit As String = "update mony_incoming_aban set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_aban)
        connect_m_i_aban.Open()
        run.ExecuteNonQuery()
        connect_m_i_aban.Close()
        database_show_m_i_aban()
    End Sub
    Sub database_search_m_i_aban()
        Dim searchQuery As String = ("SELECT * From mony_incoming_aban WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_aban)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_aban_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_azar()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_azar", connect_m_i_azar)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_azar_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_azar()
        Dim insert As String = "insert into mony_incoming_azar(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_azar)

        connect_m_i_azar.Open()
        run.ExecuteNonQuery()
        connect_m_i_azar.Close()

        database_show_m_i_azar()

    End Sub
    Sub database_delete_m_i_azar()
        Dim delete As String = "delete from mony_incoming_azar where id=" & mony_incoming_azar_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_azar)
        connect_m_i_azar.Open()
        run.ExecuteNonQuery()
        connect_m_i_azar.Close()
        database_show_m_i_azar()
    End Sub
    Sub database_edit_m_i_azar()
        Dim edit As String = "update mony_incoming_azar set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_azar)
        connect_m_i_azar.Open()
        run.ExecuteNonQuery()
        connect_m_i_azar.Close()
        database_show_m_i_azar()
    End Sub
    Sub database_search_m_i_azar()
        Dim searchQuery As String = ("SELECT * From mony_incoming_azar WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_azar)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_azar_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_dey()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_dey", connect_m_i_dey)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_dey_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_dey()
        Dim insert As String = "insert into mony_incoming_dey(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_dey)

        connect_m_i_dey.Open()
        run.ExecuteNonQuery()
        connect_m_i_dey.Close()

        database_show_m_i_dey()

    End Sub
    Sub database_delete_m_i_dey()
        Dim delete As String = "delete from mony_incoming_dey where id=" & mony_incoming_dey_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_dey)
        connect_m_i_dey.Open()
        run.ExecuteNonQuery()
        connect_m_i_dey.Close()
        database_show_m_i_dey()
    End Sub
    Sub database_edit_m_i_dey()
        Dim edit As String = "update mony_incoming_dey set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_dey)
        connect_m_i_dey.Open()
        run.ExecuteNonQuery()
        connect_m_i_dey.Close()
        database_show_m_i_dey()
    End Sub
    Sub database_search_m_i_dey()
        Dim searchQuery As String = ("SELECT * From mony_incoming_dey WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_dey)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_dey_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_bahman()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_bahman", connect_m_i_bahman)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_bahman_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_bahman()
        Dim insert As String = "insert into mony_incoming_bahman(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_bahman)

        connect_m_i_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_i_bahman.Close()

        database_show_m_i_bahman()

    End Sub
    Sub database_delete_m_i_bahman()
        Dim delete As String = "delete from mony_incoming_bahman where id=" & mony_incoming_bahman_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_bahman)
        connect_m_i_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_i_bahman.Close()
        database_show_m_i_bahman()
    End Sub
    Sub database_edit_m_i_bahman()
        Dim edit As String = "update mony_incoming_bahman set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_bahman)
        connect_m_i_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_i_bahman.Close()
        database_show_m_i_bahman()
    End Sub
    Sub database_search_m_i_bahman()
        Dim searchQuery As String = ("SELECT * From mony_incoming_bahman WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_bahman)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_bahman_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_i_esfand()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_incoming_esfand", connect_m_i_esfand)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_esfand_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_i_esfand()
        Dim insert As String = "insert into mony_incoming_esfand(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_i_esfand)

        connect_m_i_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_i_esfand.Close()

        database_show_m_i_esfand()

    End Sub
    Sub database_delete_m_i_esfand()
        Dim delete As String = "delete from mony_incoming_esfand where id=" & mony_incoming_esfand_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_i_esfand)
        connect_m_i_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_i_esfand.Close()
        database_show_m_i_esfand()
    End Sub
    Sub database_edit_m_i_esfand()
        Dim edit As String = "update mony_incoming_esfand set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_i_esfand)
        connect_m_i_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_i_esfand.Close()
        database_show_m_i_esfand()
    End Sub
    Sub database_search_m_i_esfand()
        Dim searchQuery As String = ("SELECT * From mony_incoming_esfand WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_i_esfand)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_incoming_esfand_DataGridView.DataSource = DataTable
    End Sub



    Sub database_show_m_o_farvardin()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_farvardin", connect_m_o_farvardin)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_farvardin_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_farvardin()
        Dim insert As String = "insert into mony_Output_farvardin(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_farvardin)

        connect_m_o_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_o_farvardin.Close()

        database_show_m_o_farvardin()

    End Sub
    Sub database_delete_m_o_farvardin()
        Dim delete As String = "delete from mony_Output_farvardin where id=" & mony_Output_farvardin_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_farvardin)
        connect_m_o_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_o_farvardin.Close()
        database_show_m_o_farvardin()
    End Sub
    Sub database_edit_m_o_farvardin()
        Dim edit As String = "update mony_Output_farvardin set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_farvardin)
        connect_m_o_farvardin.Open()
        run.ExecuteNonQuery()
        connect_m_o_farvardin.Close()
        database_show_m_o_farvardin()
    End Sub
    Sub database_search_m_o_farvardin()
        Dim searchQuery As String = ("SELECT * From mony_Output_farvardin WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_farvardin)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_farvardin_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_ordibehesht()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_ordibehesht", connect_m_o_ordibehesht)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_ordibehesht_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_ordibehesht()
        Dim insert As String = "insert into mony_Output_ordibehesht(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_ordibehesht)

        connect_m_o_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_o_ordibehesht.Close()

        database_show_m_o_ordibehesht()

    End Sub
    Sub database_delete_m_o_ordibehesht()
        Dim delete As String = "delete from mony_Output_ordibehesht where id=" & mony_Output_ordibehesht_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_ordibehesht)
        connect_m_o_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_o_ordibehesht.Close()
        database_show_m_o_ordibehesht()
    End Sub
    Sub database_edit_m_o_ordibehesht()
        Dim edit As String = "update mony_Output_ordibehesht set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_ordibehesht)
        connect_m_o_ordibehesht.Open()
        run.ExecuteNonQuery()
        connect_m_o_ordibehesht.Close()
        database_show_m_o_ordibehesht()
    End Sub
    Sub database_search_m_o_ordibehesht()
        Dim searchQuery As String = ("SELECT * From mony_Output_ordibehesht WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_ordibehesht)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_ordibehesht_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_khordad()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_khordad", connect_m_o_khordad)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_khordad_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_khordad()
        Dim insert As String = "insert into mony_Output_khordad(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_khordad)

        connect_m_o_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_khordad.Close()

        database_show_m_o_khordad()

    End Sub
    Sub database_delete_m_o_khordad()
        Dim delete As String = "delete from mony_Output_khordad where id=" & mony_Output_khordad_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_khordad)
        connect_m_o_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_khordad.Close()
        database_show_m_o_khordad()
    End Sub
    Sub database_edit_m_o_khordad()
        Dim edit As String = "update mony_Output_khordad set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_khordad)
        connect_m_o_khordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_khordad.Close()
        database_show_m_o_khordad()
    End Sub
    Sub database_search_m_o_khordad()
        Dim searchQuery As String = ("SELECT * From mony_Output_khordad WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_khordad)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_khordad_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_tir()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_tir", connect_m_o_tir)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_tir_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_tir()
        Dim insert As String = "insert into mony_Output_tir(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_tir)

        connect_m_o_tir.Open()
        run.ExecuteNonQuery()
        connect_m_o_tir.Close()

        database_show_m_o_tir()

    End Sub
    Sub database_delete_m_o_tir()
        Dim delete As String = "delete from mony_Output_tir where id=" & mony_Output_tir_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_tir)
        connect_m_o_tir.Open()
        run.ExecuteNonQuery()
        connect_m_o_tir.Close()
        database_show_m_o_tir()
    End Sub
    Sub database_edit_m_o_tir()
        Dim edit As String = "update mony_Output_tir set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_tir)
        connect_m_o_tir.Open()
        run.ExecuteNonQuery()
        connect_m_o_tir.Close()
        database_show_m_o_tir()
    End Sub
    Sub database_search_m_o_tir()
        Dim searchQuery As String = ("SELECT * From mony_Output_tir WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_tir)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_tir_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_mordad()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_mordad", connect_m_o_mordad)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_mordad_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_mordad()
        Dim insert As String = "insert into mony_Output_mordad(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_mordad)

        connect_m_o_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_mordad.Close()

        database_show_m_o_mordad()

    End Sub
    Sub database_delete_m_o_mordad()
        Dim delete As String = "delete from mony_Output_mordad where id=" & mony_Output_mordad_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_mordad)
        connect_m_o_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_mordad.Close()
        database_show_m_o_mordad()
    End Sub
    Sub database_edit_m_o_mordad()
        Dim edit As String = "update mony_Output_mordad set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_mordad)
        connect_m_o_mordad.Open()
        run.ExecuteNonQuery()
        connect_m_o_mordad.Close()
        database_show_m_o_mordad()
    End Sub
    Sub database_search_m_o_mordad()
        Dim searchQuery As String = ("SELECT * From mony_Output_mordad WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_mordad)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_mordad_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_shahrivar()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_shahrivar", connect_m_o_shahrivar)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_shahrivar_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_shahrivar()
        Dim insert As String = "insert into mony_Output_shahrivar(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_shahrivar)

        connect_m_o_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_o_shahrivar.Close()

        database_show_m_o_shahrivar()

    End Sub
    Sub database_delete_m_o_shahrivar()
        Dim delete As String = "delete from mony_Output_shahrivar where id=" & mony_Output_shahrivar_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_shahrivar)
        connect_m_o_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_o_shahrivar.Close()
        database_show_m_o_shahrivar()
    End Sub
    Sub database_edit_m_o_shahrivar()
        Dim edit As String = "update mony_Output_shahrivar set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_shahrivar)
        connect_m_o_shahrivar.Open()
        run.ExecuteNonQuery()
        connect_m_o_shahrivar.Close()
        database_show_m_o_shahrivar()
    End Sub
    Sub database_search_m_o_shahrivar()
        Dim searchQuery As String = ("SELECT * From mony_Output_shahrivar WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_shahrivar)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_shahrivar_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_mehr()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_mehr", connect_m_o_mehr)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_mehr_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_mehr()
        Dim insert As String = "insert into mony_Output_mehr(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_mehr)

        connect_m_o_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_o_mehr.Close()

        database_show_m_o_mehr()

    End Sub
    Sub database_delete_m_o_mehr()
        Dim delete As String = "delete from mony_Output_mehr where id=" & mony_Output_mehr_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_mehr)
        connect_m_o_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_o_mehr.Close()
        database_show_m_o_mehr()
    End Sub
    Sub database_edit_m_o_mehr()
        Dim edit As String = "update mony_Output_mehr set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_mehr)
        connect_m_o_mehr.Open()
        run.ExecuteNonQuery()
        connect_m_o_mehr.Close()
        database_show_m_o_mehr()
    End Sub
    Sub database_search_m_o_mehr()
        Dim searchQuery As String = ("SELECT * From mony_Output_mehr WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_mehr)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_mehr_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_aban()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_aban", connect_m_o_aban)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_aban_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_aban()
        Dim insert As String = "insert into mony_Output_aban(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_aban)

        connect_m_o_aban.Open()
        run.ExecuteNonQuery()
        connect_m_o_aban.Close()

        database_show_m_o_aban()

    End Sub
    Sub database_delete_m_o_aban()
        Dim delete As String = "delete from mony_Output_aban where id=" & mony_Output_aban_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_aban)
        connect_m_o_aban.Open()
        run.ExecuteNonQuery()
        connect_m_o_aban.Close()
        database_show_m_o_aban()
    End Sub
    Sub database_edit_m_o_aban()
        Dim edit As String = "update mony_Output_aban set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_aban)
        connect_m_o_aban.Open()
        run.ExecuteNonQuery()
        connect_m_o_aban.Close()
        database_show_m_o_aban()
    End Sub
    Sub database_search_m_o_aban()
        Dim searchQuery As String = ("SELECT * From mony_Output_aban WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_aban)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_aban_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_azar()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_azar", connect_m_o_azar)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_azar_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_azar()
        Dim insert As String = "insert into mony_Output_azar(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_azar)

        connect_m_o_azar.Open()
        run.ExecuteNonQuery()
        connect_m_o_azar.Close()

        database_show_m_o_azar()

    End Sub
    Sub database_delete_m_o_azar()
        Dim delete As String = "delete from mony_Output_azar where id=" & mony_Output_azar_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_azar)
        connect_m_o_azar.Open()
        run.ExecuteNonQuery()
        connect_m_o_azar.Close()
        database_show_m_o_azar()
    End Sub
    Sub database_edit_m_o_azar()
        Dim edit As String = "update mony_Output_azar set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_azar)
        connect_m_o_azar.Open()
        run.ExecuteNonQuery()
        connect_m_o_azar.Close()
        database_show_m_o_azar()
    End Sub
    Sub database_search_m_o_azar()
        Dim searchQuery As String = ("SELECT * From mony_Output_azar WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_azar)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_azar_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_dey()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_dey", connect_m_o_dey)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_dey_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_dey()
        Dim insert As String = "insert into mony_Output_dey(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_dey)

        connect_m_o_dey.Open()
        run.ExecuteNonQuery()
        connect_m_o_dey.Close()

        database_show_m_o_dey()

    End Sub
    Sub database_delete_m_o_dey()
        Dim delete As String = "delete from mony_Output_dey where id=" & mony_Output_dey_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_dey)
        connect_m_o_dey.Open()
        run.ExecuteNonQuery()
        connect_m_o_dey.Close()
        database_show_m_o_dey()
    End Sub
    Sub database_edit_m_o_dey()
        Dim edit As String = "update mony_Output_dey set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_dey)
        connect_m_o_dey.Open()
        run.ExecuteNonQuery()
        connect_m_o_dey.Close()
        database_show_m_o_dey()
    End Sub
    Sub database_search_m_o_dey()
        Dim searchQuery As String = ("SELECT * From mony_Output_dey WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_dey)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_dey_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_bahman()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_bahman", connect_m_o_bahman)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_bahman_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_bahman()
        Dim insert As String = "insert into mony_Output_bahman(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_bahman)

        connect_m_o_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_o_bahman.Close()

        database_show_m_o_bahman()

    End Sub
    Sub database_delete_m_o_bahman()
        Dim delete As String = "delete from mony_Output_bahman where id=" & mony_Output_bahman_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_bahman)
        connect_m_o_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_o_bahman.Close()
        database_show_m_o_bahman()
    End Sub
    Sub database_edit_m_o_bahman()
        Dim edit As String = "update mony_Output_bahman set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_bahman)
        connect_m_o_bahman.Open()
        run.ExecuteNonQuery()
        connect_m_o_bahman.Close()
        database_show_m_o_bahman()
    End Sub
    Sub database_search_m_o_bahman()
        Dim searchQuery As String = ("SELECT * From mony_Output_bahman WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_bahman)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_bahman_DataGridView.DataSource = DataTable
    End Sub

    Sub database_show_m_o_esfand()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from mony_Output_esfand", connect_m_o_esfand)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_esfand_DataGridView.DataSource = DataTable
    End Sub
    Sub database_add_m_o_esfand()
        Dim insert As String = "insert into mony_Output_esfand(amount,person,forr,data,time) values (N'" & TextBox_Accounting_money_add_1.Text & "',N'" & TextBox_Accounting_money_add_2.Text & "',N'" & TextBox_Accounting_money_add_3.Text & "',N'" & PersianCalendar.GetDayOfMonth(Now()).ToString & "/" & PersianCalendar.GetMonth(Now()).ToString & "/" & PersianCalendar.GetYear(Now()).ToString & "',N'" & Now.Hour.ToString & ":" & Now.Minute.ToString & ":" & Now.Second.ToString & "')"
        Dim run As SqlCommand = New SqlCommand(insert, connect_m_o_esfand)

        connect_m_o_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_o_esfand.Close()

        database_show_m_o_esfand()

    End Sub
    Sub database_delete_m_o_esfand()
        Dim delete As String = "delete from mony_Output_esfand where id=" & mony_Output_esfand_DataGridView.CurrentRow.Cells(0).Value
        Dim run As SqlCommand = New SqlCommand(delete, connect_m_o_esfand)
        connect_m_o_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_o_esfand.Close()
        database_show_m_o_esfand()
    End Sub
    Sub database_edit_m_o_esfand()
        Dim edit As String = "update mony_Output_esfand set amount=N'" & TextBox_Accounting_money_add_1.Text & "',person=N'" & TextBox_Accounting_money_add_2.Text & "',forr=N'" & TextBox_Accounting_money_add_3.Text & "' where id=" & save_ID_number
        Dim run As SqlCommand = New SqlCommand(edit, connect_m_o_esfand)
        connect_m_o_esfand.Open()
        run.ExecuteNonQuery()
        connect_m_o_esfand.Close()
        database_show_m_o_esfand()
    End Sub
    Sub database_search_m_o_esfand()
        Dim searchQuery As String = ("SELECT * From mony_Output_esfand WHERE CONCAT(id,amount,person,forr,data,time) like N'%" & TextBox_search.Text & "%'")
        Dim command As New SqlCommand(searchQuery, connect_m_o_esfand)
        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
        Dim DataTable As New DataTable
        da.Fill(DataTable)
        mony_Output_esfand_DataGridView.DataSource = DataTable
    End Sub






    Sub GridColor(ByVal GridControl As DataGridView)

        For i = 0 To GridControl.RowCount - 1
            Dim a As Integer = i Mod 2
            If (i Mod 2) = 0 Then

                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.FromArgb(180, 250, 250)
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black
                Next
            Else
                For j = 0 To GridControl.ColumnCount - 1
                    GridControl.Rows.Item(i).Cells.Item(j).Style.BackColor = Color.LightCyan
                    GridControl.Rows.Item(i).Cells.Item(j).Style.ForeColor = Color.Black

                Next
            End If
        Next

    End Sub

    Sub level_test_number_change()
        Select Case Label_l_t_number.Text
            Case 1
                Label_l_t_number.Text = 2
            Case 2
                Label_l_t_number.Text = 3
            Case 3
                Label_l_t_number.Text = 4
            Case 4
                Label_l_t_number.Text = 5
            Case 5
                Label_l_t_number.Text = 6
            Case 6
                Label_l_t_number.Text = 7
            Case 7
                Label_l_t_number.Text = 8
            Case 8
                Label_l_t_number.Text = 9
            Case 9
                Label_l_t_number.Text = 10
            Case 10
                Label_l_t_number.Text = 11
            Case 11
                Label_l_t_number.Text = 12
            Case 12
                Label_l_t_number.Text = 13
            Case 13
                Label_l_t_number.Text = 14
            Case 14
                Label_l_t_number.Text = 15
            Case 15
                Label_l_t_number.Text = 16
            Case 16
                Label_l_t_number.Text = 17
            Case 17
                Label_l_t_number.Text = 18
            Case 18
                Label_l_t_number.Text = 19
            Case 19
                Label_l_t_number.Text = 20
            Case 20
                Label_l_t_number.Text = 21
            Case 21
                Label_l_t_number.Text = 22
            Case 22
                Label_l_t_number.Text = 23
            Case 23
                Label_l_t_number.Text = 24
            Case 24
                Label_l_t_number.Text = 25
        End Select
    End Sub
    Sub level_test_q_a()
        Label_l_t_answer_1.ForeColor = Color.Black
        Label_l_t_answer_2.ForeColor = Color.Black
        Label_l_t_answer_3.ForeColor = Color.Black
        Label_l_t_answer_4.ForeColor = Color.Black


        Select Case Label_l_t_number.Text
            Case "1"
                Label_l_t_question.Text = "1. When can we meet again?"
                Label_l_t_answer_1.Text = "When are you free?"
                Label_l_t_answer_2.Text = "It was two days ago."
                Label_l_t_answer_3.Text = "Can you help me?"
                Label_l_t_answer_4.Text = ""
            Case "2"
                Label_l_t_question.Text = "2. My aunt is going to stay with me."
                Label_l_t_answer_1.Text = "How do you do?"
                Label_l_t_answer_2.Text = "How long for?"
                Label_l_t_answer_3.Text = "How was it?"
                Label_l_t_answer_4.Text = ""
            Case "3"
                Label_l_t_question.Text = "3. When do you study?"
                Label_l_t_answer_1.Text = "at school"
                Label_l_t_answer_2.Text = "in the evenings"
                Label_l_t_answer_3.Text = "in the library"
                Label_l_t_answer_4.Text = ""
            Case "4"
                Label_l_t_question.Text = "4. Would you prefer lemonade or orange juice?"
                Label_l_t_answer_1.Text = "Have you got anything else?"
                Label_l_t_answer_2.Text = "If you like."
                Label_l_t_answer_3.Text = "Are you sure about that?"
                Label_l_t_answer_4.Text = ""
            Case "5"
                Label_l_t_question.Text = "5. Let’s have dinner now."
                Label_l_t_answer_1.Text = "You aren't eating."
                Label_l_t_answer_2.Text = "There aren't any."
                Label_l_t_answer_3.Text = "Tom isn't here yet"
                Label_l_t_answer_4.Text = ""
            Case "6"
                Label_l_t_question.Text = "6. The snow was …… heavily when I left the house."
                Label_l_t_answer_1.Text = "dropping"
                Label_l_t_answer_2.Text = "landing"
                Label_l_t_answer_3.Text = "falling"
                Label_l_t_answer_4.Text = "descending"
            Case "7"
                Label_l_t_question.Text = "7. I can’t find my keys anywhere – I …… have left them at work."
                Label_l_t_answer_1.Text = "can"
                Label_l_t_answer_2.Text = "must"
                Label_l_t_answer_3.Text = "ought"
                Label_l_t_answer_4.Text = "would"
            Case "8"
                Label_l_t_question.Text = "8. When a car pulled out in front of her, Jane did well not to …… control of her bicycle."
                Label_l_t_answer_1.Text = "miss"
                Label_l_t_answer_2.Text = "lose"
                Label_l_t_answer_3.Text = "fail"
                Label_l_t_answer_4.Text = "drop"
            Case "9"
                Label_l_t_question.Text = "9. According to Richard’s …… the train leaves at 7 o’clock."
                Label_l_t_answer_1.Text = "opinion"
                Label_l_t_answer_2.Text = "advice"
                Label_l_t_answer_3.Text = "knowledge"
                Label_l_t_answer_4.Text = "information"
            Case "10"
                Label_l_t_question.Text = "10. When you stay in a country for some time you get used to the persons’s …… of life."
                Label_l_t_answer_1.Text = "habit"
                Label_l_t_answer_2.Text = "custom"
                Label_l_t_answer_3.Text = "way"
                Label_l_t_answer_4.Text = "system"
            Case "11"
                Label_l_t_question.Text = "11. The builders are …… good progress with the new house."
                Label_l_t_answer_1.Text = "getting"
                Label_l_t_answer_2.Text = "doing"
                Label_l_t_answer_3.Text = "making"
                Label_l_t_answer_4.Text = "taking"
            Case "12"
                Label_l_t_question.Text = "12. She is now taking a more positive …… to her studies and should do well."
                Label_l_t_answer_1.Text = "attitude"
                Label_l_t_answer_2.Text = "behavior"
                Label_l_t_answer_3.Text = "manner"
                Label_l_t_answer_4.Text = "style"
            Case "13"
                Label_l_t_question.Text = "13. My father …… his new car for two weeks now."
                Label_l_t_answer_1.Text = "has had"
                Label_l_t_answer_2.Text = "has"
                Label_l_t_answer_3.Text = "is having"
                Label_l_t_answer_4.Text = "had"
            Case "14"
                Label_l_t_question.Text = "14. What differences are there …… the English spoken in the UK and the English spoken in the US?"
                Label_l_t_answer_1.Text = "among"
                Label_l_t_answer_2.Text = "between"
                Label_l_t_answer_3.Text = "beside"
                Label_l_t_answer_4.Text = "with"
            Case "15"
                Label_l_t_question.Text = "15. At 6 p.m. I started to get angry with him because he was late ……"
                Label_l_t_answer_1.Text = "as usual."
                Label_l_t_answer_2.Text = "In total."
                Label_l_t_answer_3.Text = "typically."
                Label_l_t_answer_4.Text = "usually."
            Case "16"
                Label_l_t_question.Text = "16. …… you get your father’s permission, I’ll take you skiing next weekend."
                Label_l_t_answer_1.Text = "Although"
                Label_l_t_answer_2.Text = "provided"
                Label_l_t_answer_3.Text = "as"
                Label_l_t_answer_4.Text = "unless"
            Case "17"
                Label_l_t_question.Text = "17. A local company has agreed to …… the school team with football shirts."
                Label_l_t_answer_1.Text = "contribute"
                Label_l_t_answer_2.Text = "supply"
                Label_l_t_answer_3.Text = "give"
                Label_l_t_answer_4.Text = "produce"
            Case "18"
                Label_l_t_question.Text = "18. I really enjoy stories that are …… in the distant future."
                Label_l_t_answer_1.Text = "found"
                Label_l_t_answer_2.Text = "set"
                Label_l_t_answer_3.Text = "put"
                Label_l_t_answer_4.Text = "placed"
            Case "19"
                Label_l_t_question.Text = "19. That old saucepan will come in …… when we go camping."
                Label_l_t_answer_1.Text = "convenient"
                Label_l_t_answer_2.Text = "fitting"
                Label_l_t_answer_3.Text = "handy"
                Label_l_t_answer_4.Text = "suitable"
            Case "20"
                Label_l_t_question.Text = "20. Anyone …… after the start of the play is not allowed in until the interval."
                Label_l_t_answer_1.Text = "arrives"
                Label_l_t_answer_2.Text = "has arrived"
                Label_l_t_answer_3.Text = "arriving"
                Label_l_t_answer_4.Text = "arrived"
            Case "21"
                Label_l_t_question.Text = "21. I didn’t …… driving home in the storm so I stayed overnight in a hotel."
                Label_l_t_answer_1.Text = "fancy"
                Label_l_t_answer_2.Text = "desire"
                Label_l_t_answer_3.Text = "prefer"
                Label_l_t_answer_4.Text = "want"
            Case "22"
                Label_l_t_question.Text = "22. The judge said that those prepared to…… in crime must be ready to suffer the consequences."
                Label_l_t_answer_1.Text = "involve"
                Label_l_t_answer_2.Text = "engage"
                Label_l_t_answer_3.Text = "undertake"
                Label_l_t_answer_4.Text = "enlist"
            Case "23"
                Label_l_t_question.Text = "23. Marianne seemed to take …… at my comments on her work."
                Label_l_t_answer_1.Text = "annoyance"
                Label_l_t_answer_2.Text = "insult"
                Label_l_t_answer_3.Text = "offense"
                Label_l_t_answer_4.Text = "indignation"
            Case "24"
                Label_l_t_question.Text = "24. You should not have a dog if you are not …… to look after it."
                Label_l_t_answer_1.Text = "prepared"
                Label_l_t_answer_2.Text = "adopted"
                Label_l_t_answer_3.Text = "arranged"
                Label_l_t_answer_4.Text = "decided"
            Case "25"
                Label_l_t_question.Text = "25. The farmhouse was so isolated that they had to generate their own electricity ……"
                Label_l_t_answer_1.Text = "current."
                Label_l_t_answer_2.Text = "supply."
                Label_l_t_answer_3.Text = "grid."
                Label_l_t_answer_4.Text = "power."
        End Select

    End Sub
    Sub level_test_choose_answer()

        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Select Case Label_l_t_answer_1.ForeColor
                Case System.Drawing.Color.FromArgb(214, 0, 98)
                    Label_l_t_answer_1.Text = Label_l_t_answer_1.Text
                Case Color.Black
                    level_test_q_a()
            End Select
        Else
            If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_1.Text
                level_test_q_a()
                Label_l_t_answer_1.Text = Part_level_test_choose_answer
                Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_2.Text
                level_test_q_a()
                Label_l_t_answer_2.Text = Part_level_test_choose_answer
                Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_3.Text
                level_test_q_a()
                Label_l_t_answer_3.Text = Part_level_test_choose_answer
                Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_4.Text
                level_test_q_a()
                Label_l_t_answer_4.Text = Part_level_test_choose_answer
                Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
        End If





        If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Select Case Label_l_t_answer_2.ForeColor
                Case System.Drawing.Color.FromArgb(214, 0, 98)
                    Label_l_t_answer_2.Text = Label_l_t_answer_2.Text
                Case Color.Black
                    level_test_q_a()
            End Select
        Else
            If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_1.Text
                level_test_q_a()
                Label_l_t_answer_1.Text = Part_level_test_choose_answer
                Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_2.Text
                level_test_q_a()
                Label_l_t_answer_2.Text = Part_level_test_choose_answer
                Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_3.Text
                level_test_q_a()
                Label_l_t_answer_3.Text = Part_level_test_choose_answer
                Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_4.Text
                level_test_q_a()
                Label_l_t_answer_4.Text = Part_level_test_choose_answer
                Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
        End If






        If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Select Case Label_l_t_answer_3.ForeColor
                Case System.Drawing.Color.FromArgb(214, 0, 98)
                    Label_l_t_answer_3.Text = Label_l_t_answer_3.Text
                Case Color.Black
                    level_test_q_a()
            End Select
        Else
            If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_1.Text
                level_test_q_a()
                Label_l_t_answer_1.Text = Part_level_test_choose_answer
                Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_2.Text
                level_test_q_a()
                Label_l_t_answer_2.Text = Part_level_test_choose_answer
                Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_3.Text
                level_test_q_a()
                Label_l_t_answer_3.Text = Part_level_test_choose_answer
                Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_4.Text
                level_test_q_a()
                Label_l_t_answer_4.Text = Part_level_test_choose_answer
                Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
        End If






        If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Select Case Label_l_t_answer_4.ForeColor
                Case System.Drawing.Color.FromArgb(214, 0, 98)
                    Label_l_t_answer_4.Text = Label_l_t_answer_4.Text
                Case Color.Black
                    level_test_q_a()
            End Select
        Else
            If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_1.Text
                level_test_q_a()
                Label_l_t_answer_1.Text = Part_level_test_choose_answer
                Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_2.Text
                level_test_q_a()
                Label_l_t_answer_2.Text = Part_level_test_choose_answer
                Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_3.Text
                level_test_q_a()
                Label_l_t_answer_3.Text = Part_level_test_choose_answer
                Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
            If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_choose_answer = Label_l_t_answer_4.Text
                level_test_q_a()
                Label_l_t_answer_4.Text = Part_level_test_choose_answer
                Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
            End If
        End If

    End Sub
    Sub level_test_count_correct_a()
        Select Case Label_l_t_number.Text
            Case "1"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = 1
                End If
            Case "2"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "3"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "4"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "5"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "6"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "7"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "8"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "9"
                If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "10"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "11"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "12"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "13"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "14"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "15"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "16"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "17"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "18"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "19"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "20"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "21"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "22"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "23"
                If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "24"
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
            Case "25"
                If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_count_correct_answer = Part_level_test_count_correct_answer + 1
                End If
        End Select
    End Sub



    Sub load_app()
        '  MediaPlayer_music.URL = (Application.StartupPath & "music\Happy relaxing\2018-05-25_-_The_Quiet_Morning_-_David_Fesliyan.mp3")
        '
        '
        '
        ToolTip_main.IsBalloon = True
        '
        '
        Timer_lock_app.Interval = 1000
        '
        '
        Me.BackColor = Color.White
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_app_off
        PictureBox_app_off.BackgroundImage = Global.language_class.My.Resources.Resources.problem
        PictureBox_app_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_app_off.Location = New System.Drawing.Point(450, 60)
        PictureBox_app_off.Size = New System.Drawing.Size(100, 100)
        PictureBox_app_off.Visible = False
        '
        '
        'Label_1_app_off
        Label_1_app_off.AutoSize = False
        Label_1_app_off.Font = New System.Drawing.Font("B nazanin", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_1_app_off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_1_app_off.Location = New System.Drawing.Point(50, 180)
        Label_1_app_off.Size = New System.Drawing.Size(900, 90)
        Label_1_app_off.Visible = False
        '
        '
        'Label_2_app_off
        Label_2_app_off.AutoSize = False
        Label_2_app_off.Font = New System.Drawing.Font("Sylfaen", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_2_app_off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_2_app_off.ForeColor = Color.Red
        Label_2_app_off.Location = New System.Drawing.Point(50, 280)
        Label_2_app_off.Size = New System.Drawing.Size(900, 35)
        Label_2_app_off.Visible = False
        '
        '
        'TextBox_app_off
        TextBox_app_off.Location = New System.Drawing.Point(375.5, 400)
        TextBox_app_off.Size = New System.Drawing.Size(250, 30)
        TextBox_app_off.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_app_off.UseSystemPasswordChar = True
        TextBox_app_off.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_Timer_lock_app
        Label_Timer_lock_app.AutoSize = False
        Label_Timer_lock_app.Font = New System.Drawing.Font("Bauhaus 93", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Timer_lock_app.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Timer_lock_app.Location = New System.Drawing.Point(50, 170)
        Label_Timer_lock_app.Size = New System.Drawing.Size(900, 30)
        Label_Timer_lock_app.Visible = False
        '
        '
        'Label_password
        Label_password.AutoSize = False
        Label_password.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_password.Text = "رمز ورود را وارد کنید"
        Label_password.Location = New System.Drawing.Point(350, 210)
        Label_password.Size = New System.Drawing.Size(300, 30)
        Label_password.Visible = True
        '
        '
        'TextBox_password
        TextBox_password.Location = New System.Drawing.Point(375.5, 250)
        TextBox_password.Size = New System.Drawing.Size(250, 30)
        TextBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_password.UseSystemPasswordChar = True
        TextBox_password.Visible = True
        '
        '
        'PictureBox_password
        PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.lock
        PictureBox_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_password.Location = New System.Drawing.Point(475.5, 310)
        PictureBox_password.Size = New System.Drawing.Size(50, 50)
        PictureBox_password.Visible = True
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        TeachersDataGridView.Size = New System.Drawing.Size(984, 380)
        TeachersDataGridView.Location = New System.Drawing.Point(0, 100)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        StudentDataGridView.Size = New System.Drawing.Size(984, 380)
        StudentDataGridView.Location = New System.Drawing.Point(0, 100)
        '
        '
        '
        mony_incoming_farvardin_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_farvardin_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_ordibehesht_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_ordibehesht_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_khordad_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_khordad_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_tir_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_tir_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_mordad_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_mordad_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_shahrivar_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_shahrivar_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_mehr_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_mehr_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_aban_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_aban_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_azar_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_azar_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_dey_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_dey_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_bahman_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_bahman_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_incoming_esfand_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_incoming_esfand_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        '

        '
        mony_Output_farvardin_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_farvardin_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_ordibehesht_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_ordibehesht_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_khordad_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_khordad_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_tir_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_tir_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_mordad_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_mordad_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_shahrivar_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_shahrivar_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_mehr_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_mehr_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_aban_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_aban_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_azar_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_azar_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_dey_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_dey_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_bahman_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_bahman_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        mony_Output_esfand_DataGridView.Size = New System.Drawing.Size(984, 380)
        mony_Output_esfand_DataGridView.Location = New System.Drawing.Point(0, 100)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_home
        PictureBox_home.BackgroundImage = Global.language_class.My.Resources.Resources.social_care1
        PictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_home.Location = New System.Drawing.Point(350, 170)
        PictureBox_home.Size = New System.Drawing.Size(300, 300)
        PictureBox_home.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'label_title 
        Label_title.Text = "موسسه زبان هامون"
        Label_title.AutoSize = False
        Label_title.TextAlign = ContentAlignment.MiddleCenter
        Label_title.Font = New System.Drawing.Font("B Roya", 40.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_title.Location = New System.Drawing.Point(150, 0)
        Label_title.ForeColor = System.Drawing.Color.FromArgb(142, 0, 57)
        Label_title.Size = New System.Drawing.Size(700, 90)
        Label_title.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_more_students
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_more_students.Location = New System.Drawing.Point(755, 228)
        PictureBox_more_students.Size = New System.Drawing.Size(30, 30)
        ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
        PictureBox_more_students.Visible = False
        '
        '
        'PictureBox_more_teachers
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_more_teachers.Location = New System.Drawing.Point(755, 288)
        PictureBox_more_teachers.Size = New System.Drawing.Size(30, 30)
        ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        PictureBox_more_teachers.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'button_students
        Button_students.Text = " لیست دانش آموزان"
        Button_students.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_students.AutoSize = True
        Button_students.BackColor = System.Drawing.Color.FromArgb(214, 250, 63)
        Button_students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(129, 159, 0)
        Button_students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(129, 159, 0)
        Button_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_students.FlatAppearance.BorderSize = 0
        Button_students.Location = New System.Drawing.Point(0, 220)
        Button_students.Size = New System.Drawing.Size(200, 20)
        Button_students.UseVisualStyleBackColor = True
        Button_students.Visible = False
        '
        '
        'button_teachers
        Button_teachers.Text = "لیست معلم ها"
        Button_teachers.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_teachers.AutoSize = True
        Button_teachers.BackColor = System.Drawing.Color.FromArgb(214, 250, 63)
        Button_teachers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(129, 159, 0)
        Button_teachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(129, 159, 0)
        Button_teachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_teachers.FlatAppearance.BorderSize = 0
        Button_teachers.Location = New System.Drawing.Point(0, 280)
        Button_teachers.Size = New System.Drawing.Size(200, 20)
        Button_teachers.UseVisualStyleBackColor = True
        Button_teachers.Visible = False
        '
        '
        'button_add_s
        Button_add_s.Text = "ثبت نام دانش آموزان"
        Button_add_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_add_s.AutoSize = True
        Button_add_s.BackColor = System.Drawing.Color.FromArgb(53, 212, 160)
        Button_add_s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 170, 114)
        Button_add_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 170, 114)
        Button_add_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_add_s.FlatAppearance.BorderSize = 0
        Button_add_s.Location = New System.Drawing.Point(785, 220)
        Button_add_s.Size = New System.Drawing.Size(200, 20)
        Button_add_s.UseVisualStyleBackColor = True
        Button_add_s.Visible = False
        '
        '
        'button_edit_s
        Button_edit_s.Text = "ویرایش"
        Button_edit_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_edit_s.AutoSize = True
        Button_edit_s.BackColor = System.Drawing.Color.FromArgb(255, 178, 64)
        Button_edit_s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 153, 0)
        Button_edit_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 153, 0)
        Button_edit_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_edit_s.FlatAppearance.BorderSize = 0
        Button_edit_s.Location = New System.Drawing.Point(835, 170)
        Button_edit_s.Size = New System.Drawing.Size(150, 20)
        Button_edit_s.UseVisualStyleBackColor = True
        Button_edit_s.Visible = False
        '
        '
        'button_delete_s
        Button_delete_s.Text = "حذف"
        Button_delete_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_delete_s.AutoSize = True
        Button_delete_s.BackColor = System.Drawing.Color.FromArgb(245, 61, 104)
        Button_delete_s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(234, 0, 55)
        Button_delete_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(234, 0, 55)
        Button_delete_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_delete_s.FlatAppearance.BorderSize = 0
        Button_delete_s.Location = New System.Drawing.Point(885, 120)
        Button_delete_s.Size = New System.Drawing.Size(100, 20)
        Button_delete_s.UseVisualStyleBackColor = True
        Button_delete_s.Visible = False
        '
        '
        'button_add_t
        Button_add_t.Text = "ثبت نام معلم ها"
        Button_add_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_add_t.AutoSize = True
        Button_add_t.BackColor = System.Drawing.Color.FromArgb(53, 212, 160)
        Button_add_t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 170, 114)
        Button_add_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 170, 114)
        Button_add_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_add_t.FlatAppearance.BorderSize = 0
        Button_add_t.Location = New System.Drawing.Point(785, 280)
        Button_add_t.Size = New System.Drawing.Size(200, 20)
        Button_add_t.UseVisualStyleBackColor = True
        Button_add_t.Visible = False
        '
        '
        'button_edit_t
        Button_edit_t.Text = "ویرایش"
        Button_edit_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_edit_t.AutoSize = True
        Button_edit_t.BackColor = System.Drawing.Color.FromArgb(255, 178, 64)
        Button_edit_t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 153, 0)
        Button_edit_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 153, 0)
        Button_edit_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_edit_t.FlatAppearance.BorderSize = 0
        Button_edit_t.Location = New System.Drawing.Point(835, 330)
        Button_edit_t.Size = New System.Drawing.Size(150, 20)
        Button_edit_t.UseVisualStyleBackColor = True
        Button_edit_t.Visible = False
        '
        '
        'Button_delete_t
        Button_delete_t.Text = "حذف"
        Button_delete_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_delete_t.AutoSize = True
        Button_delete_t.BackColor = System.Drawing.Color.FromArgb(245, 61, 104)
        Button_delete_t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(234, 0, 55)
        Button_delete_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(234, 0, 55)
        Button_delete_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button_delete_t.FlatAppearance.BorderSize = 0
        Button_delete_t.Location = New System.Drawing.Point(885, 380)
        Button_delete_t.Size = New System.Drawing.Size(100, 20)
        Button_delete_t.UseVisualStyleBackColor = True
        Button_delete_t.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'Label_name_s
        Label_name_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_s.Location = New System.Drawing.Point(710, 35)
        Label_name_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_s.Size = New System.Drawing.Size(270, 35)
        Label_name_s.Text = "نام و نام خانوادگی دانش آموز:"
        Label_name_s.Visible = False
        '
        '
        'Label_name_father_s
        Label_name_father_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_father_s.Location = New System.Drawing.Point(710, 90)
        Label_name_father_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_father_s.Size = New System.Drawing.Size(270, 35)
        Label_name_father_s.Text = "نام و نام خانوادگی پدر:"
        Label_name_father_s.Visible = False
        '
        '
        'Label_name_mother_s
        Label_name_mother_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_mother_s.Location = New System.Drawing.Point(710, 145)
        Label_name_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_mother_s.Size = New System.Drawing.Size(270, 35)
        Label_name_mother_s.Text = "نام و نام خانوادگی مادر:"
        Label_name_mother_s.Visible = False
        '
        '
        'Label_phone_s
        Label_phone_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_s.Location = New System.Drawing.Point(710, 200)
        Label_phone_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_s.Size = New System.Drawing.Size(270, 35)
        Label_phone_s.Text = "تلفن همراه دانش آموز:"
        Label_phone_s.Visible = False
        '
        '
        'Label_phone_father_s
        Label_phone_father_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_father_s.Location = New System.Drawing.Point(710, 255)
        Label_phone_father_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_father_s.Size = New System.Drawing.Size(270, 35)
        Label_phone_father_s.Text = "تلفن همراه پدر:"
        Label_phone_father_s.Visible = False
        '
        '
        'Label_phone_mother_s
        Label_phone_mother_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_mother_s.Location = New System.Drawing.Point(710, 310)
        Label_phone_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_mother_s.Size = New System.Drawing.Size(270, 35)
        Label_phone_mother_s.Text = "تلفن همراه مادر:"
        Label_phone_mother_s.Visible = False
        '
        '
        'Label_telephone
        Label_telephone.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_telephone.Location = New System.Drawing.Point(710, 365)
        Label_telephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_telephone.Size = New System.Drawing.Size(270, 35)
        Label_telephone.Text = "تلفن منزل:"
        Label_telephone.Visible = False
        '
        '
        'Label_address
        Label_address.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_address.Location = New System.Drawing.Point(235, 35)
        Label_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_address.Size = New System.Drawing.Size(170, 35)
        Label_address.Text = "آدرس منزل:"
        Label_address.Visible = False
        '
        '
        'Label_date
        Label_date.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_date.Location = New System.Drawing.Point(235, 200)
        Label_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_date.Size = New System.Drawing.Size(170, 35)
        Label_date.Text = "تاریخ ثبت نام:"
        Label_date.Visible = False
        '
        '
        'Label_datebirth
        Label_datebirth.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_datebirth.Location = New System.Drawing.Point(235, 145)
        Label_datebirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_datebirth.Size = New System.Drawing.Size(170, 35)
        Label_datebirth.Text = "تاریخ تولد:"
        Label_datebirth.Visible = False
        '
        '
        'Label_codemeli_s
        Label_codemeli_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_codemeli_s.Location = New System.Drawing.Point(235, 90)
        Label_codemeli_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_codemeli_s.Size = New System.Drawing.Size(170, 35)
        Label_codemeli_s.Text = "کد ملی:"
        Label_codemeli_s.Visible = False
        '
        '
        'Label_level_s
        Label_level_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_level_s.Location = New System.Drawing.Point(235, 310)
        Label_level_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_level_s.Size = New System.Drawing.Size(170, 35)
        Label_level_s.Text = "سطح کتاب:"
        Label_level_s.Visible = False
        '
        '
        '
        Label_level_s_result.Location = New System.Drawing.Point(2000, 310)
        '
        '
        'Label_gender_s
        Label_gender_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_gender_s.Location = New System.Drawing.Point(235, 255)
        Label_gender_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_gender_s.Size = New System.Drawing.Size(170, 35)
        Label_gender_s.Text = "جنسیت:"
        Label_gender_s.Visible = False
        '
        '
        'Label_language_s_edit
        Label_language_s_edit.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_language_s_edit.Location = New System.Drawing.Point(235, 365)
        Label_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_language_s_edit.Size = New System.Drawing.Size(170, 35)
        Label_language_s_edit.Text = "زبان:"
        Label_language_s_edit.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'TextBox_name_s
        TextBox_name_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_s.Location = New System.Drawing.Point(500, 40)
        TextBox_name_s.Size = New System.Drawing.Size(200, 20)
        TextBox_name_s.MaxLength = 100
        TextBox_name_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_name_s.Visible = False
        '
        '
        'TextBox_name_father_s
        TextBox_name_father_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_father_s.Location = New System.Drawing.Point(500, 95)
        TextBox_name_father_s.Size = New System.Drawing.Size(200, 20)
        TextBox_name_father_s.MaxLength = 100
        TextBox_name_father_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_name_father_s.Visible = False
        '
        '
        'TextBox_name_mother_s
        TextBox_name_mother_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_mother_s.Location = New System.Drawing.Point(500, 150)
        TextBox_name_mother_s.Size = New System.Drawing.Size(200, 20)
        TextBox_name_mother_s.MaxLength = 100
        TextBox_name_mother_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_name_mother_s.Visible = False
        '
        '
        'TextBox_phone_s
        TextBox_phone_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_s.Location = New System.Drawing.Point(500, 205)
        TextBox_phone_s.Size = New System.Drawing.Size(200, 20)
        TextBox_phone_s.MaxLength = 11
        TextBox_phone_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_phone_s.Visible = False
        '
        '
        'TextBox_phone_father_s
        TextBox_phone_father_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_father_s.Location = New System.Drawing.Point(500, 260)
        TextBox_phone_father_s.Size = New System.Drawing.Size(200, 20)
        TextBox_phone_father_s.MaxLength = 11
        TextBox_phone_father_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_phone_father_s.Visible = False
        '
        '
        'TextBox_phone_mother_s
        TextBox_phone_mother_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_mother_s.Location = New System.Drawing.Point(500, 315)
        TextBox_phone_mother_s.Size = New System.Drawing.Size(200, 20)
        TextBox_phone_mother_s.MaxLength = 11
        TextBox_phone_mother_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_phone_mother_s.Visible = False
        '
        '
        'TextBox_telephone
        TextBox_telephone.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_telephone.Location = New System.Drawing.Point(500, 370)
        TextBox_telephone.Size = New System.Drawing.Size(200, 20)
        TextBox_telephone.MaxLength = 11
        TextBox_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_telephone.Visible = False
        '
        '
        'TextBox_address
        TextBox_address.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_address.Location = New System.Drawing.Point(35, 40)
        TextBox_address.Size = New System.Drawing.Size(200, 20)
        TextBox_address.MaxLength = 500
        TextBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_address.Visible = False
        '
        '
        'TextBox_codemeli_s
        TextBox_codemeli_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_codemeli_s.Location = New System.Drawing.Point(35, 95)
        TextBox_codemeli_s.Size = New System.Drawing.Size(200, 20)
        TextBox_codemeli_s.MaxLength = 10
        TextBox_codemeli_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_codemeli_s.Visible = False
        '
        '
        'TextBox_datebirth_s_year
        TextBox_datebirth_s_year.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_s_year.Location = New System.Drawing.Point(95, 150)
        TextBox_datebirth_s_year.Size = New System.Drawing.Size(50, 20)
        TextBox_datebirth_s_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_s_year.Text = "سال"
        TextBox_datebirth_s_year.MaxLength = 4
        TextBox_datebirth_s_year.ForeColor = Color.DarkRed
        TextBox_datebirth_s_year.Visible = False
        '
        '
        'TextBox_datebirth_s_month
        TextBox_datebirth_s_month.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_s_month.Location = New System.Drawing.Point(155, 150)
        TextBox_datebirth_s_month.Size = New System.Drawing.Size(35, 20)
        TextBox_datebirth_s_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_s_month.Text = "ماه"
        TextBox_datebirth_s_month.MaxLength = 2
        TextBox_datebirth_s_month.ForeColor = Color.DarkRed
        TextBox_datebirth_s_month.Visible = False
        '
        '
        'TextBox_datebirth_s_day
        TextBox_datebirth_s_day.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_s_day.Location = New System.Drawing.Point(200, 150)
        TextBox_datebirth_s_day.Size = New System.Drawing.Size(35, 20)
        TextBox_datebirth_s_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_s_day.Text = "روز"
        TextBox_datebirth_s_day.MaxLength = 2
        TextBox_datebirth_s_day.ForeColor = Color.DarkRed
        TextBox_datebirth_s_day.Visible = False
        '
        '
        'TextBox_datebirth_s_result
        TextBox_datebirth_s_result.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_s_result.Location = New System.Drawing.Point(135, 182)
        TextBox_datebirth_s_result.Size = New System.Drawing.Size(100, 20)
        TextBox_datebirth_s_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_s_result.Visible = False
        '
        '
        'TextBox_date_s_year
        TextBox_date_s_year.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_s_year.Location = New System.Drawing.Point(95, 205)
        TextBox_date_s_year.Size = New System.Drawing.Size(50, 20)
        TextBox_date_s_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_s_year.Text = "سال"
        TextBox_date_s_year.MaxLength = 4
        TextBox_date_s_year.ForeColor = Color.DarkRed
        TextBox_date_s_year.Visible = False
        '
        '
        'TextBox_date_s_month
        TextBox_date_s_month.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_s_month.Location = New System.Drawing.Point(155, 205)
        TextBox_date_s_month.Size = New System.Drawing.Size(35, 20)
        TextBox_date_s_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_s_month.Text = "ماه"
        TextBox_date_s_month.MaxLength = 2
        TextBox_date_s_month.ForeColor = Color.DarkRed
        TextBox_date_s_month.Visible = False
        '
        '
        'TextBox_date_s_day
        TextBox_date_s_day.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_s_day.Location = New System.Drawing.Point(200, 205)
        TextBox_date_s_day.Size = New System.Drawing.Size(35, 20)
        TextBox_date_s_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_s_day.Text = "روز"
        TextBox_date_s_day.MaxLength = 2
        TextBox_date_s_day.ForeColor = Color.DarkRed
        TextBox_date_s_day.Visible = False
        '
        '
        'TextBox_date_s_result
        TextBox_date_s_result.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_s_result.Location = New System.Drawing.Point(135, 232)
        TextBox_date_s_result.Size = New System.Drawing.Size(100, 20)
        TextBox_date_s_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_s_result.Visible = False
        '
        '
        'TextBox_gender_s
        TextBox_gender_s.Location = New System.Drawing.Point(10, 260)
        TextBox_gender_s.Size = New System.Drawing.Size(20, 20)
        TextBox_gender_s.Visible = False
        '
        '
        'TextBox_level_s
        TextBox_level_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_level_s.Location = New System.Drawing.Point(35, 312)
        TextBox_level_s.Size = New System.Drawing.Size(200, 20)
        TextBox_level_s.MaxLength = 100
        TextBox_level_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_level_s.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'PictureBox_level_s
        PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.writing
        PictureBox_level_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_level_s.Location = New System.Drawing.Point(10, 315)
        PictureBox_level_s.Size = New System.Drawing.Size(20, 20)
        ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت دستی")
        PictureBox_level_s.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'ComboBox_language_s_edit
        ComboBox_language_s_edit.DropDownHeight = 130
        ComboBox_language_s_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ComboBox_language_s_edit.IntegralHeight = False
        ComboBox_language_s_edit.ItemHeight = 13
        ComboBox_language_s_edit.MaxDropDownItems = 5
        ComboBox_language_s_edit.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ComboBox_language_s_edit.FormattingEnabled = True
        ComboBox_language_s_edit.Location = New System.Drawing.Point(35, 370)
        ComboBox_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ComboBox_language_s_edit.Size = New System.Drawing.Size(200, 21)
        ComboBox_language_s_edit.Visible = False
        '
        '
        'ComboBox_level_s
        ComboBox_level_s.DropDownHeight = 130
        ComboBox_level_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ComboBox_level_s.IntegralHeight = False
        ComboBox_level_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ComboBox_level_s.FormattingEnabled = True
        ComboBox_level_s.Location = New System.Drawing.Point(35, 315)
        ComboBox_level_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ComboBox_level_s.Size = New System.Drawing.Size(200, 21)
        ComboBox_level_s.Visible = False
        ComboBox_level_s.Items.Add("starter")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 1(A)")
        ComboBox_level_s.Items.Add("Family and friends 1(B)")
        ComboBox_level_s.Items.Add("Family and friends 1(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 2(A)")
        ComboBox_level_s.Items.Add("Family and friends 2(B)")
        ComboBox_level_s.Items.Add("Family and friends 2(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 3(A)")
        ComboBox_level_s.Items.Add("Family and friends 3(B)")
        ComboBox_level_s.Items.Add("Family and friends 3(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 4(A)")
        ComboBox_level_s.Items.Add("Family and friends 4(B)")
        ComboBox_level_s.Items.Add("Family and friends 4(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 5(A)")
        ComboBox_level_s.Items.Add("Family and friends 5(B)")
        ComboBox_level_s.Items.Add("Family and friends 5(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Family and friends 6(A)")
        ComboBox_level_s.Items.Add("Family and friends 6(B)")
        ComboBox_level_s.Items.Add("Family and friends 6(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Connect 1(A)")
        ComboBox_level_s.Items.Add("Connect 1(B)")
        ComboBox_level_s.Items.Add("Connect 1(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Connect 2(A)")
        ComboBox_level_s.Items.Add("Connect 2(B)")
        ComboBox_level_s.Items.Add("Connect 2(C)")
        ComboBox_level_s.Items.Add(String.Empty)
        ComboBox_level_s.Items.Add("Connect 3(A)")
        ComboBox_level_s.Items.Add("Connect 3(B)")
        ComboBox_level_s.Items.Add("Connect 3(C)")
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'RadioButton_female_s
        RadioButton_female_s.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_female_s.AutoSize = False
        RadioButton_female_s.Location = New System.Drawing.Point(35, 260)
        RadioButton_female_s.Size = New System.Drawing.Size(100, 30)
        RadioButton_female_s.Text = "زن"
        RadioButton_female_s.UseVisualStyleBackColor = True
        RadioButton_female_s.Visible = False
        RadioButton_female_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        'RadioButton_male_s
        RadioButton_male_s.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_male_s.AutoSize = False
        RadioButton_male_s.Location = New System.Drawing.Point(135, 260)
        RadioButton_male_s.Size = New System.Drawing.Size(100, 30)
        RadioButton_male_s.Text = "مرد"
        RadioButton_male_s.UseVisualStyleBackColor = True
        RadioButton_male_s.Visible = False
        RadioButton_male_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        '''''''''''GROUP BOX'''''''''''''''>>>>>
        GroupBox_setting.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        GroupBox_setting.Size = New System.Drawing.Size(210, 485)
        GroupBox_setting.Text = "تنظیمات"
        GroupBox_setting.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        GroupBox_setting.BackColor = Color.LightCoral
        GroupBox_setting.BringToFront()
        GroupBox_setting.Visible = True
        GroupBox_setting.Controls.Add(Radio_persian)
        GroupBox_setting.Controls.Add(Radio_english)
        GroupBox_setting.Controls.Add(Label_language)
        GroupBox_setting.Controls.Add(Label_between1)
        GroupBox_setting.Controls.Add(Label_music)
        GroupBox_setting.Controls.Add(PictureBox_music)
        GroupBox_setting.Controls.Add(Label_between2)
        GroupBox_setting.Controls.Add(Label_change_password)
        GroupBox_setting.Controls.Add(PictureBox_change_passwors)
        GroupBox_setting.Controls.Add(PictureBox_about_us)
        '
        '
        '
        '
        '
        'PictureBox_setting
        PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        PictureBox_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)
        PictureBox_setting.Size = New System.Drawing.Size(25, 25)
        PictureBox_setting.Visible = False
        PictureBox_setting.BringToFront()
        ToolTip_main.SetToolTip(PictureBox_setting, "تنظیمات")
        '
        '
        'Radio_persian
        Radio_persian.Font = GroupBox_setting.Font
        Radio_persian.AutoSize = False
        Radio_persian.Location = New System.Drawing.Point(115, 30)
        Radio_persian.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Radio_persian.Size = New System.Drawing.Size(70, 25)
        Radio_persian.Text = "فارسی"
        Radio_persian.UseVisualStyleBackColor = True
        Radio_persian.TextAlign = ContentAlignment.MiddleLeft
        Radio_persian.Visible = True
        '
        '
        'Radio_english
        Radio_english.Font = GroupBox_setting.Font
        Radio_english.AutoSize = False
        Radio_english.Location = New System.Drawing.Point(115, 55)
        Radio_english.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Radio_english.Size = New System.Drawing.Size(70, 25)
        Radio_english.Text = "انگلیسی"
        Radio_english.UseVisualStyleBackColor = True
        Radio_english.TextAlign = ContentAlignment.MiddleLeft
        Radio_english.Visible = True
        '
        '
        'Label_language
        Label_language.Font = GroupBox_setting.Font
        Label_language.Location = New System.Drawing.Point(25, 42.5)
        Label_language.Size = New System.Drawing.Size(40, 13)
        Label_language.Text = "زبان برنامه"
        Label_language.AutoSize = True
        Label_language.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_language.Visible = True
        '
        '
        'label_batween1
        Label_between1.AutoSize = True
        Label_between1.Location = New System.Drawing.Point(0, 80)
        Label_between1.Size = New System.Drawing.Size(210, 13)
        Label_between1.Text = "----------------------------"
        Label_between1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_between1.Visible = True
        '
        '
        'Label_music
        Label_music.Font = GroupBox_setting.Font
        Label_music.AutoSize = True
        Label_music.Location = New System.Drawing.Point(25, 117.5)
        Label_music.Size = New System.Drawing.Size(40, 13)
        Label_music.Text = "موزیک"
        Label_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_music.Visible = True
        '
        ' 
        'PictureBox_music
        PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__1_
        PictureBox_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_music.Location = New System.Drawing.Point(140, 110)
        PictureBox_music.Size = New System.Drawing.Size(40, 40)
        PictureBox_music.Visible = True

        '
        '
        'label_batween2
        Label_between2.AutoSize = True
        Label_between2.Location = New System.Drawing.Point(0, 155)
        Label_between2.Size = New System.Drawing.Size(210, 13)
        Label_between2.Text = "----------------------------"
        Label_between2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_between2.Visible = True
        '
        '
        'Label_change_password
        Label_change_password.Font = GroupBox_setting.Font
        Label_change_password.AutoSize = True
        Label_change_password.Location = New System.Drawing.Point(25, 192.5)
        Label_change_password.Size = New System.Drawing.Size(40, 13)
        Label_change_password.Text = "تغییر رمز"
        Label_change_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_change_password.Visible = True
        '
        '
        'PictureBox_change_passwors
        PictureBox_change_passwors.BackgroundImage = Global.language_class.My.Resources.Resources.pin_code
        PictureBox_change_passwors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_change_passwors.Location = New System.Drawing.Point(135, 180)
        PictureBox_change_passwors.Size = New System.Drawing.Size(40, 40)
        PictureBox_change_passwors.Visible = True
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_about_us
        PictureBox_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.about_us
        PictureBox_about_us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_about_us.Location = New System.Drawing.Point(80, 430)
        PictureBox_about_us.Size = New System.Drawing.Size(50, 50)
        PictureBox_about_us.Visible = True
        ToolTip_main.SetToolTip(PictureBox_about_us, "درباره ما")
        '
        '
        'PictureBox_Logo
        PictureBox_Logo.BackgroundImage = Global.language_class.My.Resources.Resources.ATOM
        PictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Logo.Location = New System.Drawing.Point(375, 20)
        PictureBox_Logo.Size = New System.Drawing.Size(250, 70)
        PictureBox_Logo.Visible = False
        '
        '
        'PictureBox_Logo_a
        PictureBox_Logo_a.BackgroundImage = Global.language_class.My.Resources.Resources.Logo
        PictureBox_Logo_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Logo_a.Location = New System.Drawing.Point(450, 200)
        PictureBox_Logo_a.Size = New System.Drawing.Size(100, 100)
        PictureBox_Logo_a.Visible = False
        '
        '
        'PictureBox_logo_b
        PictureBox_logo_b.BackgroundImage = Global.language_class.My.Resources.Resources.standing_up_man_
        PictureBox_logo_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_logo_b.Location = New System.Drawing.Point(400, 259)
        PictureBox_logo_b.Size = New System.Drawing.Size(200, 200)
        PictureBox_logo_b.Visible = False

        '
        '
        'PictureBox_programmer_name_B
        PictureBox_programmer_name_B.BackgroundImage = Global.language_class.My.Resources.Resources.avatar
        PictureBox_programmer_name_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_name_B.Location = New System.Drawing.Point(195.5, 100)
        PictureBox_programmer_name_B.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_name_B.Visible = False
        '
        '
        'PictureBox_programmer_name_D
        PictureBox_programmer_name_D.BackgroundImage = Global.language_class.My.Resources.Resources.avatar
        PictureBox_programmer_name_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_name_D.Location = New System.Drawing.Point(755.5, 100)
        PictureBox_programmer_name_D.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_name_D.Visible = False
        '
        '
        'Label_programmer_name_B
        Label_programmer_name_B.Font = New System.Drawing.Font("B Siavash", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(17, Byte))
        Label_programmer_name_B.Location = New System.Drawing.Point(70, 150)
        Label_programmer_name_B.Size = New System.Drawing.Size(300, 35)
        Label_programmer_name_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_name_B.Text = "دانیال خدارحمی"
        Label_programmer_name_B.Visible = False
        '
        '
        'Label_programmer_name_D
        Label_programmer_name_D.Font = New System.Drawing.Font("B Siavash", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(17, Byte))
        Label_programmer_name_D.Location = New System.Drawing.Point(630, 150)
        Label_programmer_name_D.Size = New System.Drawing.Size(300, 35)
        Label_programmer_name_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_name_D.Text = "دانیال خدارحمی"
        Label_programmer_name_D.Visible = False
        '
        '
        'PictureBox_programmer_phone_B
        PictureBox_programmer_phone_B.BackgroundImage = Global.language_class.My.Resources.Resources.telephone
        PictureBox_programmer_phone_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_phone_B.Location = New System.Drawing.Point(195.5, 235)
        PictureBox_programmer_phone_B.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_phone_B.Visible = False
        '
        '
        'PictureBox_programmer_phone_D
        PictureBox_programmer_phone_D.BackgroundImage = Global.language_class.My.Resources.Resources.telephone
        PictureBox_programmer_phone_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_phone_D.Location = New System.Drawing.Point(755.5, 235)
        PictureBox_programmer_phone_D.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_phone_D.Visible = False
        '
        '
        'Label_programmer_phone_B
        Label_programmer_phone_B.Font = New System.Drawing.Font("Curlz MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_phone_B.Location = New System.Drawing.Point(70, 285)
        Label_programmer_phone_B.Size = New System.Drawing.Size(300, 35)
        Label_programmer_phone_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_phone_B.Text = "0935 242 5523"
        Label_programmer_phone_B.Visible = False
        '
        '
        'Label_programmer_phone_D
        Label_programmer_phone_D.Font = New System.Drawing.Font("Curlz MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_phone_D.Location = New System.Drawing.Point(630, 285)
        Label_programmer_phone_D.Size = New System.Drawing.Size(300, 35)
        Label_programmer_phone_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_phone_D.Text = "0936 616 1205"
        Label_programmer_phone_D.Visible = False
        '
        '
        'PictureBox_programmer_gmail_B
        PictureBox_programmer_gmail_B.BackgroundImage = Global.language_class.My.Resources.Resources.gmail
        PictureBox_programmer_gmail_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_gmail_B.Location = New System.Drawing.Point(195.5, 370)
        PictureBox_programmer_gmail_B.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_gmail_B.Visible = False
        '
        '
        'PictureBox_programmer_gmail_D
        PictureBox_programmer_gmail_D.BackgroundImage = Global.language_class.My.Resources.Resources.gmail
        PictureBox_programmer_gmail_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_programmer_gmail_D.Location = New System.Drawing.Point(755.5, 370)
        PictureBox_programmer_gmail_D.Size = New System.Drawing.Size(50, 50)
        PictureBox_programmer_gmail_D.Visible = False
        '
        '
        'Label_programmer_gmail_B
        Label_programmer_gmail_B.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_gmail_B.Location = New System.Drawing.Point(70, 420)
        Label_programmer_gmail_B.Size = New System.Drawing.Size(300, 35)
        Label_programmer_gmail_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_gmail_B.Text = "Mr.danial.khodarahmi@gmail.com"
        Label_programmer_gmail_B.Visible = False
        '
        '
        'Label_programmer_gmail_D
        Label_programmer_gmail_D.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_gmail_D.Location = New System.Drawing.Point(630, 420)
        Label_programmer_gmail_D.Size = New System.Drawing.Size(300, 35)
        Label_programmer_gmail_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_programmer_gmail_D.Text = "Mr.danial.khodarahmi@gmail.com"
        Label_programmer_gmail_D.Visible = False
        '
        '
        'PictureBox_back_to_home_from_about_us
        PictureBox_back_to_home_from_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette
        PictureBox_back_to_home_from_about_us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_back_to_home_from_about_us.Location = New System.Drawing.Point(5, 5)
        PictureBox_back_to_home_from_about_us.Size = New System.Drawing.Size(25, 25)
        PictureBox_back_to_home_from_about_us.Visible = False
        '''''''''''GROUP BOX'''''''''''''''>>>>>>>
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'Label_name_t
        Label_name_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_t.Location = New System.Drawing.Point(800, 35)
        Label_name_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_t.Size = New System.Drawing.Size(180, 35)
        Label_name_t.Text = "نام:"
        Label_name_t.Visible = False
        '
        '
        'Label_lastname_t
        Label_lastname_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_lastname_t.Location = New System.Drawing.Point(800, 90)
        Label_lastname_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_lastname_t.Size = New System.Drawing.Size(180, 35)
        Label_lastname_t.Text = "نام خانوادگی:"
        Label_lastname_t.Visible = False
        '
        '
        'Label_phone_t
        Label_phone_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_t.Location = New System.Drawing.Point(800, 145)
        Label_phone_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_t.Size = New System.Drawing.Size(180, 35)
        Label_phone_t.Text = "شماره همراه:"
        Label_phone_t.Visible = False
        '
        '
        'Label_telephone_t
        Label_telephone_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_telephone_t.Location = New System.Drawing.Point(800, 200)
        Label_telephone_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_telephone_t.Size = New System.Drawing.Size(180, 35)
        Label_telephone_t.Text = "تلفن منزل:"
        Label_telephone_t.Visible = False
        '
        '
        'Label_address_t
        Label_address_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_address_t.Location = New System.Drawing.Point(800, 255)
        Label_address_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_address_t.Size = New System.Drawing.Size(180, 35)
        Label_address_t.Text = "آدرس:"
        Label_address_t.Visible = False
        '
        '
        'Label_codemeli_t
        Label_codemeli_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_codemeli_t.Location = New System.Drawing.Point(790, 310)
        Label_codemeli_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_codemeli_t.Size = New System.Drawing.Size(190, 35)
        Label_codemeli_t.Text = "کد ملی:"
        Label_codemeli_t.Visible = False
        '
        '
        'Label_evidence
        Label_evidence.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_evidence.Location = New System.Drawing.Point(790, 365)
        Label_evidence.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_evidence.Size = New System.Drawing.Size(190, 35)
        Label_evidence.Text = "سطح تحصیلات:"
        Label_evidence.Visible = False
        '
        '
        'Label_datebirth_t
        Label_datebirth_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_datebirth_t.Location = New System.Drawing.Point(235, 35)
        Label_datebirth_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_datebirth_t.Size = New System.Drawing.Size(180, 35)
        Label_datebirth_t.Text = "تاریخ تولد:"
        Label_datebirth_t.Visible = False
        '
        '
        'Label_date_t
        Label_date_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_date_t.Location = New System.Drawing.Point(235, 90)
        Label_date_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_date_t.Size = New System.Drawing.Size(180, 35)
        Label_date_t.Text = "تاریخ استخدام:"
        Label_date_t.Visible = False
        '
        '
        'Label_gender_t
        Label_gender_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_gender_t.Location = New System.Drawing.Point(235, 145)
        Label_gender_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_gender_t.Size = New System.Drawing.Size(180, 35)
        Label_gender_t.Text = "جنسیت:"
        Label_gender_t.Visible = False
        '
        '
        'Label_language_t_edit
        Label_language_t_edit.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_language_t_edit.Location = New System.Drawing.Point(235, 200)
        Label_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_language_t_edit.Size = New System.Drawing.Size(180, 35)
        Label_language_t_edit.Text = "زبان:"
        Label_language_t_edit.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'TextBox_name_t
        TextBox_name_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_t.Location = New System.Drawing.Point(590, 40)
        TextBox_name_t.Size = New System.Drawing.Size(200, 20)
        TextBox_name_t.MaxLength = 100
        TextBox_name_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_name_t.Visible = False
        '
        '
        'TextBox_lastname_t
        TextBox_lastname_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_lastname_t.Location = New System.Drawing.Point(590, 95)
        TextBox_lastname_t.Size = New System.Drawing.Size(200, 20)
        TextBox_lastname_t.MaxLength = 100
        TextBox_lastname_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_lastname_t.Visible = False
        '
        '
        'TextBox_phone_t
        TextBox_phone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_t.Location = New System.Drawing.Point(590, 150)
        TextBox_phone_t.Size = New System.Drawing.Size(200, 20)
        TextBox_phone_t.MaxLength = 11
        TextBox_phone_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_phone_t.Visible = False
        '
        '
        'TextBox_telephone_t
        TextBox_telephone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_telephone_t.Location = New System.Drawing.Point(590, 205)
        TextBox_telephone_t.Size = New System.Drawing.Size(200, 20)
        TextBox_telephone_t.MaxLength = 11
        TextBox_telephone_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_telephone_t.Visible = False
        '
        '
        'TextBox_address_t
        TextBox_address_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_address_t.Location = New System.Drawing.Point(590, 260)
        TextBox_address_t.Size = New System.Drawing.Size(200, 20)
        TextBox_address_t.MaxLength = 500
        TextBox_address_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_address_t.Visible = False
        '
        '
        'TextBox_codemeli_t
        TextBox_codemeli_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_codemeli_t.Location = New System.Drawing.Point(590, 315)
        TextBox_codemeli_t.Size = New System.Drawing.Size(200, 20)
        TextBox_codemeli_t.MaxLength = 10
        TextBox_codemeli_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_codemeli_t.Visible = False
        '  
        '
        'TextBox_evidence
        TextBox_evidence.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_evidence.Location = New System.Drawing.Point(590, 370)
        TextBox_evidence.Size = New System.Drawing.Size(200, 20)
        TextBox_evidence.MaxLength = 100
        TextBox_evidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_evidence.Visible = False
        '
        '
        'TextBox_datebirth_t_year
        TextBox_datebirth_t_year.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_t_year.Location = New System.Drawing.Point(95, 40)
        TextBox_datebirth_t_year.Size = New System.Drawing.Size(50, 20)
        TextBox_datebirth_t_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_t_year.Text = "سال"
        TextBox_datebirth_t_year.MaxLength = 4
        TextBox_datebirth_t_year.ForeColor = Color.DarkRed
        TextBox_datebirth_t_year.Visible = False
        '
        '
        'TextBox_datebirth_t_month
        TextBox_datebirth_t_month.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_t_month.Location = New System.Drawing.Point(155, 40)
        TextBox_datebirth_t_month.Size = New System.Drawing.Size(35, 20)
        TextBox_datebirth_t_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_t_month.Text = "ماه"
        TextBox_datebirth_t_month.MaxLength = 2
        TextBox_datebirth_t_month.ForeColor = Color.DarkRed
        TextBox_datebirth_t_month.Visible = False
        '
        '
        'TextBox_datebirth_t_day
        TextBox_datebirth_t_day.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_t_day.Location = New System.Drawing.Point(200, 40)
        TextBox_datebirth_t_day.Size = New System.Drawing.Size(35, 20)
        TextBox_datebirth_t_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_t_day.Text = "روز"
        TextBox_datebirth_t_day.MaxLength = 2
        TextBox_datebirth_t_day.ForeColor = Color.DarkRed
        TextBox_datebirth_t_day.Visible = False
        '
        '
        'TextBox_datebirth_t_result
        TextBox_datebirth_t_result.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_datebirth_t_result.Location = New System.Drawing.Point(135, 67)
        TextBox_datebirth_t_result.Size = New System.Drawing.Size(100, 20)
        TextBox_datebirth_t_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_datebirth_t_result.Visible = False
        '
        '
        'TextBox_date_t_year
        TextBox_date_t_year.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_t_year.Location = New System.Drawing.Point(95, 95)
        TextBox_date_t_year.Size = New System.Drawing.Size(50, 20)
        TextBox_date_t_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_t_year.Text = "سال"
        TextBox_date_t_year.MaxLength = 4
        TextBox_date_t_year.ForeColor = Color.DarkRed
        TextBox_date_t_year.Visible = False
        '
        '
        'TextBox_date_t_month
        TextBox_date_t_month.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_t_month.Location = New System.Drawing.Point(155, 95)
        TextBox_date_t_month.Size = New System.Drawing.Size(35, 20)
        TextBox_date_t_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_t_month.Text = "ماه"
        TextBox_date_t_month.MaxLength = 2
        TextBox_date_t_month.ForeColor = Color.DarkRed
        TextBox_date_t_month.Visible = False
        '
        '
        'TextBox_date_t_day
        TextBox_date_t_day.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_t_day.Location = New System.Drawing.Point(200, 95)
        TextBox_date_t_day.Size = New System.Drawing.Size(35, 20)
        TextBox_date_t_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_t_day.Text = "روز"
        TextBox_date_t_day.MaxLength = 2
        TextBox_date_t_day.ForeColor = Color.DarkRed
        TextBox_date_t_day.Visible = False
        '
        '
        'TextBox_date_t_result
        TextBox_date_t_result.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_date_t_result.Location = New System.Drawing.Point(135, 122)
        TextBox_date_t_result.Size = New System.Drawing.Size(100, 20)
        TextBox_date_t_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_date_t_result.Visible = False
        '
        '
        'TextBox_gender_t
        TextBox_gender_t.Location = New System.Drawing.Point(10, 150)
        TextBox_gender_t.Size = New System.Drawing.Size(20, 20)
        TextBox_gender_t.Visible = False
        '
        '
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '***************************************************)
        '
        '
        'RadioButton_female_t
        RadioButton_female_t.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_female_t.AutoSize = False
        RadioButton_female_t.Location = New System.Drawing.Point(35, 155)
        RadioButton_female_t.Size = New System.Drawing.Size(100, 30)
        RadioButton_female_t.Text = "زن"
        RadioButton_female_t.UseVisualStyleBackColor = True
        RadioButton_female_t.Visible = False
        RadioButton_female_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        'RadioButton_male_t
        RadioButton_male_t.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_male_t.AutoSize = False
        RadioButton_male_t.Location = New System.Drawing.Point(135, 155)
        RadioButton_male_t.Size = New System.Drawing.Size(100, 30)
        RadioButton_male_t.Text = "مرد"
        RadioButton_male_t.UseVisualStyleBackColor = True
        RadioButton_male_t.Visible = False
        RadioButton_male_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        '
        '
        '
        '
        '
        'ComboBox_language_t_edit
        ComboBox_language_t_edit.DropDownHeight = 130
        ComboBox_language_t_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ComboBox_language_t_edit.IntegralHeight = False
        ComboBox_language_t_edit.ItemHeight = 13
        ComboBox_language_t_edit.MaxDropDownItems = 5
        ComboBox_language_t_edit.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ComboBox_language_t_edit.FormattingEnabled = True
        ComboBox_language_t_edit.Location = New System.Drawing.Point(35, 205)
        ComboBox_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ComboBox_language_t_edit.Size = New System.Drawing.Size(200, 21)
        ComboBox_language_t_edit.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_back_to_home_from_students_and_teachers_list
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_back_to_home_from_students_and_teachers_list.Location = New System.Drawing.Point(5, 5)
        PictureBox_back_to_home_from_students_and_teachers_list.Size = New System.Drawing.Size(25, 25)
        PictureBox_back_to_home_from_students_and_teachers_list.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'Label_edit 
        Label_edit.Text = "ویرایش"
        Label_edit.Font = New System.Drawing.Font("B Roya", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_edit.Location = New System.Drawing.Point(450, 0)
        Label_edit.ForeColor = System.Drawing.Color.FromArgb(142, 0, 57)
        Label_edit.Size = New System.Drawing.Size(100, 30)
        Label_edit.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_back_to_home_from_registration_students
        PictureBox_back_to_home_from_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.cancel
        PictureBox_back_to_home_from_registration_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_back_to_home_from_registration_students.Location = New System.Drawing.Point(10, 420)
        PictureBox_back_to_home_from_registration_students.Size = New System.Drawing.Size(50, 50)
        PictureBox_back_to_home_from_registration_students.Visible = False
        '
        '
        'PictureBox_complete_registration_students
        PictureBox_complete_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.checked
        PictureBox_complete_registration_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_complete_registration_students.Location = New System.Drawing.Point(70, 420)
        PictureBox_complete_registration_students.Size = New System.Drawing.Size(50, 50)
        PictureBox_complete_registration_students.Visible = False
        '
        '
        '
        '
        '
        '
        'PictureBox_back_to_home_from_registration_teachers
        PictureBox_back_to_home_from_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.cancel
        PictureBox_back_to_home_from_registration_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_back_to_home_from_registration_teachers.Location = New System.Drawing.Point(10, 420)
        PictureBox_back_to_home_from_registration_teachers.Size = New System.Drawing.Size(50, 50)
        PictureBox_back_to_home_from_registration_teachers.Visible = False
        '
        '
        'PictureBox_complete_registration_teachers
        PictureBox_complete_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.checked
        PictureBox_complete_registration_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_complete_registration_teachers.Location = New System.Drawing.Point(70, 420)
        PictureBox_complete_registration_teachers.Size = New System.Drawing.Size(50, 50)
        PictureBox_complete_registration_teachers.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        '
        'PictureBox_delete_students
        PictureBox_delete_students.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
        PictureBox_delete_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_delete_students.Location = New System.Drawing.Point(900, 10)
        PictureBox_delete_students.Size = New System.Drawing.Size(50, 50)
        PictureBox_delete_students.Visible = False
        '
        '
        'PictureBox_delete_teachers
        PictureBox_delete_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
        PictureBox_delete_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_delete_teachers.Location = New System.Drawing.Point(900, 10)
        PictureBox_delete_teachers.Size = New System.Drawing.Size(50, 50)
        PictureBox_delete_teachers.Visible = False
        '
        '
        '
        '
        '
        '
        'PictureBox_edit_students
        PictureBox_edit_students.BackgroundImage = Global.language_class.My.Resources.Resources.edit
        PictureBox_edit_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_edit_students.Location = New System.Drawing.Point(900, 10)
        PictureBox_edit_students.Size = New System.Drawing.Size(50, 50)
        PictureBox_edit_students.Visible = False
        '
        '
        'PictureBox_edit_teachers
        PictureBox_edit_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.edit
        PictureBox_edit_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_edit_teachers.Location = New System.Drawing.Point(900, 10)
        PictureBox_edit_teachers.Size = New System.Drawing.Size(50, 50)
        PictureBox_edit_teachers.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'Panel_change_password
        Panel_change_password.Location = New System.Drawing.Point(290, 100)
        Panel_change_password.Size = New System.Drawing.Size(400, 300)
        Panel_change_password.BackColor = Color.LightSteelBlue
        Panel_change_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Panel_change_password.Visible = False
        Panel_change_password.BringToFront()
        Panel_change_password.Controls.Add(TextBox_change_password_1)
        Panel_change_password.Controls.Add(Label_change_password_1)
        Panel_change_password.Controls.Add(TextBox_change_password_2)
        Panel_change_password.Controls.Add(Label_change_password_2)
        Panel_change_password.Controls.Add(PictureBox_change_password_leave)
        Panel_change_password.Controls.Add(PictureBox_change_password_done)
        Panel_change_password.Controls.Add(Label_change_password_error)
        '
        '
        'TextBox_change_password_1
        TextBox_change_password_1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_change_password_1.Location = New System.Drawing.Point(100, 90)
        TextBox_change_password_1.Size = New System.Drawing.Size(200, 20)
        TextBox_change_password_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_change_password_1.Visible = False
        '
        '
        '
        'TextBox_change_password_2
        TextBox_change_password_2.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_change_password_2.Location = New System.Drawing.Point(100, 170)
        TextBox_change_password_2.Size = New System.Drawing.Size(200, 20)
        TextBox_change_password_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_change_password_2.Visible = False
        '
        '
        '
        'Label_change_password_1
        Label_change_password_1.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password_1.Location = New System.Drawing.Point(75.5, 55)
        Label_change_password_1.Size = New System.Drawing.Size(250, 35)
        Label_change_password_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_change_password_1.Text = "رمز جدید"
        Label_change_password_1.Visible = False
        '
        '
        'Label_change_password_2
        Label_change_password_2.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password_2.Location = New System.Drawing.Point(75.5, 135)
        Label_change_password_2.Size = New System.Drawing.Size(250, 35)
        Label_change_password_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_change_password_2.Text = "تکرار رمز جدید"
        Label_change_password_2.Visible = False
        '
        '
        'Label_change_password_error
        Label_change_password_error.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password_error.Location = New System.Drawing.Point(100, 15)
        Label_change_password_error.Size = New System.Drawing.Size(200, 35)
        Label_change_password_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_change_password_error.Text = "عدم مطابقت فیلد ها"
        Label_change_password_error.ForeColor = Color.Red
        Label_change_password_error.Visible = False
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_change_password_leave
        PictureBox_change_password_leave.BackgroundImage = Global.language_class.My.Resources.Resources.close
        PictureBox_change_password_leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_change_password_leave.Location = New System.Drawing.Point(365, 10)
        PictureBox_change_password_leave.Size = New System.Drawing.Size(25, 25)
        PictureBox_change_password_leave.Visible = False
        '
        '
        'PictureBox_change_password_done
        PictureBox_change_password_done.BackgroundImage = Global.language_class.My.Resources.Resources.check_mark
        PictureBox_change_password_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_change_password_done.Location = New System.Drawing.Point(187.5, 260)
        PictureBox_change_password_done.Size = New System.Drawing.Size(25, 25)
        PictureBox_change_password_done.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'TextBox_search
        TextBox_search.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_search.Location = New System.Drawing.Point(350, 35)
        TextBox_search.Size = New System.Drawing.Size(300, 10)
        TextBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_search.Visible = False
        '
        '
        'PictureBox_search
        PictureBox_search.BackgroundImage = Global.language_class.My.Resources.Resources.job_seeker
        PictureBox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_search.Location = New System.Drawing.Point(485, 25)
        PictureBox_search.Size = New System.Drawing.Size(30, 30)
        PictureBox_search.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'Label_students_teachers_count 
        Label_students_teachers_count.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_students_teachers_count.Location = New System.Drawing.Point(100, 65)
        Label_students_teachers_count.ForeColor = Color.DarkOrchid
        Label_students_teachers_count.Size = New System.Drawing.Size(70, 15)
        Label_students_teachers_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_students_teachers_count.Visible = False
        '
        '
        'Label_boy_count
        Label_boy_count.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_boy_count.Location = New System.Drawing.Point(170, 65)
        Label_boy_count.ForeColor = Color.DarkOrchid
        Label_boy_count.Size = New System.Drawing.Size(50, 15)
        Label_boy_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_boy_count.Text = "0"
        Label_boy_count.Visible = False
        '
        '
        'Label_girl_count 
        Label_girl_count.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_girl_count.Location = New System.Drawing.Point(220, 65)
        Label_girl_count.ForeColor = Color.DarkOrchid
        Label_girl_count.Size = New System.Drawing.Size(50, 15)
        Label_girl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_girl_count.Text = "0"
        Label_girl_count.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_population_count
        PictureBox_population_count.BackgroundImage = Global.language_class.My.Resources.Resources.population
        PictureBox_population_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_population_count.Location = New System.Drawing.Point(110, 10)
        PictureBox_population_count.Size = New System.Drawing.Size(50, 50)
        PictureBox_population_count.Visible = False
        '
        '
        'PictureBox_boy_count
        PictureBox_boy_count.BackgroundImage = Global.language_class.My.Resources.Resources.boy__1_
        PictureBox_boy_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_boy_count.Location = New System.Drawing.Point(182.5, 35)
        PictureBox_boy_count.Size = New System.Drawing.Size(25, 25)
        PictureBox_boy_count.Visible = False
        '
        '
        'PictureBox_girl_count
        PictureBox_girl_count.BackgroundImage = Global.language_class.My.Resources.Resources.girl
        PictureBox_girl_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_girl_count.Location = New System.Drawing.Point(232.5, 35)
        PictureBox_girl_count.Size = New System.Drawing.Size(25, 25)
        PictureBox_girl_count.Visible = False
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        'PictureBox_select_language_item
        PictureBox_select_language_item.BackgroundImage = Global.language_class.My.Resources.Resources.planet_earth
        PictureBox_select_language_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_select_language_item.Location = New System.Drawing.Point(470, 15)
        PictureBox_select_language_item.Size = New System.Drawing.Size(60, 60)
        PictureBox_select_language_item.Visible = False
        '
        '
        '
        '
        '
        '
        'Label_select_language_s
        Label_select_language_s.Font = New System.Drawing.Font("B nazanin", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_select_language_s.Location = New System.Drawing.Point(50, 80)
        Label_select_language_s.Size = New System.Drawing.Size(900, 35)
        Label_select_language_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_select_language_s.Text = "زبان انتخاب شده توسط دانش آموز برای یادگیری"
        Label_select_language_s.Visible = False
        '
        '
        'Label_select_language_t
        Label_select_language_t.Font = New System.Drawing.Font("B nazanin", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_select_language_t.Location = New System.Drawing.Point(50, 80)
        Label_select_language_t.Size = New System.Drawing.Size(900, 35)
        Label_select_language_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_select_language_t.Text = "زبان انتخاب شده توسط معلم برای آموزش"
        Label_select_language_t.Visible = False
        '
        '
        '
        '
        '
        '
        '
        'CheckBox_en
        CheckBox_en.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_en.Location = New System.Drawing.Point(150, 180)
        CheckBox_en.Size = New System.Drawing.Size(100, 30)
        CheckBox_en.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_en.Text = "انگلیسی"
        CheckBox_en.Visible = False
        '
        '
        'CheckBox_tur
        CheckBox_tur.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_tur.Location = New System.Drawing.Point(450, 180)
        CheckBox_tur.Size = New System.Drawing.Size(100, 30)
        CheckBox_tur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_tur.Text = "ترکی"
        CheckBox_tur.Visible = False
        '
        '
        'CheckBox_spa
        CheckBox_spa.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_spa.Location = New System.Drawing.Point(750, 180)
        CheckBox_spa.Size = New System.Drawing.Size(100, 30)
        CheckBox_spa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_spa.Text = "اسپانیایی"
        CheckBox_spa.Visible = False
        '
        '
        'CheckBox_ita
        CheckBox_ita.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_ita.Location = New System.Drawing.Point(150, 270)
        CheckBox_ita.Size = New System.Drawing.Size(100, 30)
        CheckBox_ita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_ita.Text = "ایتالیایی"
        CheckBox_ita.Visible = False
        '
        '
        'CheckBox_fre
        CheckBox_fre.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_fre.Location = New System.Drawing.Point(450, 270)
        CheckBox_fre.Size = New System.Drawing.Size(100, 30)
        CheckBox_fre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_fre.Text = "فرانسه ای"
        CheckBox_fre.Visible = False
        '
        '
        'CheckBox_arab
        CheckBox_arab.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_arab.Location = New System.Drawing.Point(750, 270)
        CheckBox_arab.Size = New System.Drawing.Size(100, 30)
        CheckBox_arab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_arab.Text = "عربی"
        CheckBox_arab.Visible = False
        '
        '
        'CheckBox_chi
        CheckBox_chi.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_chi.Location = New System.Drawing.Point(150, 360)
        CheckBox_chi.Size = New System.Drawing.Size(100, 30)
        CheckBox_chi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_chi.Text = "چینی"
        CheckBox_chi.Visible = False
        '
        '
        'CheckBox_japa
        CheckBox_japa.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_japa.Location = New System.Drawing.Point(450, 360)
        CheckBox_japa.Size = New System.Drawing.Size(100, 30)
        CheckBox_japa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_japa.Text = "ژاپنی"
        CheckBox_japa.Visible = False
        '
        '
        'CheckBox_kor
        CheckBox_kor.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_kor.Location = New System.Drawing.Point(750, 360)
        CheckBox_kor.Size = New System.Drawing.Size(100, 30)
        CheckBox_kor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        CheckBox_kor.Text = "کره ای"
        CheckBox_kor.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_en
        PictureBox_en.BackgroundImage = Global.language_class.My.Resources.Resources.united_states
        PictureBox_en.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_en.Location = New System.Drawing.Point(180, 135)
        PictureBox_en.Size = New System.Drawing.Size(40, 40)
        PictureBox_en.Visible = False
        '
        '
        'PictureBox_tur
        PictureBox_tur.BackgroundImage = Global.language_class.My.Resources.Resources.turkey
        PictureBox_tur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_tur.Location = New System.Drawing.Point(480, 135)
        PictureBox_tur.Size = New System.Drawing.Size(40, 40)
        PictureBox_tur.Visible = False
        '
        '
        'PictureBox_spa
        PictureBox_spa.BackgroundImage = Global.language_class.My.Resources.Resources.spain
        PictureBox_spa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_spa.Location = New System.Drawing.Point(780, 135)
        PictureBox_spa.Size = New System.Drawing.Size(40, 40)
        PictureBox_spa.Visible = False
        '
        '
        'PictureBox_ita
        PictureBox_ita.BackgroundImage = Global.language_class.My.Resources.Resources.italy
        PictureBox_ita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_ita.Location = New System.Drawing.Point(180, 225)
        PictureBox_ita.Size = New System.Drawing.Size(40, 40)
        PictureBox_ita.Visible = False
        '
        '
        'PictureBox_fre
        PictureBox_fre.BackgroundImage = Global.language_class.My.Resources.Resources.france
        PictureBox_fre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_fre.Location = New System.Drawing.Point(480, 225)
        PictureBox_fre.Size = New System.Drawing.Size(40, 40)
        PictureBox_fre.Visible = False
        '
        '
        'PictureBox_arab
        PictureBox_arab.BackgroundImage = Global.language_class.My.Resources.Resources.saudi_arabia
        PictureBox_arab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_arab.Location = New System.Drawing.Point(780, 225)
        PictureBox_arab.Size = New System.Drawing.Size(40, 40)
        PictureBox_arab.Visible = False
        '
        '
        'PictureBox_chi
        PictureBox_chi.BackgroundImage = Global.language_class.My.Resources.Resources.china
        PictureBox_chi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_chi.Location = New System.Drawing.Point(180, 315)
        PictureBox_chi.Size = New System.Drawing.Size(40, 40)
        PictureBox_chi.Visible = False
        '
        '
        'PictureBox_japa
        PictureBox_japa.BackgroundImage = Global.language_class.My.Resources.Resources.japan
        PictureBox_japa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_japa.Location = New System.Drawing.Point(480, 315)
        PictureBox_japa.Size = New System.Drawing.Size(40, 40)
        PictureBox_japa.Visible = False
        '
        '
        'PictureBox_kor
        PictureBox_kor.BackgroundImage = Global.language_class.My.Resources.Resources.south_korea
        PictureBox_kor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_kor.Location = New System.Drawing.Point(780, 315)
        PictureBox_kor.Size = New System.Drawing.Size(40, 40)
        PictureBox_kor.Visible = False
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_select_language_next_level
        PictureBox_select_language_next_level.BackgroundImage = Global.language_class.My.Resources.Resources._next
        PictureBox_select_language_next_level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_select_language_next_level.Location = New System.Drawing.Point(475.5, 420)
        PictureBox_select_language_next_level.Size = New System.Drawing.Size(50, 50)
        PictureBox_select_language_next_level.Visible = False
        ToolTip_main.SetToolTip(PictureBox_select_language_next_level, "مرحله بعد")
        '
        '
        'Label_select_language_result
        Label_select_language_result.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_select_language_result.Location = New System.Drawing.Point(370, 420)
        Label_select_language_result.Size = New System.Drawing.Size(100, 30)
        Label_select_language_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_select_language_result.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'PictureBox_level_test
        PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.level_test
        PictureBox_level_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_level_test.Location = New System.Drawing.Point(30, 410)
        PictureBox_level_test.Size = New System.Drawing.Size(50, 50)
        PictureBox_level_test.Visible = False
        ToolTip_main.SetToolTip(PictureBox_level_test, "آزمون تعیین سطح")
        '
        '
        'PictureBox_b_f_level_test
        PictureBox_b_f_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette
        PictureBox_b_f_level_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_b_f_level_test.Location = New System.Drawing.Point(40, 420)
        PictureBox_b_f_level_test.Size = New System.Drawing.Size(40, 40)
        PictureBox_b_f_level_test.Visible = False
        ToolTip_main.SetToolTip(PictureBox_b_f_level_test, "خانه")
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_level_test_explain
        Label_level_test_explain.AutoSize = False
        Label_level_test_explain.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_level_test_explain.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_level_test_explain.RightToLeft = Windows.Forms.RightToLeft.Yes
        Label_level_test_explain.Location = New System.Drawing.Point(25, 10)
        Label_level_test_explain.Size = New System.Drawing.Size(950, 400)
        Label_level_test_explain.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_l_t_number
        Label_l_t_number.AutoSize = False
        Label_l_t_number.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_l_t_number.Location = New System.Drawing.Point(470, 5)
        Label_l_t_number.Size = New System.Drawing.Size(40, 40)
        Label_l_t_number.Visible = False
        '
        '
        'Label_l_t_question
        Label_l_t_question.AutoSize = False
        Label_l_t_question.ForeColor = Color.DarkOrange
        Label_l_t_question.Font = New System.Drawing.Font("Script MT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_question.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_question.Location = New System.Drawing.Point(20, 55)
        Label_l_t_question.Size = New System.Drawing.Size(950, 100)
        Label_l_t_question.Visible = False
        '
        '
        'Label_l_t_answer_1
        Label_l_t_answer_1.AutoSize = True
        Label_l_t_answer_1.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_answer_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_answer_1.Location = New System.Drawing.Point(25, 155)
        Label_l_t_answer_1.Size = New System.Drawing.Size(950, 50)
        Label_l_t_answer_1.Visible = False
        '
        '
        'Label_l_t_answer_2
        Label_l_t_answer_2.AutoSize = True
        Label_l_t_answer_2.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_answer_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_answer_2.Location = New System.Drawing.Point(25, 205)
        Label_l_t_answer_2.Size = New System.Drawing.Size(950, 50)
        Label_l_t_answer_2.Visible = False
        '
        '
        'Label_l_t_answer_3
        Label_l_t_answer_3.AutoSize = True
        Label_l_t_answer_3.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_answer_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_answer_3.Location = New System.Drawing.Point(25, 255)
        Label_l_t_answer_3.Size = New System.Drawing.Size(950, 50)
        Label_l_t_answer_3.Visible = False
        '
        '
        'Label_l_t_answer_4
        Label_l_t_answer_4.AutoSize = True
        Label_l_t_answer_4.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_answer_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_answer_4.Location = New System.Drawing.Point(25, 305)
        Label_l_t_answer_4.Size = New System.Drawing.Size(950, 50)
        Label_l_t_answer_4.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_l_t_result_percent
        Label_l_t_result_percent.AutoSize = False
        Label_l_t_result_percent.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_result_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_l_t_result_percent.Location = New System.Drawing.Point(10, 40)
        Label_l_t_result_percent.Size = New System.Drawing.Size(300, 100)
        Label_l_t_result_percent.Visible = False
        '
        '
        'Label_l_t_result_score
        Label_l_t_result_score.AutoSize = False
        Label_l_t_result_score.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_result_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_l_t_result_score.Location = New System.Drawing.Point(670, 40)
        Label_l_t_result_score.Size = New System.Drawing.Size(300, 100)
        Label_l_t_result_score.Visible = False
        '
        '
        'Label_l_t_result_explain
        Label_l_t_result_explain.AutoSize = False
        Label_l_t_result_explain.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_result_explain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_l_t_result_explain.Location = New System.Drawing.Point(10, 180)
        Label_l_t_result_explain.Size = New System.Drawing.Size(970, 120)
        Label_l_t_result_explain.Visible = False
        '
        '
        'Label_l_t_result_table_english
        Label_l_t_result_table_english.AutoSize = False
        Label_l_t_result_table_english.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_result_table_english.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_result_table_english.Location = New System.Drawing.Point(5, 300)
        Label_l_t_result_table_english.Size = New System.Drawing.Size(485, 200)
        Label_l_t_result_table_english.Visible = False
        '
        '
        'Label_l_t_result_table_persian
        Label_l_t_result_table_persian.AutoSize = False
        Label_l_t_result_table_persian.RightToLeft = Windows.Forms.RightToLeft.Yes
        Label_l_t_result_table_persian.Font = New System.Drawing.Font("B NAZANIN", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_l_t_result_table_persian.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Label_l_t_result_table_persian.Location = New System.Drawing.Point(490, 300)
        Label_l_t_result_table_persian.Size = New System.Drawing.Size(485, 200)
        Label_l_t_result_table_persian.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_forgotten_password
        Label_forgotten_password.AutoSize = False
        Label_forgotten_password.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_forgotten_password.Location = New System.Drawing.Point(400, 280)
        Label_forgotten_password.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Label_forgotten_password.Size = New System.Drawing.Size(200, 25)
        Label_forgotten_password.ForeColor = Color.Blue
        Label_forgotten_password.Text = "بازیابی رمز عبور"
        Label_forgotten_password.Visible = False
        '
        '
        '
        ' 
        '
        'PictureBox_back_to_password
        PictureBox_back_to_password.BackgroundImage = Global.language_class.My.Resources.Resources.back
        PictureBox_back_to_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_back_to_password.Location = New System.Drawing.Point(5, 5)
        PictureBox_back_to_password.Size = New System.Drawing.Size(25, 25)
        PictureBox_back_to_password.Visible = False
        '
        '
        'Label_return_password
        Label_return_password.AutoSize = False
        Label_return_password.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_return_password.Location = New System.Drawing.Point(100, 190)
        Label_return_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_return_password.Size = New System.Drawing.Size(800, 30)
        Label_return_password.Visible = False
        '
        '
        'Textbox_return_password
        Textbox_return_password.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Textbox_return_password.Location = New System.Drawing.Point(375.5, 230)
        Textbox_return_password.Size = New System.Drawing.Size(250, 30)
        Textbox_return_password.MaxLength = 10
        Textbox_return_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Textbox_return_password.Visible = False
        '
        '
        'PictureBox_return_password
        PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next
        PictureBox_return_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_return_password.Location = New System.Drawing.Point(475.5, 290)
        PictureBox_return_password.Size = New System.Drawing.Size(50, 50)
        PictureBox_return_password.Visible = False
        ToolTip_main.SetToolTip(PictureBox_return_password, "بازیابی")
        '
        '
        'Textbox_return_password_p_1
        Textbox_return_password_p_1.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Textbox_return_password_p_1.Location = New System.Drawing.Point(375.5, 200)
        Textbox_return_password_p_1.Size = New System.Drawing.Size(250, 30)
        Textbox_return_password_p_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Textbox_return_password_p_1.Visible = False
        '
        '
        'Textbox_return_password_p_2
        Textbox_return_password_p_2.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Textbox_return_password_p_2.Location = New System.Drawing.Point(375.5, 280)
        Textbox_return_password_p_2.Size = New System.Drawing.Size(250, 30)
        Textbox_return_password_p_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Textbox_return_password_p_2.Visible = False
        '
        '
        'Label_return_password_p_1
        Label_return_password_p_1.AutoSize = False
        Label_return_password_p_1.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_return_password_p_1.Location = New System.Drawing.Point(100, 170)
        Label_return_password_p_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_return_password_p_1.Size = New System.Drawing.Size(800, 30)
        Label_return_password_p_1.Visible = False
        '
        '
        'Label_return_password_p_2
        Label_return_password_p_2.AutoSize = False
        Label_return_password_p_2.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_return_password_p_2.Location = New System.Drawing.Point(100, 250)
        Label_return_password_p_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_return_password_p_2.Size = New System.Drawing.Size(800, 30)
        Label_return_password_p_2.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        ''''''''MESSAGE BOX
        '
        'Panel_msg_box
        Panel_msg_box.Location = New System.Drawing.Point(250, 150)
        Panel_msg_box.Size = New System.Drawing.Size(500, 200)
        Panel_msg_box.BackColor = Color.White
        Panel_msg_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Panel_msg_box.Visible = False
        Panel_msg_box.BringToFront()
        Panel_msg_box.Controls.Add(PictureBox_msg_box_left)
        Panel_msg_box.Controls.Add(PictureBox_msg_box_right)
        Panel_msg_box.Controls.Add(Label_msg_box_title)
        Panel_msg_box.Controls.Add(Label_msg_box_detail)
        Panel_msg_box.Controls.Add(Label_msg_box_option_1)
        Panel_msg_box.Controls.Add(Label_msg_box_option_2)
        '
        '
        'PictureBox_msg_box_left
        PictureBox_msg_box_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_msg_box_left.Location = New System.Drawing.Point(120, 5)
        PictureBox_msg_box_left.Size = New System.Drawing.Size(30, 30)
        PictureBox_msg_box_left.Visible = True
        '
        '
        'PictureBox_msg_box_right
        PictureBox_msg_box_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_msg_box_right.Location = New System.Drawing.Point(350, 5)
        PictureBox_msg_box_right.Size = New System.Drawing.Size(30, 30)
        PictureBox_msg_box_right.Visible = True
        '
        '
        'Label_msg_box_title
        Label_msg_box_title.AutoSize = False
        Label_msg_box_title.Location = New System.Drawing.Point(150, 5)
        Label_msg_box_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_msg_box_title.Size = New System.Drawing.Size(200, 30)
        Label_msg_box_title.Visible = True
        '
        '
        'Label_msg_box_detail
        Label_msg_box_detail.AutoSize = False
        Label_msg_box_detail.Location = New System.Drawing.Point(20, 50)
        Label_msg_box_detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_msg_box_detail.Size = New System.Drawing.Size(460, 100)
        Label_msg_box_detail.Visible = True
        '
        '
        'Label_msg_box_option_1
        Label_msg_box_option_1.AutoSize = False
        Label_msg_box_option_1.Location = New System.Drawing.Point(0, 150)
        Label_msg_box_option_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_msg_box_option_1.Size = New System.Drawing.Size(250, 50)
        Label_msg_box_option_1.BackColor = System.Drawing.Color.FromArgb(189, 255, 248)
        Label_msg_box_option_1.Visible = True
        '
        '
        'Label_msg_box_option_2
        Label_msg_box_option_2.AutoSize = False
        Label_msg_box_option_2.Location = New System.Drawing.Point(250, 150)
        Label_msg_box_option_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_msg_box_option_2.Size = New System.Drawing.Size(250, 50)
        Label_msg_box_option_2.BackColor = System.Drawing.Color.FromArgb(189, 255, 248)
        Label_msg_box_option_2.Visible = True
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '''''charts
        'Chart_l_t_resut
        Chart_l_t_resut.Location = New System.Drawing.Point(355, 0)
        Chart_l_t_resut.Size = New System.Drawing.Size(300, 180)
        Chart_l_t_resut.Visible = False
        '
        'Chart_students
        Chart_students.Location = New System.Drawing.Point(300, 80)
        Chart_students.Size = New System.Drawing.Size(400, 400)
        Chart_students.Visible = False
        '
        'Chart_teachers
        Chart_teachers.Location = New System.Drawing.Point(300, 80)
        Chart_teachers.Size = New System.Drawing.Size(400, 400)
        Chart_teachers.Visible = False
        '
        'Chart_all
        Chart_all.Location = New System.Drawing.Point(300, 80)
        Chart_all.Size = New System.Drawing.Size(400, 400)
        Chart_all.Visible = False
        '
        '
        '
        'PictureBox_charts_show
        PictureBox_charts_show.BackgroundImage = Global.language_class.My.Resources.Resources.graph
        PictureBox_charts_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show.Location = New System.Drawing.Point(100, 410)
        PictureBox_charts_show.Size = New System.Drawing.Size(50, 50)
        PictureBox_charts_show.Visible = False
        '
        '
        '
        'PictureBox_charts_show_back
        PictureBox_charts_show_back.BackgroundImage = Global.language_class.My.Resources.Resources.back
        PictureBox_charts_show_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show_back.Location = New System.Drawing.Point(5, 5)
        PictureBox_charts_show_back.Size = New System.Drawing.Size(25, 25)
        PictureBox_charts_show_back.Visible = False
        '
        '
        '
        'PictureBox_charts_show_choose_item
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart
        PictureBox_charts_show_choose_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show_choose_item.Location = New System.Drawing.Point(-20, 82)
        PictureBox_charts_show_choose_item.Size = New System.Drawing.Size(800, 400)
        PictureBox_charts_show_choose_item.Visible = False
        '
        '
        '
        'PictureBox_charts_show_all
        PictureBox_charts_show_all.BackgroundImage = Global.language_class.My.Resources.Resources.teacher_student
        PictureBox_charts_show_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show_all.Location = New System.Drawing.Point(830, 85)
        PictureBox_charts_show_all.Size = New System.Drawing.Size(70, 70)
        PictureBox_charts_show_all.Visible = False
        '
        '
        '
        'PictureBox_charts_show_teachers
        PictureBox_charts_show_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.teacher
        PictureBox_charts_show_teachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show_teachers.Location = New System.Drawing.Point(830, 185)
        PictureBox_charts_show_teachers.Size = New System.Drawing.Size(70, 70)
        PictureBox_charts_show_teachers.Visible = False
        '
        '
        '
        'PictureBox_charts_show_students
        PictureBox_charts_show_students.BackgroundImage = Global.language_class.My.Resources.Resources.student
        PictureBox_charts_show_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_show_students.Location = New System.Drawing.Point(830, 285)
        PictureBox_charts_show_students.Size = New System.Drawing.Size(70, 70)
        PictureBox_charts_show_students.Visible = False
        '
        '
        'Label_charts_show_explain_in_all
        Label_charts_show_explain_in_all.AutoSize = False
        Label_charts_show_explain_in_all.Location = New System.Drawing.Point(200, 0)
        Label_charts_show_explain_in_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_charts_show_explain_in_all.Size = New System.Drawing.Size(600, 75)
        Label_charts_show_explain_in_all.Visible = False
        '
        '
        '
        '
        ' 
        '
        'Label_charts_choose_language
        Label_charts_choose_language.AutoSize = False
        Label_charts_choose_language.Location = New System.Drawing.Point(120, 0)
        Label_charts_choose_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_charts_choose_language.Size = New System.Drawing.Size(85, 40)
        Label_charts_choose_language.Visible = False
        '
        '
        'Label_charts_choose_gender
        Label_charts_choose_gender.AutoSize = False
        Label_charts_choose_gender.Location = New System.Drawing.Point(205, 0)
        Label_charts_choose_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_charts_choose_gender.Size = New System.Drawing.Size(80, 40)
        Label_charts_choose_gender.Visible = False
        '
        '
        'Label_charts_choose_birthday
        Label_charts_choose_birthday.AutoSize = False
        Label_charts_choose_birthday.Location = New System.Drawing.Point(285, 0)
        Label_charts_choose_birthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_charts_choose_birthday.Size = New System.Drawing.Size(80, 40)
        Label_charts_choose_birthday.Visible = False
        '
        '
        'Label_charts_choose_date_of_registration
        Label_charts_choose_date_of_registration.AutoSize = False
        Label_charts_choose_date_of_registration.Location = New System.Drawing.Point(365, 0)
        Label_charts_choose_date_of_registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_charts_choose_date_of_registration.Size = New System.Drawing.Size(95, 40)
        Label_charts_choose_date_of_registration.Visible = False
        '
        '
        'PictureBox_charts_2d_3d
        PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._2d
        PictureBox_charts_2d_3d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_2d_3d.Location = New System.Drawing.Point(800, 0)
        PictureBox_charts_2d_3d.Size = New System.Drawing.Size(30, 30)
        PictureBox_charts_2d_3d.Visible = False
        '
        '
        'PictureBox_Part_charts_tips
        PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp
        PictureBox_Part_charts_tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Part_charts_tips.Location = New System.Drawing.Point(760, 0)
        PictureBox_Part_charts_tips.Size = New System.Drawing.Size(30, 30)
        PictureBox_Part_charts_tips.Visible = False
        '
        '
        'PictureBox_Part_charts_restore_to_default
        PictureBox_Part_charts_restore_to_default.BackgroundImage = Global.language_class.My.Resources.Resources.restore
        PictureBox_Part_charts_restore_to_default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Part_charts_restore_to_default.Location = New System.Drawing.Point(720, 0)
        PictureBox_Part_charts_restore_to_default.Size = New System.Drawing.Size(30, 30)
        PictureBox_Part_charts_restore_to_default.Visible = False
        '
        '
        'Label_Part_charts_tips_1
        Label_Part_charts_tips_1.AutoSize = False
        Label_Part_charts_tips_1.Location = New System.Drawing.Point(803, 40)
        Label_Part_charts_tips_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Part_charts_tips_1.Size = New System.Drawing.Size(200, 35)
        Label_Part_charts_tips_1.ForeColor = Color.DarkGreen
        Label_Part_charts_tips_1.Visible = False
        '
        '
        'Label_Part_charts_tips_2
        Label_Part_charts_tips_2.AutoSize = False
        Label_Part_charts_tips_2.Location = New System.Drawing.Point(420, 0)
        Label_Part_charts_tips_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Part_charts_tips_2.Size = New System.Drawing.Size(300, 35)
        Label_Part_charts_tips_2.ForeColor = Color.DarkGreen
        Label_Part_charts_tips_2.Visible = False
        '
        '
        'Label_Part_charts_tips_3
        Label_Part_charts_tips_3.AutoSize = False
        Label_Part_charts_tips_3.Location = New System.Drawing.Point(690, 75)
        Label_Part_charts_tips_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Part_charts_tips_3.Size = New System.Drawing.Size(250, 400)
        Label_Part_charts_tips_3.ForeColor = Color.DarkGreen
        Label_Part_charts_tips_3.SendToBack()
        Label_Part_charts_tips_3.Visible = False
        '
        '
        'Label_Part_charts_tips_4
        Label_Part_charts_tips_4.AutoSize = False
        Label_Part_charts_tips_4.Location = New System.Drawing.Point(50, 75)
        Label_Part_charts_tips_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Part_charts_tips_4.Size = New System.Drawing.Size(250, 400)
        Label_Part_charts_tips_4.ForeColor = Color.DarkGreen
        Label_Part_charts_tips_4.SendToBack()
        Label_Part_charts_tips_4.Visible = False
        '
        '
        'Label_Part_charts_tips_5
        Label_Part_charts_tips_5.AutoSize = False
        Label_Part_charts_tips_5.Location = New System.Drawing.Point(200, 50)
        Label_Part_charts_tips_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Part_charts_tips_5.Size = New System.Drawing.Size(600, 45)
        Label_Part_charts_tips_5.ForeColor = Color.DarkGreen
        Label_Part_charts_tips_5.BringToFront()
        Label_Part_charts_tips_5.Visible = False
        '
        '
        'TrackBar_charts_type
        TrackBar_charts_type.AutoSize = True
        TrackBar_charts_type.LargeChange = 1
        TrackBar_charts_type.Location = New System.Drawing.Point(20, 110)
        TrackBar_charts_type.Maximum = 16
        TrackBar_charts_type.Size = New System.Drawing.Size(370, 370)
        TrackBar_charts_type.Orientation = System.Windows.Forms.Orientation.Vertical
        TrackBar_charts_type.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        TrackBar_charts_type.Visible = False
        '
        '
        'TrackBar_charts_color
        TrackBar_charts_color.AutoSize = True
        TrackBar_charts_color.LargeChange = 1
        TrackBar_charts_color.Location = New System.Drawing.Point(930, 110)
        TrackBar_charts_color.Maximum = 11
        TrackBar_charts_color.Size = New System.Drawing.Size(370, 370)
        TrackBar_charts_color.Orientation = System.Windows.Forms.Orientation.Vertical
        TrackBar_charts_color.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        TrackBar_charts_color.Visible = False
        '
        '
        '
        'PictureBox_charts_change_type
        PictureBox_charts_change_type.BackgroundImage = Global.language_class.My.Resources.Resources.transform
        PictureBox_charts_change_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_change_type.Location = New System.Drawing.Point(13, 75)
        PictureBox_charts_change_type.Size = New System.Drawing.Size(35, 35)
        PictureBox_charts_change_type.Visible = False
        '
        '
        '
        'PictureBox_charts_change_color
        PictureBox_charts_change_color.BackgroundImage = Global.language_class.My.Resources.Resources.colors
        PictureBox_charts_change_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_charts_change_color.Location = New System.Drawing.Point(933, 75)
        PictureBox_charts_change_color.Size = New System.Drawing.Size(35, 35)
        PictureBox_charts_change_color.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '''''''Accounting
        '
        '
        'PictureBox_Accounting
        PictureBox_Accounting.BackgroundImage = Global.language_class.My.Resources.Resources.money
        PictureBox_Accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting.Location = New System.Drawing.Point(170, 410)
        PictureBox_Accounting.Size = New System.Drawing.Size(50, 50)
        PictureBox_Accounting.Visible = False
        '
        '
        'PictureBox_Accounting_back
        PictureBox_Accounting_back.BackgroundImage = Global.language_class.My.Resources.Resources.back
        PictureBox_Accounting_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_back.Location = New System.Drawing.Point(5, 5)
        PictureBox_Accounting_back.Size = New System.Drawing.Size(25, 25)
        PictureBox_Accounting_back.Visible = False
        '
        '
        '
        '
        'PictureBox_Accounting_money_Incoming
        PictureBox_Accounting_money_Incoming.BackgroundImage = Global.language_class.My.Resources.Resources.money_Incoming
        PictureBox_Accounting_money_Incoming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_money_Incoming.Location = New System.Drawing.Point(100, 100)
        PictureBox_Accounting_money_Incoming.Size = New System.Drawing.Size(200, 200)
        PictureBox_Accounting_money_Incoming.Visible = False
        '
        '
        'PictureBox_Accounting_money_Output
        PictureBox_Accounting_money_Output.BackgroundImage = Global.language_class.My.Resources.Resources.money_Output
        PictureBox_Accounting_money_Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_money_Output.Location = New System.Drawing.Point(700, 100)
        PictureBox_Accounting_money_Output.Size = New System.Drawing.Size(200, 200)
        PictureBox_Accounting_money_Output.Visible = False
        '
        '
        'PictureBox_Accounting_money_Turnover
        PictureBox_Accounting_money_Turnover.BackgroundImage = Global.language_class.My.Resources.Resources.money_flow
        PictureBox_Accounting_money_Turnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_money_Turnover.Location = New System.Drawing.Point(450, 320)
        PictureBox_Accounting_money_Turnover.Size = New System.Drawing.Size(100, 100)
        PictureBox_Accounting_money_Turnover.Visible = False
        '
        '
        '
        '
        '
        'Label_Accounting_farvardin
        Label_Accounting_farvardin.AutoSize = False
        Label_Accounting_farvardin.Location = New System.Drawing.Point(824, 150)
        Label_Accounting_farvardin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_farvardin.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_farvardin.Visible = False
        '
        '
        'Label_Accounting_ordibehesht
        Label_Accounting_ordibehesht.AutoSize = False
        Label_Accounting_ordibehesht.Location = New System.Drawing.Point(824, 190)
        Label_Accounting_ordibehesht.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_ordibehesht.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_ordibehesht.Visible = False
        '
        '
        'Label_Accounting_khordad
        Label_Accounting_khordad.AutoSize = False
        Label_Accounting_khordad.Location = New System.Drawing.Point(824, 230)
        Label_Accounting_khordad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_khordad.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_khordad.Visible = False
        '
        '
        'Label_Accounting_tir
        Label_Accounting_tir.AutoSize = False
        Label_Accounting_tir.Location = New System.Drawing.Point(824, 270)
        Label_Accounting_tir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_tir.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_tir.Visible = False
        '
        '
        'Label_Accounting_mordad
        Label_Accounting_mordad.AutoSize = False
        Label_Accounting_mordad.Location = New System.Drawing.Point(824, 310)
        Label_Accounting_mordad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_mordad.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_mordad.Visible = False
        '
        '
        'Label_Accounting_shahrivar
        Label_Accounting_shahrivar.AutoSize = False
        Label_Accounting_shahrivar.Location = New System.Drawing.Point(824, 350)
        Label_Accounting_shahrivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label_Accounting_shahrivar.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_shahrivar.Visible = False
        '
        '
        'Label_Accounting_mehr
        Label_Accounting_mehr.AutoSize = False
        Label_Accounting_mehr.Location = New System.Drawing.Point(10, 150)
        Label_Accounting_mehr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_mehr.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_mehr.Visible = False
        '
        '
        'Label_Accounting_aban
        Label_Accounting_aban.AutoSize = False
        Label_Accounting_aban.Location = New System.Drawing.Point(10, 190)
        Label_Accounting_aban.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_aban.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_aban.Visible = False
        '
        '
        'Label_Accounting_azar
        Label_Accounting_azar.AutoSize = False
        Label_Accounting_azar.Location = New System.Drawing.Point(10, 230)
        Label_Accounting_azar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_azar.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_azar.Visible = False
        '
        '
        'Label_Accounting_dey
        Label_Accounting_dey.AutoSize = False
        Label_Accounting_dey.Location = New System.Drawing.Point(10, 270)
        Label_Accounting_dey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_dey.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_dey.Visible = False
        '
        '
        'Label_Accounting_bahman
        Label_Accounting_bahman.AutoSize = False
        Label_Accounting_bahman.Location = New System.Drawing.Point(10, 310)
        Label_Accounting_bahman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_bahman.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_bahman.Visible = False
        '
        '
        'Label_Accounting_esfand
        Label_Accounting_esfand.AutoSize = False
        Label_Accounting_esfand.Location = New System.Drawing.Point(10, 350)
        Label_Accounting_esfand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_esfand.Size = New System.Drawing.Size(150, 30)
        Label_Accounting_esfand.Visible = False
        '
        '
        'PictureBox_Accounting_edit
        PictureBox_Accounting_edit.BackgroundImage = Global.language_class.My.Resources.Resources.warning
        PictureBox_Accounting_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_edit.Location = New System.Drawing.Point(425, 0)
        PictureBox_Accounting_edit.Size = New System.Drawing.Size(30, 30)
        PictureBox_Accounting_edit.Visible = False
        '
        '
        'PictureBox_Accounting_add
        PictureBox_Accounting_add.BackgroundImage = Global.language_class.My.Resources.Resources.plus
        PictureBox_Accounting_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_add.Location = New System.Drawing.Point(475, 0)
        PictureBox_Accounting_add.Size = New System.Drawing.Size(50, 50)
        PictureBox_Accounting_add.Visible = False
        '
        '
        'PictureBox_Accounting_delete
        PictureBox_Accounting_delete.BackgroundImage = Global.language_class.My.Resources.Resources.remove
        PictureBox_Accounting_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_delete.Location = New System.Drawing.Point(545, 0)
        PictureBox_Accounting_delete.Size = New System.Drawing.Size(30, 30)
        PictureBox_Accounting_delete.Visible = False
        '
        '
        '
        '
        '
        '
        '
        '
        'Label_Accounting_money_add_1
        Label_Accounting_money_add_1.AutoSize = False
        Label_Accounting_money_add_1.Location = New System.Drawing.Point(400, 80)
        Label_Accounting_money_add_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_1.Size = New System.Drawing.Size(200, 30)
        Label_Accounting_money_add_1.Visible = False
        '
        '
        'Label_Accounting_money_add_2
        Label_Accounting_money_add_2.AutoSize = False
        Label_Accounting_money_add_2.Location = New System.Drawing.Point(25, 135)
        Label_Accounting_money_add_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_2.Size = New System.Drawing.Size(950, 15)
        Label_Accounting_money_add_2.SendToBack()
        Label_Accounting_money_add_2.Text = "____________________________________________________"
        Label_Accounting_money_add_2.Visible = False
        '
        '
        'Label_Accounting_money_add_3
        Label_Accounting_money_add_3.AutoSize = False
        Label_Accounting_money_add_3.Location = New System.Drawing.Point(400, 180)
        Label_Accounting_money_add_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_3.Size = New System.Drawing.Size(200, 30)
        Label_Accounting_money_add_3.Visible = False
        '
        '
        'Label_Accounting_money_add_4
        Label_Accounting_money_add_4.AutoSize = False
        Label_Accounting_money_add_4.Location = New System.Drawing.Point(25, 235)
        Label_Accounting_money_add_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_4.Size = New System.Drawing.Size(950, 15)
        Label_Accounting_money_add_4.SendToBack()
        Label_Accounting_money_add_4.Text = "________________________________________________________________________________________"
        Label_Accounting_money_add_4.Visible = False
        '
        '
        'Label_Accounting_money_add_5
        Label_Accounting_money_add_5.AutoSize = False
        Label_Accounting_money_add_5.Location = New System.Drawing.Point(400, 280)
        Label_Accounting_money_add_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_5.Size = New System.Drawing.Size(200, 30)
        Label_Accounting_money_add_5.Visible = False
        '
        '
        'Label_Accounting_money_add_6
        Label_Accounting_money_add_6.AutoSize = False
        Label_Accounting_money_add_6.Location = New System.Drawing.Point(25, 335)
        Label_Accounting_money_add_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_6.Size = New System.Drawing.Size(950, 15)
        Label_Accounting_money_add_6.SendToBack()
        Label_Accounting_money_add_6.Text = "________________________________________________________________________________________________________________________________"
        Label_Accounting_money_add_6.Visible = False
        '
        '
        'Label_Accounting_money_add_7
        Label_Accounting_money_add_7.AutoSize = False
        Label_Accounting_money_add_7.Location = New System.Drawing.Point(400, 365)
        Label_Accounting_money_add_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label_Accounting_money_add_7.Size = New System.Drawing.Size(200, 30)
        Label_Accounting_money_add_7.Visible = False
        '
        '
        '
        '
        'TextBox_Accounting_money_add_1
        TextBox_Accounting_money_add_1.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Accounting_money_add_1.Location = New System.Drawing.Point(25, 120)
        TextBox_Accounting_money_add_1.Size = New System.Drawing.Size(950, 30)
        TextBox_Accounting_money_add_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_Accounting_money_add_1.ForeColor = Color.Blue
        TextBox_Accounting_money_add_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        TextBox_Accounting_money_add_1.Visible = False
        '
        '
        'TextBox_Accounting_money_add_2
        TextBox_Accounting_money_add_2.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_Accounting_money_add_2.Location = New System.Drawing.Point(25, 220)
        TextBox_Accounting_money_add_2.Size = New System.Drawing.Size(950, 30)
        TextBox_Accounting_money_add_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_Accounting_money_add_2.ForeColor = Color.Blue
        TextBox_Accounting_money_add_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        TextBox_Accounting_money_add_2.Visible = False
        '
        '
        'TextBox_Accounting_money_add_3
        TextBox_Accounting_money_add_3.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_Accounting_money_add_3.Location = New System.Drawing.Point(25, 320)
        TextBox_Accounting_money_add_3.Size = New System.Drawing.Size(950, 30)
        TextBox_Accounting_money_add_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        TextBox_Accounting_money_add_3.ForeColor = Color.Blue
        TextBox_Accounting_money_add_3.BorderStyle = System.Windows.Forms.BorderStyle.None
        TextBox_Accounting_money_add_3.Visible = False
        '
        '
        '
        '
        'PictureBox_Accounting_add_done
        PictureBox_Accounting_add_done.BackgroundImage = Global.language_class.My.Resources.Resources.checked
        PictureBox_Accounting_add_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_add_done.Location = New System.Drawing.Point(475, 420)
        PictureBox_Accounting_add_done.Size = New System.Drawing.Size(50, 50)
        PictureBox_Accounting_add_done.Visible = False
        '
        '
        '
        '
        'PictureBox_Accounting_edit_choose
        PictureBox_Accounting_edit_choose.BackgroundImage = Global.language_class.My.Resources.Resources.edit
        PictureBox_Accounting_edit_choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_edit_choose.Location = New System.Drawing.Point(900, 10)
        PictureBox_Accounting_edit_choose.Size = New System.Drawing.Size(50, 50)
        PictureBox_Accounting_edit_choose.Visible = False
        '
        '
        'PictureBox_Accounting_delete_choose
        PictureBox_Accounting_delete_choose.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
        PictureBox_Accounting_delete_choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_delete_choose.Location = New System.Drawing.Point(900, 10)
        PictureBox_Accounting_delete_choose.Size = New System.Drawing.Size(50, 50)
        PictureBox_Accounting_delete_choose.Visible = False
        '
        '
        '
        '
        '
        'PictureBox_Accounting_count_amount
        PictureBox_Accounting_count_amount.BackgroundImage = Global.language_class.My.Resources.Resources.abacus
        PictureBox_Accounting_count_amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_count_amount.Location = New System.Drawing.Point(75, 5)
        PictureBox_Accounting_count_amount.Size = New System.Drawing.Size(25, 25)
        PictureBox_Accounting_count_amount.Visible = False
        '
        '
        'PictureBox_Accounting_count_amount_number
        ' PictureBox_Accounting_count_amount_number.BackgroundImage = Global.language_class.My.Resources.Resources.bill
        PictureBox_Accounting_count_amount_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox_Accounting_count_amount_number.Location = New System.Drawing.Point(75, 55)
        PictureBox_Accounting_count_amount_number.Size = New System.Drawing.Size(25, 25)
        PictureBox_Accounting_count_amount_number.Visible = False
        '
        '
        'Label_Accounting_count_amount
        Label_Accounting_count_amount.AutoSize = False
        Label_Accounting_count_amount.Location = New System.Drawing.Point(110, 10)
        Label_Accounting_count_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_count_amount.Size = New System.Drawing.Size(200, 20)
        Label_Accounting_count_amount.Visible = False
        '
        '
        'Label_Accounting_count_amount_number
        Label_Accounting_count_amount_number.AutoSize = False
        Label_Accounting_count_amount_number.Location = New System.Drawing.Point(110, 60)
        Label_Accounting_count_amount_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label_Accounting_count_amount_number.Size = New System.Drawing.Size(200, 20)
        Label_Accounting_count_amount_number.Visible = False
       




    End Sub

    Sub persian_language()
        Label_select_language_s.Font = New System.Drawing.Font("B nazanin", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_select_language_t.Font = New System.Drawing.Font("B nazanin", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))


        CheckBox_en.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_tur.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_spa.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_ita.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_fre.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_arab.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_chi.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_japa.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_kor.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))



        Label_select_language_s.Text = "زبان انتخاب شده توسط دانش آموز برای یادگیری"
        Label_select_language_t.Text = "زبان انتخاب شده توسط معلم برای آموزش"


        CheckBox_en.Text = "انگلیسی"
        CheckBox_tur.Text = "ترکی"
        CheckBox_spa.Text = "اسپانیایی"
        CheckBox_ita.Text = "ایتالیایی"
        CheckBox_fre.Text = "فرانسه ای"
        CheckBox_arab.Text = "عربی"
        CheckBox_chi.Text = "چینی"
        CheckBox_japa.Text = "ژاپنی"
        CheckBox_kor.Text = "کره ای"

        ToolTip_main.SetToolTip(PictureBox_select_language_next_level, "مرحله بعد")
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Me.IdDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.IdDataGridViewTextBoxColumn.ToolTipText = "کد کاربری دانش آموز"

        Me.NamesDataGridViewTextBoxColumn.HeaderText = "نام دانش آموز"
        Me.NamesDataGridViewTextBoxColumn.ToolTipText = "نام و نام خانوادگی دانش آموز"

        Me.FathernamesDataGridViewTextBoxColumn.HeaderText = "نام پدر"
        Me.FathernamesDataGridViewTextBoxColumn.ToolTipText = "نام و نام خانوادگی پدر"

        Me.MothernamesDataGridViewTextBoxColumn.HeaderText = "نام مادر"
        Me.MothernamesDataGridViewTextBoxColumn.ToolTipText = "نام و نام خانوادگی مادر"

        Me.PhonesDataGridViewTextBoxColumn.HeaderText = "تلفن دانش آموز"
        Me.PhonesDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن همراه دانش آموز"

        Me.PhonefathersDataGridViewTextBoxColumn.HeaderText = "تلفن پدر"
        Me.PhonefathersDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن همراه پدر"

        Me.PhonemothersDataGridViewTextBoxColumn.HeaderText = "تلفن مادر"
        Me.PhonemothersDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن همراه مادر"

        Me.TelephonesDataGridViewTextBoxColumn.HeaderText = "تلفن منزل"
        Me.TelephonesDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن منزل"

        Me.AddresssDataGridViewTextBoxColumn.HeaderText = "آدرس منزل"
        Me.AddresssDataGridViewTextBoxColumn.ToolTipText = "آدرس منزل"

        Me.NationalcodesDataGridViewTextBoxColumn.HeaderText = "کد ملی"
        Me.NationalcodesDataGridViewTextBoxColumn.ToolTipText = "کد ملی"

        Me.BirthdaysDataGridViewTextBoxColumn.HeaderText = "تاریخ تولد"
        Me.BirthdaysDataGridViewTextBoxColumn.ToolTipText = "تاریخ تولد دانش آموز"

        Me.DatesDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت نام"
        Me.DatesDataGridViewTextBoxColumn.ToolTipText = "تاریخ ثبت نام دانش آموز"

        Me.GendersDataGridViewTextBoxColumn.HeaderText = "جنسیت"
        Me.GendersDataGridViewTextBoxColumn.ToolTipText = "جنسیت"


        Me.LanguagesDataGridViewTextBoxColumn.HeaderText = "زبان"
        Me.LanguagesDataGridViewTextBoxColumn.ToolTipText = "زبان انتخاب شده توسط دانش آموز برای یادگیری"

        Me.BooklevelsDataGridViewTextBoxColumn.HeaderText = "سطح کتاب"
        Me.BooklevelsDataGridViewTextBoxColumn.ToolTipText = "سطح کتاب "
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "کد"
        Me.IdDataGridViewTextBoxColumn1.ToolTipText = "کد کاربری معلم"

        Me.NametDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.NametDataGridViewTextBoxColumn.ToolTipText = "نام معلم"

        Me.LastnametDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی"
        Me.LastnametDataGridViewTextBoxColumn.ToolTipText = "نام خانوادگی معلم"

        Me.PhonetDataGridViewTextBoxColumn.HeaderText = "تلفن همراه"
        Me.PhonetDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن تلفن همراه"

        Me.TelephonetDataGridViewTextBoxColumn.HeaderText = "تلفن منزل"
        Me.TelephonetDataGridViewTextBoxColumn.ToolTipText = "شماره تلفن منزل"

        Me.AddresstDataGridViewTextBoxColumn.HeaderText = "آدرس منزل"
        Me.AddresstDataGridViewTextBoxColumn.ToolTipText = "آدرس منزل"

        Me.NationalcodetDataGridViewTextBoxColumn.HeaderText = "کد ملی"
        Me.NationalcodetDataGridViewTextBoxColumn.ToolTipText = "کد ملی"

        Me.EvidencetDataGridViewTextBoxColumn.HeaderText = "تحصیلات"
        Me.EvidencetDataGridViewTextBoxColumn.ToolTipText = "سطح تحصیلات (مدرک)"

        Me.BirthdaytDataGridViewTextBoxColumn.HeaderText = "تاریخ تولد"
        Me.BirthdaytDataGridViewTextBoxColumn.ToolTipText = "تاریخ تولد"

        Me.DatatDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت نام"
        Me.DatatDataGridViewTextBoxColumn.ToolTipText = "تاریخ ثبت نام"

        Me.GendertDataGridViewTextBoxColumn.HeaderText = "جنسیت"
        Me.GendertDataGridViewTextBoxColumn.ToolTipText = "جنسیت"

        Me.LanguagetDataGridViewTextBoxColumn.HeaderText = "زبان"
        Me.LanguagetDataGridViewTextBoxColumn.ToolTipText = "زبان انتخاب شده توسط معلم برای آموزش"
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        Me.Id_mony_incoming_farvardin.HeaderText = "شماره"
        Me.Id_mony_incoming_farvardin.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_farvardin.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_farvardin.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_farvardin.HeaderText = "از طرف"
        Me.Person_mony_incoming_farvardin.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_farvardin.HeaderText = "بابت"
        Me.Forr_mony_incoming_farvardin.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_farvardin.HeaderText = "تاریخ"
        Me.Data_mony_incoming_farvardin.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_farvardin.HeaderText = "ساعت"
        Me.Time_mony_incoming_farvardin.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_ordibehesht.HeaderText = "شماره"
        Me.Id_mony_incoming_ordibehesht.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_ordibehesht.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_ordibehesht.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_ordibehesht.HeaderText = "از طرف"
        Me.Person_mony_incoming_ordibehesht.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_ordibehesht.HeaderText = "بابت"
        Me.Forr_mony_incoming_ordibehesht.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_ordibehesht.HeaderText = "تاریخ"
        Me.Data_mony_incoming_ordibehesht.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_ordibehesht.HeaderText = "ساعت"
        Me.Time_mony_incoming_ordibehesht.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_khordad.HeaderText = "شماره"
        Me.Id_mony_incoming_khordad.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_khordad.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_khordad.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_khordad.HeaderText = "از طرف"
        Me.Person_mony_incoming_khordad.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_khordad.HeaderText = "بابت"
        Me.Forr_mony_incoming_khordad.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_khordad.HeaderText = "تاریخ"
        Me.Data_mony_incoming_khordad.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_khordad.HeaderText = "ساعت"
        Me.Time_mony_incoming_khordad.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_tir.HeaderText = "شماره"
        Me.Id_mony_incoming_tir.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_tir.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_tir.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_tir.HeaderText = "از طرف"
        Me.Person_mony_incoming_tir.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_tir.HeaderText = "بابت"
        Me.Forr_mony_incoming_tir.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_tir.HeaderText = "تاریخ"
        Me.Data_mony_incoming_tir.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_tir.HeaderText = "ساعت"
        Me.Time_mony_incoming_tir.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_mordad.HeaderText = "شماره"
        Me.Id_mony_incoming_mordad.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_mordad.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_mordad.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_mordad.HeaderText = "از طرف"
        Me.Person_mony_incoming_mordad.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_mordad.HeaderText = "بابت"
        Me.Forr_mony_incoming_mordad.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_mordad.HeaderText = "تاریخ"
        Me.Data_mony_incoming_mordad.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_mordad.HeaderText = "ساعت"
        Me.Time_mony_incoming_mordad.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_shahrivar.HeaderText = "شماره"
        Me.Id_mony_incoming_shahrivar.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_shahrivar.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_shahrivar.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_shahrivar.HeaderText = "از طرف"
        Me.Person_mony_incoming_shahrivar.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_shahrivar.HeaderText = "بابت"
        Me.Forr_mony_incoming_shahrivar.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_shahrivar.HeaderText = "تاریخ"
        Me.Data_mony_incoming_shahrivar.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_shahrivar.HeaderText = "ساعت"
        Me.Time_mony_incoming_shahrivar.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_mehr.HeaderText = "شماره"
        Me.Id_mony_incoming_mehr.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_mehr.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_mehr.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_mehr.HeaderText = "از طرف"
        Me.Person_mony_incoming_mehr.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_mehr.HeaderText = "بابت"
        Me.Forr_mony_incoming_mehr.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_mehr.HeaderText = "تاریخ"
        Me.Data_mony_incoming_mehr.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_mehr.HeaderText = "ساعت"
        Me.Time_mony_incoming_mehr.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_aban.HeaderText = "شماره"
        Me.Id_mony_incoming_aban.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_aban.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_aban.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_aban.HeaderText = "از طرف"
        Me.Person_mony_incoming_aban.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_aban.HeaderText = "بابت"
        Me.Forr_mony_incoming_aban.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_aban.HeaderText = "تاریخ"
        Me.Data_mony_incoming_aban.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_aban.HeaderText = "ساعت"
        Me.Time_mony_incoming_aban.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_azar.HeaderText = "شماره"
        Me.Id_mony_incoming_azar.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_azar.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_azar.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_azar.HeaderText = "از طرف"
        Me.Person_mony_incoming_azar.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_azar.HeaderText = "بابت"
        Me.Forr_mony_incoming_azar.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_azar.HeaderText = "تاریخ"
        Me.Data_mony_incoming_azar.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_azar.HeaderText = "ساعت"
        Me.Time_mony_incoming_azar.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_dey.HeaderText = "شماره"
        Me.Id_mony_incoming_dey.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_dey.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_dey.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_dey.HeaderText = "از طرف"
        Me.Person_mony_incoming_dey.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_dey.HeaderText = "بابت"
        Me.Forr_mony_incoming_dey.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_dey.HeaderText = "تاریخ"
        Me.Data_mony_incoming_dey.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_dey.HeaderText = "ساعت"
        Me.Time_mony_incoming_dey.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_bahman.HeaderText = "شماره"
        Me.Id_mony_incoming_bahman.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_bahman.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_bahman.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_bahman.HeaderText = "از طرف"
        Me.Person_mony_incoming_bahman.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_bahman.HeaderText = "بابت"
        Me.Forr_mony_incoming_bahman.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_bahman.HeaderText = "تاریخ"
        Me.Data_mony_incoming_bahman.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_bahman.HeaderText = "ساعت"
        Me.Time_mony_incoming_bahman.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_incoming_esfand.HeaderText = "شماره"
        Me.Id_mony_incoming_esfand.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_incoming_esfand.HeaderText = "مبلغ"
        Me.Amount_mony_incoming_esfand.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_incoming_esfand.HeaderText = "از طرف"
        Me.Person_mony_incoming_esfand.ToolTipText = "شخص واریز کننده"
        Me.Forr_mony_incoming_esfand.HeaderText = "بابت"
        Me.Forr_mony_incoming_esfand.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_incoming_esfand.HeaderText = "تاریخ"
        Me.Data_mony_incoming_esfand.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_incoming_esfand.HeaderText = "ساعت"
        Me.Time_mony_incoming_esfand.ToolTipText = "ساعت تراکنش"








        Me.Id_mony_Output_farvardin.HeaderText = "شماره"
        Me.Id_mony_Output_farvardin.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_farvardin.HeaderText = "مبلغ"
        Me.Amount_mony_Output_farvardin.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_farvardin.HeaderText = "به"
        Me.Person_mony_Output_farvardin.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_farvardin.HeaderText = "برای"
        Me.Forr_mony_Output_farvardin.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_farvardin.HeaderText = "تاریخ"
        Me.Data_mony_Output_farvardin.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_farvardin.HeaderText = "ساعت"
        Me.Time_mony_Output_farvardin.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_ordibehesht.HeaderText = "شماره"
        Me.Id_mony_Output_ordibehesht.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_ordibehesht.HeaderText = "مبلغ"
        Me.Amount_mony_Output_ordibehesht.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_ordibehesht.HeaderText = "به"
        Me.Person_mony_Output_ordibehesht.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_ordibehesht.HeaderText = "برای"
        Me.Forr_mony_Output_ordibehesht.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_ordibehesht.HeaderText = "تاریخ"
        Me.Data_mony_Output_ordibehesht.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_ordibehesht.HeaderText = "ساعت"
        Me.Time_mony_Output_ordibehesht.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_khordad.HeaderText = "شماره"
        Me.Id_mony_Output_khordad.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_khordad.HeaderText = "مبلغ"
        Me.Amount_mony_Output_khordad.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_khordad.HeaderText = "به"
        Me.Person_mony_Output_khordad.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_khordad.HeaderText = "برای"
        Me.Forr_mony_Output_khordad.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_khordad.HeaderText = "تاریخ"
        Me.Data_mony_Output_khordad.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_khordad.HeaderText = "ساعت"
        Me.Time_mony_Output_khordad.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_tir.HeaderText = "شماره"
        Me.Id_mony_Output_tir.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_tir.HeaderText = "مبلغ"
        Me.Amount_mony_Output_tir.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_tir.HeaderText = "به"
        Me.Person_mony_Output_tir.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_tir.HeaderText = "برای"
        Me.Forr_mony_Output_tir.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_tir.HeaderText = "تاریخ"
        Me.Data_mony_Output_tir.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_tir.HeaderText = "ساعت"
        Me.Time_mony_Output_tir.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_mordad.HeaderText = "شماره"
        Me.Id_mony_Output_mordad.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_mordad.HeaderText = "مبلغ"
        Me.Amount_mony_Output_mordad.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_mordad.HeaderText = "به"
        Me.Person_mony_Output_mordad.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_mordad.HeaderText = "برای"
        Me.Forr_mony_Output_mordad.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_mordad.HeaderText = "تاریخ"
        Me.Data_mony_Output_mordad.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_mordad.HeaderText = "ساعت"
        Me.Time_mony_Output_mordad.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_shahrivar.HeaderText = "شماره"
        Me.Id_mony_Output_shahrivar.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_shahrivar.HeaderText = "مبلغ"
        Me.Amount_mony_Output_shahrivar.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_shahrivar.HeaderText = "به"
        Me.Person_mony_Output_shahrivar.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_shahrivar.HeaderText = "برای"
        Me.Forr_mony_Output_shahrivar.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_shahrivar.HeaderText = "تاریخ"
        Me.Data_mony_Output_shahrivar.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_shahrivar.HeaderText = "ساعت"
        Me.Time_mony_Output_shahrivar.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_mehr.HeaderText = "شماره"
        Me.Id_mony_Output_mehr.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_mehr.HeaderText = "مبلغ"
        Me.Amount_mony_Output_mehr.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_mehr.HeaderText = "به"
        Me.Person_mony_Output_mehr.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_mehr.HeaderText = "برای"
        Me.Forr_mony_Output_mehr.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_mehr.HeaderText = "تاریخ"
        Me.Data_mony_Output_mehr.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_mehr.HeaderText = "ساعت"
        Me.Time_mony_Output_mehr.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_aban.HeaderText = "شماره"
        Me.Id_mony_Output_aban.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_aban.HeaderText = "مبلغ"
        Me.Amount_mony_Output_aban.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_aban.HeaderText = "به"
        Me.Person_mony_Output_aban.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_aban.HeaderText = "برای"
        Me.Forr_mony_Output_aban.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_aban.HeaderText = "تاریخ"
        Me.Data_mony_Output_aban.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_aban.HeaderText = "ساعت"
        Me.Time_mony_Output_aban.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_azar.HeaderText = "شماره"
        Me.Id_mony_Output_azar.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_azar.HeaderText = "مبلغ"
        Me.Amount_mony_Output_azar.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_azar.HeaderText = "به"
        Me.Person_mony_Output_azar.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_azar.HeaderText = "برای"
        Me.Forr_mony_Output_azar.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_azar.HeaderText = "تاریخ"
        Me.Data_mony_Output_azar.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_azar.HeaderText = "ساعت"
        Me.Time_mony_Output_azar.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_dey.HeaderText = "شماره"
        Me.Id_mony_Output_dey.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_dey.HeaderText = "مبلغ"
        Me.Amount_mony_Output_dey.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_dey.HeaderText = "به"
        Me.Person_mony_Output_dey.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_dey.HeaderText = "برای"
        Me.Forr_mony_Output_dey.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_dey.HeaderText = "تاریخ"
        Me.Data_mony_Output_dey.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_dey.HeaderText = "ساعت"
        Me.Time_mony_Output_dey.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_bahman.HeaderText = "شماره"
        Me.Id_mony_Output_bahman.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_bahman.HeaderText = "مبلغ"
        Me.Amount_mony_Output_bahman.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_bahman.HeaderText = "به"
        Me.Person_mony_Output_bahman.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_bahman.HeaderText = "برای"
        Me.Forr_mony_Output_bahman.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_bahman.HeaderText = "تاریخ"
        Me.Data_mony_Output_bahman.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_bahman.HeaderText = "ساعت"
        Me.Time_mony_Output_bahman.ToolTipText = "ساعت تراکنش"

        Me.Id_mony_Output_esfand.HeaderText = "شماره"
        Me.Id_mony_Output_esfand.ToolTipText = "شماره تراکنش"
        Me.Amount_mony_Output_esfand.HeaderText = "مبلغ"
        Me.Amount_mony_Output_esfand.ToolTipText = "مقدار مبلغ تراکنش"
        Me.Person_mony_Output_esfand.HeaderText = "به"
        Me.Person_mony_Output_esfand.ToolTipText = "شخص واریز شده"
        Me.Forr_mony_Output_esfand.HeaderText = "برای"
        Me.Forr_mony_Output_esfand.ToolTipText = "توضیحات پول واریز شده"
        Me.Data_mony_Output_esfand.HeaderText = "تاریخ"
        Me.Data_mony_Output_esfand.ToolTipText = "تاریخ تراکنش"
        Me.Time_mony_Output_esfand.HeaderText = "ساعت"
        Me.Time_mony_Output_esfand.ToolTipText = "ساعت تراکنش"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_title.Font = New System.Drawing.Font("B Roya", 40.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_title.Text = "موسسه زبان هامون"
        Label_title.Location = New System.Drawing.Point(150, 0)
        Label_title.Size = New System.Drawing.Size(700, 90)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        If Button_edit_s.Visible = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "کمتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
        End If
        If Button_edit_t.Visible = True Then
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "کمتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        End If

        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Button_students.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_teachers.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_add_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_edit_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_delete_s.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_add_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_edit_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Button_delete_t.Font = New System.Drawing.Font("B Roya", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        Button_students.Text = " لیست دانش آموزان"
        Button_teachers.Text = "لیست معلم ها"
        Button_add_s.Text = "ثبت نام دانش آموزان"
        Button_edit_s.Text = "ویرایش"
        Button_delete_s.Text = "حذف"
        Button_add_t.Text = "ثبت نام معلم ها"
        Button_edit_t.Text = "ویرایش"
        Button_delete_t.Text = "حذف"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_name_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_father_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_name_mother_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_father_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_mother_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_telephone.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_address.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_date.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_datebirth.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_codemeli_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_level_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_language_s_edit.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_gender_s.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        Label_name_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_father_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_name_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_father_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_telephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_datebirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_codemeli_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_level_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_gender_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        Label_name_s.Location = New System.Drawing.Point(710, 35)
        Label_name_father_s.Location = New System.Drawing.Point(710, 90)
        Label_name_mother_s.Location = New System.Drawing.Point(710, 145)
        Label_phone_s.Location = New System.Drawing.Point(710, 200)
        Label_phone_father_s.Location = New System.Drawing.Point(710, 255)
        Label_phone_mother_s.Location = New System.Drawing.Point(710, 310)
        Label_telephone.Location = New System.Drawing.Point(710, 365)
        Label_address.Location = New System.Drawing.Point(235, 35)
        Label_codemeli_s.Location = New System.Drawing.Point(235, 90)
        Label_datebirth.Location = New System.Drawing.Point(235, 145)
        Label_date.Location = New System.Drawing.Point(235, 200)
        Label_gender_s.Location = New System.Drawing.Point(235, 255)
        Label_level_s.Location = New System.Drawing.Point(235, 310)
        Label_language_s_edit.Location = New System.Drawing.Point(235, 365)
        '
        '
        Label_name_s.Text = "نام و نام خانوادگی دانش آموز:"
        Label_name_father_s.Text = "نام و نام خانوادگی پدر:"
        Label_name_mother_s.Text = "نام و نام خانوادگی مادر:"
        Label_phone_s.Text = "تلفن همراه دانش آموز:"
        Label_phone_father_s.Text = "تلفن همراه پدر:"
        Label_phone_mother_s.Text = "تلفن همراه مادر:"
        Label_telephone.Text = "تلفن منزل:"
        Label_address.Text = "آدرس منزل:"
        Label_date.Text = "تاریخ ثبت نام:"
        Label_datebirth.Text = "تاریخ تولد:"
        Label_codemeli_s.Text = "کد ملی:"
        Label_level_s.Text = "سطح کتاب:"
        Label_language_s_edit.Text = "زبان:"
        Label_gender_s.Text = "جنسیت:"
        '
        '
        TextBox_name_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_father_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_name_mother_s.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_father_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_mother_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_telephone.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_address.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_codemeli_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        TextBox_name_s.Location = New System.Drawing.Point(500, 40)
        TextBox_name_father_s.Location = New System.Drawing.Point(500, 95)
        TextBox_name_mother_s.Location = New System.Drawing.Point(500, 150)
        TextBox_phone_s.Location = New System.Drawing.Point(500, 205)
        TextBox_phone_father_s.Location = New System.Drawing.Point(500, 260)
        TextBox_phone_mother_s.Location = New System.Drawing.Point(500, 315)
        TextBox_telephone.Location = New System.Drawing.Point(500, 370)
        TextBox_address.Location = New System.Drawing.Point(35, 40)
        TextBox_codemeli_s.Location = New System.Drawing.Point(35, 95)
        TextBox_datebirth_s_year.Location = New System.Drawing.Point(95, 150)
        TextBox_datebirth_s_month.Location = New System.Drawing.Point(155, 150)
        TextBox_datebirth_s_day.Location = New System.Drawing.Point(200, 150)
        TextBox_date_s_year.Location = New System.Drawing.Point(95, 205)
        TextBox_date_s_month.Location = New System.Drawing.Point(155, 205)
        TextBox_date_s_day.Location = New System.Drawing.Point(200, 205)
        '
        '
        ComboBox_language_s_edit.Location = New System.Drawing.Point(35, 370)
        ComboBox_level_s.Location = New System.Drawing.Point(35, 315)
        ComboBox_level_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ComboBox_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        TextBox_level_s.Location = New System.Drawing.Point(35, 312)
        PictureBox_level_s.Location = New System.Drawing.Point(10, 315)
        ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت دستی")
        '
        '
        RadioButton_male_s.Location = New System.Drawing.Point(135, 260)
        RadioButton_female_s.Location = New System.Drawing.Point(35, 260)
        RadioButton_male_s.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_female_s.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_male_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        RadioButton_female_s.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        RadioButton_male_s.Text = "مرد"
        RadioButton_female_s.Text = "زن"
        TextBox_gender_s.Location = New System.Drawing.Point(10, 260)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_name_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_lastname_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_phone_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_telephone_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_address_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_datebirth_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_date_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_codemeli_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_evidence.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_gender_t.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_language_t_edit.Font = New System.Drawing.Font("B nazanin", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        Label_name_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_lastname_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_phone_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_telephone_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_address_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_datebirth_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_date_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_codemeli_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_evidence.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_gender_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        Label_name_t.Location = New System.Drawing.Point(800, 35)
        Label_lastname_t.Location = New System.Drawing.Point(800, 90)
        Label_phone_t.Location = New System.Drawing.Point(800, 145)
        Label_telephone_t.Location = New System.Drawing.Point(800, 200)
        Label_address_t.Location = New System.Drawing.Point(800, 255)
        Label_codemeli_t.Location = New System.Drawing.Point(790, 310)
        Label_evidence.Location = New System.Drawing.Point(790, 365)
        Label_datebirth_t.Location = New System.Drawing.Point(235, 35)
        Label_date_t.Location = New System.Drawing.Point(235, 90)
        Label_gender_t.Location = New System.Drawing.Point(235, 145)
        Label_language_t_edit.Location = New System.Drawing.Point(235, 200)
        '
        '
        Label_name_t.Text = "نام:"
        Label_lastname_t.Text = "نام خانوادگی:"
        Label_phone_t.Text = "شماره همراه:"
        Label_telephone_t.Text = "تلفن منزل:"
        Label_address_t.Text = "آدرس:"
        Label_datebirth_t.Text = "تاریخ تولد:"
        Label_date_t.Text = "تاریخ استخدام:"
        Label_codemeli_t.Text = "کد ملی:"
        Label_evidence.Text = "سطح تحصیلات:"
        Label_gender_t.Text = "جنسیت:"
        Label_language_t_edit.Text = "زبان:"
        '
        '
        TextBox_name_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_lastname_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_phone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_telephone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_address_t.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        TextBox_codemeli_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_evidence.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        TextBox_name_t.Location = New System.Drawing.Point(590, 40)
        TextBox_lastname_t.Location = New System.Drawing.Point(590, 95)
        TextBox_phone_t.Location = New System.Drawing.Point(590, 150)
        TextBox_telephone_t.Location = New System.Drawing.Point(590, 205)
        TextBox_address_t.Location = New System.Drawing.Point(590, 260)
        TextBox_codemeli_t.Location = New System.Drawing.Point(590, 315)
        TextBox_evidence.Location = New System.Drawing.Point(590, 370)
        TextBox_datebirth_t_day.Location = New System.Drawing.Point(200, 40)
        TextBox_datebirth_t_month.Location = New System.Drawing.Point(155, 40)
        TextBox_datebirth_t_year.Location = New System.Drawing.Point(95, 40)
        TextBox_date_t_day.Location = New System.Drawing.Point(200, 95)
        TextBox_date_t_month.Location = New System.Drawing.Point(155, 95)
        TextBox_date_t_year.Location = New System.Drawing.Point(95, 95)
        '
        '
        RadioButton_male_t.Location = New System.Drawing.Point(135, 150)
        RadioButton_female_t.Location = New System.Drawing.Point(35, 150)
        RadioButton_male_t.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_female_t.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        RadioButton_male_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        RadioButton_female_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        RadioButton_male_t.Text = "مرد"
        RadioButton_female_t.Text = "زن"
        TextBox_gender_t.Location = New System.Drawing.Point(10, 150)
        '
        '
        '
        ComboBox_language_t_edit.Location = New System.Drawing.Point(35, 205)
        ComboBox_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_language.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Radio_persian.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Radio_english.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_music.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ToolTip_main.SetToolTip(PictureBox_setting, "تنظیمات")
        ToolTip_main.SetToolTip(PictureBox_about_us, "درباره ما")
        GroupBox_setting.Text = "تنظیمات"
        Label_language.Text = "زبان برنامه"
        Radio_persian.Text = "فارسی"
        Radio_english.Text = "انگلیسی"
        Label_music.Text = "موزیک"
        Label_change_password.Text = "تغییر رمز"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_programmer_name_B.Font = New System.Drawing.Font("B Siavash", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(17, Byte))
        Label_programmer_name_D.Font = New System.Drawing.Font("B Siavash", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(17, Byte))
        Label_programmer_name_B.Text = "دانیال خدارحمی"
        Label_programmer_name_D.Text = "دانیال خدارحمی"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        PictureBox_back_to_home_from_registration_students.Location = New System.Drawing.Point(10, 420)
        PictureBox_complete_registration_students.Location = New System.Drawing.Point(70, 420)
        PictureBox_back_to_home_from_registration_teachers.Location = New System.Drawing.Point(10, 420)
        PictureBox_complete_registration_teachers.Location = New System.Drawing.Point(70, 420)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_change_password_1.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password_2.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password_1.Text = "رمز جدید"
        Label_change_password_2.Text = "تکرار رمز جدید"
        Label_change_password_error.Text = "عدم مطابقت فیلد ها"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_edit.Text = "ویرایش"
        '
        '
        '
        '
        ToolTip_main.SetToolTip(PictureBox_level_test, "آزمون تعیین سطح")
        ToolTip_main.SetToolTip(PictureBox_b_f_level_test, "خانه")
        '
        '
        '
        '
        Label_forgotten_password.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_forgotten_password.Text = "بازیابی رمز عبور"
        '
        '
        '
        '
        Label_return_password.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_show, "آمار های نموداری")
        '
        '
        Label_charts_show_explain_in_all.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_charts_show_explain_in_all.Text = "در اینجا شما میتوانید با انتخاب یکی از گزینه ها به آمارهای نموداری زبان آموزان یا معلم ها یا هردوی آنها دسترسی داشته باشید"
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_show_all, "آمار های نموداری زبان آموزان و معلمان")
        ToolTip_main.SetToolTip(PictureBox_charts_show_teachers, "آمار های نموداری معلمان")
        ToolTip_main.SetToolTip(PictureBox_charts_show_students, "آمار های نموداری زبان آموزان")
        '
        '
        Chart_students.Series(0).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Chart_students.Series(1).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Chart_teachers.Series(0).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Chart_teachers.Series(1).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Chart_all.Series(0).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Chart_all.Series(1).Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        '
        Label_charts_choose_language.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_charts_choose_gender.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_charts_choose_birthday.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_charts_choose_date_of_registration.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ToolTip_main.SetToolTip(Label_charts_choose_language, "آمار های نموداری بر اساس زبان انتخاب شده")
        ToolTip_main.SetToolTip(Label_charts_choose_gender, "آمار های نموداری بر اساس جنسیت افراد")
        ToolTip_main.SetToolTip(Label_charts_choose_birthday, "آمار های نموداری بر اساس سن افراد")
        ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "آمار های نموداری بر اساس تاریخ ثبت نام")
        Label_charts_choose_language.Text = "زبان"
        Label_charts_choose_gender.Text = "جنسیت"
        Label_charts_choose_birthday.Text = "سن"
        Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_change_type, "تغییر شکل نمودار")
        ToolTip_main.SetToolTip(PictureBox_charts_change_color, "تغییر رنگ نمودار")
        '
        '
        '
        '
        ToolTip_main.SetToolTip(PictureBox_Part_charts_tips, "راهنمایی")
        Label_Part_charts_tips_1.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Part_charts_tips_2.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Part_charts_tips_3.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Part_charts_tips_4.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Part_charts_tips_5.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Part_charts_tips_1.Text = "👆" & "تعیین حالت سه بعدی و دوبعدی"
        Label_Part_charts_tips_2.Text = "برگرداندن تنظیمات نمودار به حالت پیش فرض" & "👉"
        Label_Part_charts_tips_3.Text = "👉" & vbNewLine & "در اینجا شما میتوانید با حرکت دادن فلش آبی رنگ به 12 مدل رنگ بندی مختلف برای نمودار دسترسی داشته باشید"
        Label_Part_charts_tips_4.Text = "👈" & vbNewLine & "در اینجا شما میتوانید با حرکت دادن فلش آبی رنگ به 17 مدل مختلف نمودار دسترسی داشته باشید"
        Label_Part_charts_tips_5.Text = "شما میتوانید با نگه داشتن موس خود بر روی بخش های مختلف نمودار به اطلاعات مفیدی دسترسی داشته باشید" & vbNewLine & "👇"
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Label_Accounting_farvardin.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_ordibehesht.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_khordad.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_tir.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_mordad.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_shahrivar.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_mehr.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_aban.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_azar.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_dey.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_bahman.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_esfand.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_farvardin.Text = "فروردین"
        Label_Accounting_ordibehesht.Text = "اردیبهشت"
        Label_Accounting_khordad.Text = "خرداد"
        Label_Accounting_tir.Text = "تیر"
        Label_Accounting_mordad.Text = "مرداد"
        Label_Accounting_shahrivar.Text = "شهریور"
        Label_Accounting_mehr.Text = "مهر"
        Label_Accounting_aban.Text = "آبان"
        Label_Accounting_azar.Text = "آذر"
        Label_Accounting_dey.Text = "دی"
        Label_Accounting_bahman.Text = "بهمن"
        Label_Accounting_esfand.Text = "اسفند"
        '
        '
        '
        '
        '
        '
        Label_Accounting_money_add_1.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_money_add_3.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_money_add_5.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_money_add_7.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_Accounting_money_add_1.Text = "مبلغ"
        Label_Accounting_money_add_3.Text = "از طرف"
        Label_Accounting_money_add_5.Text = "بابت"
        Label_Accounting_money_add_7.Text = "دریافت شد"
    
    End Sub
    Sub English_language()
        Label_select_language_s.Font = New System.Drawing.Font("Sylfaen", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_select_language_t.Font = New System.Drawing.Font("Sylfaen", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))


        CheckBox_en.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_tur.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_spa.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_ita.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_fre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_arab.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_chi.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_japa.Font = New System.Drawing.Font("Sylfaen", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        CheckBox_kor.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))



        Label_select_language_s.Text = "Language chosen by the student to learn"
        Label_select_language_t.Text = "Language chosen by the teacher to teach"


        CheckBox_en.Text = "English"
        CheckBox_tur.Text = "Turkish"
        CheckBox_spa.Text = "Spanish"
        CheckBox_ita.Text = "Italian"
        CheckBox_fre.Text = "French"
        CheckBox_arab.Text = "Arabic"
        CheckBox_chi.Text = "Chinese"
        CheckBox_japa.Text = "Japanese"
        CheckBox_kor.Text = "Korean"

        ToolTip_main.SetToolTip(PictureBox_select_language_next_level, "Next level")
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.IdDataGridViewTextBoxColumn.ToolTipText = "Student's user code"

        Me.NamesDataGridViewTextBoxColumn.HeaderText = "Student's name"
        Me.NamesDataGridViewTextBoxColumn.ToolTipText = "Student's name and last name"

        Me.FathernamesDataGridViewTextBoxColumn.HeaderText = "Father's name"
        Me.FathernamesDataGridViewTextBoxColumn.ToolTipText = "Father's name and last name"

        Me.MothernamesDataGridViewTextBoxColumn.HeaderText = "Mother's name"
        Me.MothernamesDataGridViewTextBoxColumn.ToolTipText = "Mother's name and last name"

        Me.PhonesDataGridViewTextBoxColumn.HeaderText = "Student's Phone"
        Me.PhonesDataGridViewTextBoxColumn.ToolTipText = "Student's Phone number"

        Me.PhonefathersDataGridViewTextBoxColumn.HeaderText = "Father's Phone"
        Me.PhonefathersDataGridViewTextBoxColumn.ToolTipText = "Father's Phone number"

        Me.PhonemothersDataGridViewTextBoxColumn.HeaderText = "Mother's Phone"
        Me.PhonemothersDataGridViewTextBoxColumn.ToolTipText = "Mother's Phone number"

        Me.TelephonesDataGridViewTextBoxColumn.HeaderText = "Home's Phone"
        Me.TelephonesDataGridViewTextBoxColumn.ToolTipText = "Home's Phone number"

        Me.AddresssDataGridViewTextBoxColumn.HeaderText = "Home address"
        Me.AddresssDataGridViewTextBoxColumn.ToolTipText = "Home address"

        Me.NationalcodesDataGridViewTextBoxColumn.HeaderText = "National ID"
        Me.NationalcodesDataGridViewTextBoxColumn.ToolTipText = "National ID"

        Me.BirthdaysDataGridViewTextBoxColumn.HeaderText = "Date of birth"
        Me.BirthdaysDataGridViewTextBoxColumn.ToolTipText = "Student's Birthday"

        Me.DatesDataGridViewTextBoxColumn.HeaderText = "Date of Registration"
        Me.DatesDataGridViewTextBoxColumn.ToolTipText = "Student's registration date"

        Me.GendersDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GendersDataGridViewTextBoxColumn.ToolTipText = "Gender"

        Me.LanguagesDataGridViewTextBoxColumn.HeaderText = "Language"
        Me.LanguagesDataGridViewTextBoxColumn.ToolTipText = "Language chosen by the student to learn"

        Me.BooklevelsDataGridViewTextBoxColumn.HeaderText = "Book's level"
        Me.BooklevelsDataGridViewTextBoxColumn.ToolTipText = "Book's level"
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "code"
        Me.IdDataGridViewTextBoxColumn1.ToolTipText = "Teacher's user code"

        Me.NametDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NametDataGridViewTextBoxColumn.ToolTipText = "Teacher's name"

        Me.LastnametDataGridViewTextBoxColumn.HeaderText = "Last name"
        Me.LastnametDataGridViewTextBoxColumn.ToolTipText = "Teacher's last name"

        Me.PhonetDataGridViewTextBoxColumn.HeaderText = "Teacher's Phone"
        Me.PhonetDataGridViewTextBoxColumn.ToolTipText = "Teacher's Phone number"

        Me.TelephonetDataGridViewTextBoxColumn.HeaderText = "Home's Phone"
        Me.TelephonetDataGridViewTextBoxColumn.ToolTipText = "Home's Phone number"

        Me.AddresstDataGridViewTextBoxColumn.HeaderText = "Home address"
        Me.AddresstDataGridViewTextBoxColumn.ToolTipText = "Home address"

        Me.NationalcodetDataGridViewTextBoxColumn.HeaderText = "National ID"
        Me.NationalcodetDataGridViewTextBoxColumn.ToolTipText = "National ID"

        Me.EvidencetDataGridViewTextBoxColumn.HeaderText = "Education"
        Me.EvidencetDataGridViewTextBoxColumn.ToolTipText = "Teacher's Education level(Evidence)"

        Me.BirthdaytDataGridViewTextBoxColumn.HeaderText = "Date of birth"
        Me.BirthdaytDataGridViewTextBoxColumn.ToolTipText = "Student's Birthday"

        Me.DatatDataGridViewTextBoxColumn.HeaderText = "Date of Registration"
        Me.DatatDataGridViewTextBoxColumn.ToolTipText = "Student's registration date"

        Me.GendertDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GendertDataGridViewTextBoxColumn.ToolTipText = "Gender"

        Me.LanguagetDataGridViewTextBoxColumn.HeaderText = "Language"
        Me.LanguagetDataGridViewTextBoxColumn.ToolTipText = "Language chosen by the teacher to teach"
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        ''''''''***
        Me.Id_mony_incoming_farvardin.HeaderText = "Number"
        Me.Id_mony_incoming_farvardin.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_farvardin.HeaderText = "Amount"
        Me.Amount_mony_incoming_farvardin.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_farvardin.HeaderText = "From"
        Me.Person_mony_incoming_farvardin.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_farvardin.HeaderText = "For"
        Me.Forr_mony_incoming_farvardin.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_farvardin.HeaderText = "Date"
        Me.Data_mony_incoming_farvardin.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_farvardin.HeaderText = "Hours"
        Me.Time_mony_incoming_farvardin.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_ordibehesht.HeaderText = "Number"
        Me.Id_mony_incoming_ordibehesht.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_ordibehesht.HeaderText = "Amount"
        Me.Amount_mony_incoming_ordibehesht.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_ordibehesht.HeaderText = "From"
        Me.Person_mony_incoming_ordibehesht.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_ordibehesht.HeaderText = "For"
        Me.Forr_mony_incoming_ordibehesht.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_ordibehesht.HeaderText = "Date"
        Me.Data_mony_incoming_ordibehesht.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_ordibehesht.HeaderText = "Hours"
        Me.Time_mony_incoming_ordibehesht.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_khordad.HeaderText = "Number"
        Me.Id_mony_incoming_khordad.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_khordad.HeaderText = "Amount"
        Me.Amount_mony_incoming_khordad.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_khordad.HeaderText = "From"
        Me.Person_mony_incoming_khordad.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_khordad.HeaderText = "For"
        Me.Forr_mony_incoming_khordad.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_khordad.HeaderText = "Date"
        Me.Data_mony_incoming_khordad.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_khordad.HeaderText = "Hours"
        Me.Time_mony_incoming_khordad.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_tir.HeaderText = "Number"
        Me.Id_mony_incoming_tir.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_tir.HeaderText = "Amount"
        Me.Amount_mony_incoming_tir.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_tir.HeaderText = "From"
        Me.Person_mony_incoming_tir.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_tir.HeaderText = "For"
        Me.Forr_mony_incoming_tir.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_tir.HeaderText = "Date"
        Me.Data_mony_incoming_tir.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_tir.HeaderText = "Hours"
        Me.Time_mony_incoming_tir.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_mordad.HeaderText = "Number"
        Me.Id_mony_incoming_mordad.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_mordad.HeaderText = "Amount"
        Me.Amount_mony_incoming_mordad.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_mordad.HeaderText = "From"
        Me.Person_mony_incoming_mordad.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_mordad.HeaderText = "For"
        Me.Forr_mony_incoming_mordad.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_mordad.HeaderText = "Date"
        Me.Data_mony_incoming_mordad.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_mordad.HeaderText = "Hours"
        Me.Time_mony_incoming_mordad.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_shahrivar.HeaderText = "Number"
        Me.Id_mony_incoming_shahrivar.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_shahrivar.HeaderText = "Amount"
        Me.Amount_mony_incoming_shahrivar.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_shahrivar.HeaderText = "From"
        Me.Person_mony_incoming_shahrivar.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_shahrivar.HeaderText = "For"
        Me.Forr_mony_incoming_shahrivar.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_shahrivar.HeaderText = "Date"
        Me.Data_mony_incoming_shahrivar.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_shahrivar.HeaderText = "Hours"
        Me.Time_mony_incoming_shahrivar.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_mehr.HeaderText = "Number"
        Me.Id_mony_incoming_mehr.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_mehr.HeaderText = "Amount"
        Me.Amount_mony_incoming_mehr.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_mehr.HeaderText = "From"
        Me.Person_mony_incoming_mehr.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_mehr.HeaderText = "For"
        Me.Forr_mony_incoming_mehr.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_mehr.HeaderText = "Date"
        Me.Data_mony_incoming_mehr.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_mehr.HeaderText = "Hours"
        Me.Time_mony_incoming_mehr.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_aban.HeaderText = "Number"
        Me.Id_mony_incoming_aban.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_aban.HeaderText = "Amount"
        Me.Amount_mony_incoming_aban.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_aban.HeaderText = "From"
        Me.Person_mony_incoming_aban.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_aban.HeaderText = "For"
        Me.Forr_mony_incoming_aban.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_aban.HeaderText = "Date"
        Me.Data_mony_incoming_aban.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_aban.HeaderText = "Hours"
        Me.Time_mony_incoming_aban.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_azar.HeaderText = "Number"
        Me.Id_mony_incoming_azar.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_azar.HeaderText = "Amount"
        Me.Amount_mony_incoming_azar.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_azar.HeaderText = "From"
        Me.Person_mony_incoming_azar.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_azar.HeaderText = "For"
        Me.Forr_mony_incoming_azar.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_azar.HeaderText = "Date"
        Me.Data_mony_incoming_azar.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_azar.HeaderText = "Hours"
        Me.Time_mony_incoming_azar.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_dey.HeaderText = "Number"
        Me.Id_mony_incoming_dey.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_dey.HeaderText = "Amount"
        Me.Amount_mony_incoming_dey.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_dey.HeaderText = "From"
        Me.Person_mony_incoming_dey.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_dey.HeaderText = "For"
        Me.Forr_mony_incoming_dey.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_dey.HeaderText = "Date"
        Me.Data_mony_incoming_dey.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_dey.HeaderText = "Hours"
        Me.Time_mony_incoming_dey.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_bahman.HeaderText = "Number"
        Me.Id_mony_incoming_bahman.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_bahman.HeaderText = "Amount"
        Me.Amount_mony_incoming_bahman.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_bahman.HeaderText = "From"
        Me.Person_mony_incoming_bahman.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_bahman.HeaderText = "For"
        Me.Forr_mony_incoming_bahman.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_bahman.HeaderText = "Date"
        Me.Data_mony_incoming_bahman.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_bahman.HeaderText = "Hours"
        Me.Time_mony_incoming_bahman.ToolTipText = "Transaction hours"

        Me.Id_mony_incoming_esfand.HeaderText = "Number"
        Me.Id_mony_incoming_esfand.ToolTipText = "Transaction number"
        Me.Amount_mony_incoming_esfand.HeaderText = "Amount"
        Me.Amount_mony_incoming_esfand.ToolTipText = "Transaction amount"
        Me.Person_mony_incoming_esfand.HeaderText = "From"
        Me.Person_mony_incoming_esfand.ToolTipText = "Depositor"
        Me.Forr_mony_incoming_esfand.HeaderText = "For"
        Me.Forr_mony_incoming_esfand.ToolTipText = "Description of money deposited"
        Me.Data_mony_incoming_esfand.HeaderText = "Date"
        Me.Data_mony_incoming_esfand.ToolTipText = "Transaction date"
        Me.Time_mony_incoming_esfand.HeaderText = "Hours"
        Me.Time_mony_incoming_esfand.ToolTipText = "Transaction hours"








        Me.Id_mony_Output_farvardin.HeaderText = "Number"
        Me.Id_mony_Output_farvardin.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_farvardin.HeaderText = "Amount"
        Me.Amount_mony_Output_farvardin.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_farvardin.HeaderText = "To the"
        Me.Person_mony_Output_farvardin.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_farvardin.HeaderText = "For"
        Me.Forr_mony_Output_farvardin.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_farvardin.HeaderText = "Date"
        Me.Data_mony_Output_farvardin.ToolTipText = "Transaction date"
        Me.Time_mony_Output_farvardin.HeaderText = "Hours"
        Me.Time_mony_Output_farvardin.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_ordibehesht.HeaderText = "Number"
        Me.Id_mony_Output_ordibehesht.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_ordibehesht.HeaderText = "Amount"
        Me.Amount_mony_Output_ordibehesht.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_ordibehesht.HeaderText = "To the"
        Me.Person_mony_Output_ordibehesht.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_ordibehesht.HeaderText = "For"
        Me.Forr_mony_Output_ordibehesht.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_ordibehesht.HeaderText = "Date"
        Me.Data_mony_Output_ordibehesht.ToolTipText = "Transaction date"
        Me.Time_mony_Output_ordibehesht.HeaderText = "Hours"
        Me.Time_mony_Output_ordibehesht.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_khordad.HeaderText = "Number"
        Me.Id_mony_Output_khordad.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_khordad.HeaderText = "Amount"
        Me.Amount_mony_Output_khordad.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_khordad.HeaderText = "To the"
        Me.Person_mony_Output_khordad.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_khordad.HeaderText = "For"
        Me.Forr_mony_Output_khordad.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_khordad.HeaderText = "Date"
        Me.Data_mony_Output_khordad.ToolTipText = "Transaction date"
        Me.Time_mony_Output_khordad.HeaderText = "Hours"
        Me.Time_mony_Output_khordad.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_tir.HeaderText = "Number"
        Me.Id_mony_Output_tir.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_tir.HeaderText = "Amount"
        Me.Amount_mony_Output_tir.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_tir.HeaderText = "To the"
        Me.Person_mony_Output_tir.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_tir.HeaderText = "For"
        Me.Forr_mony_Output_tir.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_tir.HeaderText = "Date"
        Me.Data_mony_Output_tir.ToolTipText = "Transaction date"
        Me.Time_mony_Output_tir.HeaderText = "Hours"
        Me.Time_mony_Output_tir.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_mordad.HeaderText = "Number"
        Me.Id_mony_Output_mordad.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_mordad.HeaderText = "Amount"
        Me.Amount_mony_Output_mordad.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_mordad.HeaderText = "To the"
        Me.Person_mony_Output_mordad.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_mordad.HeaderText = "For"
        Me.Forr_mony_Output_mordad.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_mordad.HeaderText = "Date"
        Me.Data_mony_Output_mordad.ToolTipText = "Transaction date"
        Me.Time_mony_Output_mordad.HeaderText = "Hours"
        Me.Time_mony_Output_mordad.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_shahrivar.HeaderText = "Number"
        Me.Id_mony_Output_shahrivar.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_shahrivar.HeaderText = "Amount"
        Me.Amount_mony_Output_shahrivar.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_shahrivar.HeaderText = "To the"
        Me.Person_mony_Output_shahrivar.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_shahrivar.HeaderText = "For"
        Me.Forr_mony_Output_shahrivar.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_shahrivar.HeaderText = "Date"
        Me.Data_mony_Output_shahrivar.ToolTipText = "Transaction date"
        Me.Time_mony_Output_shahrivar.HeaderText = "Hours"
        Me.Time_mony_Output_shahrivar.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_mehr.HeaderText = "Number"
        Me.Id_mony_Output_mehr.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_mehr.HeaderText = "Amount"
        Me.Amount_mony_Output_mehr.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_mehr.HeaderText = "To the"
        Me.Person_mony_Output_mehr.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_mehr.HeaderText = "For"
        Me.Forr_mony_Output_mehr.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_mehr.HeaderText = "Date"
        Me.Data_mony_Output_mehr.ToolTipText = "Transaction date"
        Me.Time_mony_Output_mehr.HeaderText = "Hours"
        Me.Time_mony_Output_mehr.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_aban.HeaderText = "Number"
        Me.Id_mony_Output_aban.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_aban.HeaderText = "Amount"
        Me.Amount_mony_Output_aban.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_aban.HeaderText = "To the"
        Me.Person_mony_Output_aban.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_aban.HeaderText = "For"
        Me.Forr_mony_Output_aban.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_aban.HeaderText = "Date"
        Me.Data_mony_Output_aban.ToolTipText = "Transaction date"
        Me.Time_mony_Output_aban.HeaderText = "Hours"
        Me.Time_mony_Output_aban.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_azar.HeaderText = "Number"
        Me.Id_mony_Output_azar.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_azar.HeaderText = "Amount"
        Me.Amount_mony_Output_azar.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_azar.HeaderText = "To the"
        Me.Person_mony_Output_azar.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_azar.HeaderText = "For"
        Me.Forr_mony_Output_azar.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_azar.HeaderText = "Date"
        Me.Data_mony_Output_azar.ToolTipText = "Transaction date"
        Me.Time_mony_Output_azar.HeaderText = "Hours"
        Me.Time_mony_Output_azar.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_dey.HeaderText = "Number"
        Me.Id_mony_Output_dey.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_dey.HeaderText = "Amount"
        Me.Amount_mony_Output_dey.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_dey.HeaderText = "To the"
        Me.Person_mony_Output_dey.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_dey.HeaderText = "For"
        Me.Forr_mony_Output_dey.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_dey.HeaderText = "Date"
        Me.Data_mony_Output_dey.ToolTipText = "Transaction date"
        Me.Time_mony_Output_dey.HeaderText = "Hours"
        Me.Time_mony_Output_dey.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_bahman.HeaderText = "Number"
        Me.Id_mony_Output_bahman.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_bahman.HeaderText = "Amount"
        Me.Amount_mony_Output_bahman.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_bahman.HeaderText = "To the"
        Me.Person_mony_Output_bahman.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_bahman.HeaderText = "For"
        Me.Forr_mony_Output_bahman.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_bahman.HeaderText = "Date"
        Me.Data_mony_Output_bahman.ToolTipText = "Transaction date"
        Me.Time_mony_Output_bahman.HeaderText = "Hours"
        Me.Time_mony_Output_bahman.ToolTipText = "Transaction hours"

        Me.Id_mony_Output_esfand.HeaderText = "Number"
        Me.Id_mony_Output_esfand.ToolTipText = "Transaction number"
        Me.Amount_mony_Output_esfand.HeaderText = "Amount"
        Me.Amount_mony_Output_esfand.ToolTipText = "Transaction amount"
        Me.Person_mony_Output_esfand.HeaderText = "To the"
        Me.Person_mony_Output_esfand.ToolTipText = "Deposited person"
        Me.Forr_mony_Output_esfand.HeaderText = "For"
        Me.Forr_mony_Output_esfand.ToolTipText = "Description of money deposited"
        Me.Data_mony_Output_esfand.HeaderText = "Date"
        Me.Data_mony_Output_esfand.ToolTipText = "Transaction date"
        Me.Time_mony_Output_esfand.HeaderText = "Hours"
        Me.Time_mony_Output_esfand.ToolTipText = "Transaction hours"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_password.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_password.Text = "Please enter password"
        '
        '
        '
        Label_title.Font = New System.Drawing.Font("Sylfaen", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_title.Text = "Hamoon Language Institute"
        Label_title.Location = New System.Drawing.Point(150, 0)
        Label_title.Size = New System.Drawing.Size(700, 90)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        If Button_edit_s.Visible = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "less")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
        End If
        If Button_edit_t.Visible = True Then
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "less")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If

        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Button_students.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_teachers.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_add_s.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_edit_s.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_delete_s.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_add_t.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_edit_t.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button_delete_t.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        Button_students.Text = "Student's list"
        Button_teachers.Text = "Teacher's list"
        Button_add_s.Text = "Add students"
        Button_edit_s.Text = "Edit"
        Button_delete_s.Text = "Delete"
        Button_add_t.Text = "Add teacher"
        Button_edit_t.Text = "Edit"
        Button_delete_t.Text = "Delete"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_name_s.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_name_father_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_name_mother_s.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_phone_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_phone_father_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_phone_mother_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_telephone.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_address.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_date.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_datebirth.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_codemeli_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_level_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_language_s_edit.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_gender_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        Label_name_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_name_father_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_name_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_phone_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_phone_father_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_phone_mother_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_telephone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_address.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_datebirth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_codemeli_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_level_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_gender_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        Label_name_s.Location = New System.Drawing.Point(20, 35)
        Label_name_father_s.Location = New System.Drawing.Point(20, 90)
        Label_name_mother_s.Location = New System.Drawing.Point(20, 145)
        Label_phone_s.Location = New System.Drawing.Point(20, 200)
        Label_phone_father_s.Location = New System.Drawing.Point(20, 255)
        Label_phone_mother_s.Location = New System.Drawing.Point(20, 310)
        Label_telephone.Location = New System.Drawing.Point(20, 365)
        Label_address.Location = New System.Drawing.Point(570, 35)
        Label_codemeli_s.Location = New System.Drawing.Point(570, 90)
        Label_datebirth.Location = New System.Drawing.Point(570, 145)
        Label_date.Location = New System.Drawing.Point(570, 200)
        Label_gender_s.Location = New System.Drawing.Point(570, 255)
        Label_level_s.Location = New System.Drawing.Point(570, 310)
        Label_language_s_edit.Location = New System.Drawing.Point(570, 365)
        '
        '
        Label_name_s.Text = "Student's name and last name:"
        Label_name_father_s.Text = "Father's name and last name:"
        Label_name_mother_s.Text = "Mother's name and last name:"
        Label_phone_s.Text = "Student's phone number:"
        Label_phone_father_s.Text = "Father's phone number:"
        Label_phone_mother_s.Text = "Mother's phone number:"
        Label_telephone.Text = "Home's telephone number:"
        Label_address.Text = "Home's address:"
        Label_date.Text = "Date of Registration:"
        Label_datebirth.Text = "Date of Birth:"
        Label_codemeli_s.Text = "National ID:"
        Label_level_s.Text = "Book's level:"
        Label_language_s_edit.Text = "Language:"
        Label_gender_s.Text = "Gender:"
        '
        '
        TextBox_name_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_name_father_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_name_mother_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_father_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_mother_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_telephone.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_address.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_codemeli_s.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        TextBox_name_s.Location = New System.Drawing.Point(290, 35)
        TextBox_name_father_s.Location = New System.Drawing.Point(290, 90)
        TextBox_name_mother_s.Location = New System.Drawing.Point(290, 145)
        TextBox_phone_s.Location = New System.Drawing.Point(290, 200)
        TextBox_phone_father_s.Location = New System.Drawing.Point(290, 255)
        TextBox_phone_mother_s.Location = New System.Drawing.Point(290, 310)
        TextBox_telephone.Location = New System.Drawing.Point(290, 365)
        TextBox_address.Location = New System.Drawing.Point(740, 35)
        TextBox_codemeli_s.Location = New System.Drawing.Point(740, 90)
        TextBox_datebirth_s_year.Location = New System.Drawing.Point(830, 145)
        TextBox_datebirth_s_month.Location = New System.Drawing.Point(785, 145)
        TextBox_datebirth_s_day.Location = New System.Drawing.Point(740, 145)
        TextBox_date_s_year.Location = New System.Drawing.Point(830, 200)
        TextBox_date_s_month.Location = New System.Drawing.Point(785, 200)
        TextBox_date_s_day.Location = New System.Drawing.Point(740, 200)
        '
        '
        TextBox_datebirth_t_year.Text = "Y"
        TextBox_datebirth_t_month.Text = "M"
        TextBox_datebirth_t_day.Text = "D"
        TextBox_date_t_year.Text = "Y"
        TextBox_date_t_month.Text = "M"
        TextBox_date_t_day.Text = "D"
        '
        '
        ComboBox_language_s_edit.Location = New System.Drawing.Point(740, 365)
        ComboBox_level_s.Location = New System.Drawing.Point(740, 310)
        ComboBox_level_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        ComboBox_language_s_edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        TextBox_level_s.Location = New System.Drawing.Point(740, 307)
        PictureBox_level_s.Location = New System.Drawing.Point(945, 310)
        ToolTip_main.SetToolTip(PictureBox_level_s, "Entering manually")
        '
        '
        RadioButton_male_s.Location = New System.Drawing.Point(740, 255)
        RadioButton_female_s.Location = New System.Drawing.Point(840, 255)
        RadioButton_male_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadioButton_female_s.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadioButton_male_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        RadioButton_female_s.RightToLeft = System.Windows.Forms.RightToLeft.No
        RadioButton_male_s.Text = "Male"
        RadioButton_female_s.Text = "Female"
        TextBox_gender_s.Location = New System.Drawing.Point(945, 255)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_name_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_lastname_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_phone_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_telephone_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_address_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_datebirth_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_date_t.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_codemeli_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_evidence.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_gender_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_language_t_edit.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        Label_name_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_lastname_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_phone_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_telephone_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_address_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_datebirth_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_date_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_codemeli_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_evidence.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_gender_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Label_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        Label_name_t.Location = New System.Drawing.Point(20, 35)
        Label_lastname_t.Location = New System.Drawing.Point(20, 90)
        Label_phone_t.Location = New System.Drawing.Point(20, 145)
        Label_telephone_t.Location = New System.Drawing.Point(20, 200)
        Label_address_t.Location = New System.Drawing.Point(20, 255)
        Label_codemeli_t.Location = New System.Drawing.Point(20, 310)
        Label_evidence.Location = New System.Drawing.Point(20, 365)
        Label_datebirth_t.Location = New System.Drawing.Point(540, 35)
        Label_date_t.Location = New System.Drawing.Point(540, 90)
        Label_gender_t.Location = New System.Drawing.Point(540, 145)
        Label_language_t_edit.Location = New System.Drawing.Point(540, 200)
        '
        '
        Label_name_t.Text = "Name:"
        Label_lastname_t.Text = "Last name:"
        Label_phone_t.Text = "Phone's number:"
        Label_telephone_t.Text = "Telephone:"
        Label_address_t.Text = "Address:"
        Label_datebirth_t.Text = "Date of Birth:"
        Label_date_t.Text = "Date of Employment:"
        Label_codemeli_t.Text = "National ID:"
        Label_evidence.Text = "Education level:"
        Label_gender_t.Text = "Gender:"
        Label_language_t_edit.Text = "Language:"
        '
        '
        TextBox_name_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_lastname_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_phone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_telephone_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_address_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_codemeli_t.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_evidence.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        TextBox_name_t.Location = New System.Drawing.Point(240, 35)
        TextBox_lastname_t.Location = New System.Drawing.Point(240, 90)
        TextBox_phone_t.Location = New System.Drawing.Point(240, 145)
        TextBox_telephone_t.Location = New System.Drawing.Point(240, 200)
        TextBox_address_t.Location = New System.Drawing.Point(240, 255)
        TextBox_codemeli_t.Location = New System.Drawing.Point(240, 310)
        TextBox_evidence.Location = New System.Drawing.Point(240, 365)
        TextBox_datebirth_t_day.Location = New System.Drawing.Point(740, 35)
        TextBox_datebirth_t_month.Location = New System.Drawing.Point(785, 35)
        TextBox_datebirth_t_year.Location = New System.Drawing.Point(830, 35)
        TextBox_date_t_day.Location = New System.Drawing.Point(740, 90)
        TextBox_date_t_month.Location = New System.Drawing.Point(785, 90)
        TextBox_date_t_year.Location = New System.Drawing.Point(830, 90)
        '
        '
        TextBox_datebirth_s_year.Text = "Y"
        TextBox_datebirth_s_month.Text = "M"
        TextBox_datebirth_s_day.Text = "D"
        TextBox_date_s_year.Text = "Y"
        TextBox_date_s_month.Text = "M"
        TextBox_date_s_day.Text = "D"
        '
        '
        RadioButton_male_t.Location = New System.Drawing.Point(740, 145)
        RadioButton_female_t.Location = New System.Drawing.Point(840, 145)
        RadioButton_male_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadioButton_female_t.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadioButton_male_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        RadioButton_female_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        RadioButton_male_t.Text = "Male"
        RadioButton_female_t.Text = "Female"
        TextBox_gender_t.Location = New System.Drawing.Point(945, 145)
        '
        '
        '
        '
        ComboBox_language_t_edit.Location = New System.Drawing.Point(740, 200)
        ComboBox_language_t_edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_language.Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Radio_persian.Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Radio_english.Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_music.Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_change_password.Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ToolTip_main.SetToolTip(PictureBox_setting, "Settings")
        ToolTip_main.SetToolTip(PictureBox_about_us, "about us")
        GroupBox_setting.Text = "Settings"
        Label_language.Text = "Language"
        Radio_persian.Text = "Persian"
        Radio_english.Text = "English"
        Label_music.Text = "Music"
        Label_change_password.Text = "Change password"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_programmer_name_B.Font = New System.Drawing.Font("Pappu pass ho gaya", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_name_D.Font = New System.Drawing.Font("Pappu pass ho gaya", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_programmer_name_B.Text = "Danial Khodarahmi"
        Label_programmer_name_D.Text = "Danial Khodarahmi"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        PictureBox_back_to_home_from_registration_students.Location = New System.Drawing.Point(925, 420)
        PictureBox_complete_registration_students.Location = New System.Drawing.Point(865, 420)
        PictureBox_back_to_home_from_registration_teachers.Location = New System.Drawing.Point(925, 420)
        PictureBox_complete_registration_teachers.Location = New System.Drawing.Point(865, 420)
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_change_password_1.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_change_password_2.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_change_password_1.Text = "New password"
        Label_change_password_2.Text = "Repeat new password"
        Label_change_password_error.Text = "Fields mismath"
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        Label_edit.Text = "Edit"
        '
        '
        '
        '
        ToolTip_main.SetToolTip(PictureBox_level_test, "Level test")
        ToolTip_main.SetToolTip(PictureBox_b_f_level_test, "Home")
        '
        '
        '
        '
        Label_forgotten_password.Font = New System.Drawing.Font("B nazanin", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_forgotten_password.Text = "Password  recovery"
        '
        '
        '
        Label_return_password.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        ''''''''''''''''''''''''''''''''''''''''''''''''''')
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_show, "Charts statistics")
        '
        '
        Label_charts_show_explain_in_all.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_charts_show_explain_in_all.Text = "Here you can access the Chart statistics of learners, teachers or both by choosing one of the options"
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_show_all, "learners and teachers Chart statistics")
        ToolTip_main.SetToolTip(PictureBox_charts_show_teachers, "teachers Chart statistics")
        ToolTip_main.SetToolTip(PictureBox_charts_show_students, "learners Chart statistics")
        '
        '
        Chart_students.Series(0).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chart_students.Series(1).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chart_teachers.Series(0).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chart_teachers.Series(1).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chart_all.Series(0).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chart_all.Series(1).Font = New System.Drawing.Font("B nazanin", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        '
        Label_charts_choose_language.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_charts_choose_gender.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_charts_choose_birthday.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_charts_choose_date_of_registration.Font = New System.Drawing.Font("B nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolTip_main.SetToolTip(Label_charts_choose_language, "Chart statistics based on the selected language")
        ToolTip_main.SetToolTip(Label_charts_choose_gender, "Chart statistics based on gender")
        ToolTip_main.SetToolTip(Label_charts_choose_birthday, "Chart statistics based on age")
        ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "Chart statistics based on Registration date")
        Label_charts_choose_language.Text = "LANGUAGE"
        Label_charts_choose_gender.Text = "GENDER"
        Label_charts_choose_birthday.Text = "AGE"
        Label_charts_choose_date_of_registration.Text = "Registration date"
        '
        '
        ToolTip_main.SetToolTip(PictureBox_charts_change_type, "Chart deformation")
        ToolTip_main.SetToolTip(PictureBox_charts_change_color, "Chart color change")
        '
        '
        '
        ToolTip_main.SetToolTip(PictureBox_Part_charts_tips, "Tips")
        Label_Part_charts_tips_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Part_charts_tips_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Part_charts_tips_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Part_charts_tips_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Part_charts_tips_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Part_charts_tips_1.Text = "👆" & "3D and 2D state setting"
        Label_Part_charts_tips_2.Text = "Restore chart settings to default" & "👉"
        Label_Part_charts_tips_3.Text = "👉" & vbNewLine & "Here you can access to 12 different color schemes for the chart by moving the blue arrow"
        Label_Part_charts_tips_4.Text = "👈" & vbNewLine & "Here you can access 17 different chart models by moving the blue arrow"
        Label_Part_charts_tips_5.Text = "You can access useful information by holding your mouse on different sections of the chart" & vbNewLine & "👇"
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Label_Accounting_farvardin.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_ordibehesht.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_khordad.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_tir.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_mordad.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_shahrivar.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_mehr.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_aban.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_azar.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_dey.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_bahman.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_esfand.Font = New System.Drawing.Font("B nazanin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_farvardin.Text = "Farvardin"
        Label_Accounting_ordibehesht.Text = "Ordibehesht"
        Label_Accounting_khordad.Text = "Khordad"
        Label_Accounting_tir.Text = "Tir"
        Label_Accounting_mordad.Text = "Mordad"
        Label_Accounting_shahrivar.Text = "Shahrivar"
        Label_Accounting_mehr.Text = "Mehr"
        Label_Accounting_aban.Text = "Aban"
        Label_Accounting_azar.Text = "Azar"
        Label_Accounting_dey.Text = "Dey"
        Label_Accounting_bahman.Text = "Bahman"
        Label_Accounting_esfand.Text = "Esfand"
        '
        '
        '
        '
        '
        '
        '
        Label_Accounting_money_add_1.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_money_add_3.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_money_add_5.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_money_add_7.Font = New System.Drawing.Font("B nazanin", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Accounting_money_add_1.Text = "Amount"
        Label_Accounting_money_add_3.Text = "From"
        Label_Accounting_money_add_5.Text = "For"
        Label_Accounting_money_add_7.Text = "received"
       
    End Sub

    Sub enter_app()

        PictureBox_home.Visible = True

        Label_title.Visible = True

        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True

        PictureBox_setting.Visible = True

        PictureBox_level_test.Visible = True

        PictureBox_charts_show.Visible = True

        PictureBox_Accounting.Visible = True



        Label_Timer_lock_app.Visible = False
        Label_password.Visible = False
        TextBox_password.Visible = False
        PictureBox_password.Visible = False
        Label_forgotten_password.Visible = False

        My.Settings.Timer_lock_app = "0"

    End Sub

    Sub regitration_students()

        PictureBox_home.Visible = False


        Label_title.Visible = False


        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False




        PictureBox_select_language_item.Visible = True

        Label_select_language_s.Visible = True

        CheckBox_en.Visible = True
        CheckBox_tur.Visible = True
        CheckBox_spa.Visible = True
        CheckBox_ita.Visible = True
        CheckBox_fre.Visible = True
        CheckBox_arab.Visible = True
        CheckBox_chi.Visible = True
        CheckBox_japa.Visible = True
        CheckBox_kor.Visible = True

        PictureBox_en.Visible = True
        PictureBox_tur.Visible = True
        PictureBox_spa.Visible = True
        PictureBox_ita.Visible = True
        PictureBox_fre.Visible = True
        PictureBox_arab.Visible = True
        PictureBox_chi.Visible = True
        PictureBox_japa.Visible = True
        PictureBox_kor.Visible = True

        PictureBox_select_language_next_level.Visible = True


        CheckBox_en.Checked = False
        CheckBox_tur.Checked = False
        CheckBox_spa.Checked = False
        CheckBox_ita.Checked = False
        CheckBox_fre.Checked = False
        CheckBox_arab.Checked = False
        CheckBox_chi.Checked = False
        CheckBox_japa.Checked = False
        CheckBox_kor.Checked = False

        Label_select_language_result.Text = String.Empty




        PictureBox_back_to_home_from_registration_students.Visible = True


        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False




        If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)


    End Sub
    Sub regitration_students_next_level()

        PictureBox_select_language_item.Visible = False

        Label_select_language_s.Visible = False

        CheckBox_en.Visible = False
        CheckBox_tur.Visible = False
        CheckBox_spa.Visible = False
        CheckBox_ita.Visible = False
        CheckBox_fre.Visible = False
        CheckBox_arab.Visible = False
        CheckBox_chi.Visible = False
        CheckBox_japa.Visible = False
        CheckBox_kor.Visible = False

        PictureBox_en.Visible = False
        PictureBox_tur.Visible = False
        PictureBox_spa.Visible = False
        PictureBox_ita.Visible = False
        PictureBox_fre.Visible = False
        PictureBox_arab.Visible = False
        PictureBox_chi.Visible = False
        PictureBox_japa.Visible = False
        PictureBox_kor.Visible = False

        PictureBox_select_language_next_level.Visible = False






        Label_name_s.Visible = True
        Label_name_father_s.Visible = True
        Label_name_mother_s.Visible = True
        Label_phone_s.Visible = True
        Label_phone_father_s.Visible = True
        Label_phone_mother_s.Visible = True
        Label_telephone.Visible = True
        Label_address.Visible = True
        Label_date.Visible = True
        Label_datebirth.Visible = True
        Label_codemeli_s.Visible = True
        Label_level_s.Visible = True
        Label_gender_s.Visible = True


        TextBox_name_s.Visible = True
        TextBox_name_father_s.Visible = True
        TextBox_name_mother_s.Visible = True
        TextBox_phone_s.Visible = True
        TextBox_phone_father_s.Visible = True
        TextBox_phone_mother_s.Visible = True
        TextBox_telephone.Visible = True
        TextBox_address.Visible = True
        TextBox_date_s_year.Visible = True
        TextBox_date_s_month.Visible = True
        TextBox_date_s_day.Visible = True
        TextBox_datebirth_s_year.Visible = True
        TextBox_datebirth_s_month.Visible = True
        TextBox_datebirth_s_day.Visible = True
        TextBox_codemeli_s.Visible = True


        RadioButton_female_s.Visible = True
        RadioButton_male_s.Visible = True


        ComboBox_level_s.Visible = True
        PictureBox_level_s.Visible = True


        PictureBox_complete_registration_students.Visible = True


        TextBox_name_s.Text = String.Empty
        TextBox_name_father_s.Text = String.Empty
        TextBox_name_mother_s.Text = String.Empty
        TextBox_phone_s.Text = String.Empty
        TextBox_phone_father_s.Text = String.Empty
        TextBox_phone_mother_s.Text = String.Empty
        TextBox_telephone.Text = String.Empty
        TextBox_address.Text = String.Empty
        TextBox_codemeli_s.Text = String.Empty
        TextBox_date_s_year.Text = "سال"
        TextBox_date_s_month.Text = "ماه"
        TextBox_date_s_day.Text = "روز"
        TextBox_date_s_result.Text = String.Empty
        TextBox_datebirth_s_year.Text = "سال"
        TextBox_datebirth_s_month.Text = "ماه"
        TextBox_datebirth_s_day.Text = "روز"
        TextBox_datebirth_s_result.Text = String.Empty

        ComboBox_level_s.Text = String.Empty
        TextBox_level_s.Text = String.Empty

        TextBox_gender_s.Text = String.Empty
        RadioButton_male_s.Checked = False
        RadioButton_female_s.Checked = False

        If Radio_english.Checked = True Then
            TextBox_datebirth_s_year.Text = "Y"
            TextBox_datebirth_s_month.Text = "M"
            TextBox_datebirth_s_day.Text = "D"
            TextBox_date_s_year.Text = "Y"
            TextBox_date_s_month.Text = "M"
            TextBox_date_s_day.Text = "D"
        End If

        PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.writing

        If Radio_english.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_level_s, "Entering manually")
        Else
            ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت دستی")
        End If

    End Sub

    Sub registration_teachers()

        PictureBox_home.Visible = False


        Label_title.Visible = False


        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False





        PictureBox_select_language_item.Visible = True

        Label_select_language_t.Visible = True

        CheckBox_en.Visible = True
        CheckBox_tur.Visible = True
        CheckBox_spa.Visible = True
        CheckBox_ita.Visible = True
        CheckBox_fre.Visible = True
        CheckBox_arab.Visible = True
        CheckBox_chi.Visible = True
        CheckBox_japa.Visible = True
        CheckBox_kor.Visible = True

        PictureBox_en.Visible = True
        PictureBox_tur.Visible = True
        PictureBox_spa.Visible = True
        PictureBox_ita.Visible = True
        PictureBox_fre.Visible = True
        PictureBox_arab.Visible = True
        PictureBox_chi.Visible = True
        PictureBox_japa.Visible = True
        PictureBox_kor.Visible = True

        PictureBox_select_language_next_level.Visible = True



        CheckBox_en.Checked = False
        CheckBox_tur.Checked = False
        CheckBox_spa.Checked = False
        CheckBox_ita.Checked = False
        CheckBox_fre.Checked = False
        CheckBox_arab.Checked = False
        CheckBox_chi.Checked = False
        CheckBox_japa.Checked = False
        CheckBox_kor.Checked = False

        Label_select_language_result.Text = String.Empty




        PictureBox_back_to_home_from_registration_teachers.Visible = True

        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False



        If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)

    End Sub
    Sub regitration_teachers_next_level()
        PictureBox_select_language_item.Visible = False

        Label_select_language_t.Visible = False

        CheckBox_en.Visible = False
        CheckBox_tur.Visible = False
        CheckBox_spa.Visible = False
        CheckBox_ita.Visible = False
        CheckBox_fre.Visible = False
        CheckBox_arab.Visible = False
        CheckBox_chi.Visible = False
        CheckBox_japa.Visible = False
        CheckBox_kor.Visible = False

        PictureBox_en.Visible = False
        PictureBox_tur.Visible = False
        PictureBox_spa.Visible = False
        PictureBox_ita.Visible = False
        PictureBox_fre.Visible = False
        PictureBox_arab.Visible = False
        PictureBox_chi.Visible = False
        PictureBox_japa.Visible = False
        PictureBox_kor.Visible = False

        PictureBox_select_language_next_level.Visible = False




        Label_name_t.Visible = True
        Label_lastname_t.Visible = True
        Label_phone_t.Visible = True
        Label_telephone_t.Visible = True
        Label_address_t.Visible = True
        Label_datebirth_t.Visible = True
        Label_date_t.Visible = True
        Label_codemeli_t.Visible = True
        Label_evidence.Visible = True
        Label_gender_t.Visible = True


        TextBox_name_t.Visible = True
        TextBox_lastname_t.Visible = True
        TextBox_phone_t.Visible = True
        TextBox_telephone_t.Visible = True
        TextBox_address_t.Visible = True
        TextBox_datebirth_t_day.Visible = True
        TextBox_datebirth_t_month.Visible = True
        TextBox_datebirth_t_year.Visible = True
        TextBox_date_t_day.Visible = True
        TextBox_date_t_month.Visible = True
        TextBox_date_t_year.Visible = True
        TextBox_codemeli_t.Visible = True
        TextBox_evidence.Visible = True


        RadioButton_male_t.Visible = True
        RadioButton_female_t.Visible = True


        PictureBox_complete_registration_teachers.Visible = True


        TextBox_name_t.Text = String.Empty
        TextBox_lastname_t.Text = String.Empty
        TextBox_phone_t.Text = String.Empty
        TextBox_telephone_t.Text = String.Empty
        TextBox_address_t.Text = String.Empty
        TextBox_datebirth_t_day.Text = "روز"
        TextBox_datebirth_t_month.Text = "ماه"
        TextBox_datebirth_t_year.Text = "سال"
        TextBox_datebirth_t_result.Text = String.Empty
        TextBox_date_t_day.Text = "روز"
        TextBox_date_t_month.Text = "ماه"
        TextBox_date_t_year.Text = "سال"
        TextBox_date_t_result.Text = String.Empty
        TextBox_codemeli_t.Text = String.Empty
        TextBox_evidence.Text = String.Empty

        If Radio_english.Checked = True Then
            TextBox_datebirth_t_year.Text = "Y"
            TextBox_datebirth_t_month.Text = "M"
            TextBox_datebirth_t_day.Text = "D"
            TextBox_date_t_year.Text = "Y"
            TextBox_date_t_month.Text = "M"
            TextBox_date_t_day.Text = "D"
        End If

        TextBox_gender_t.Text = String.Empty
        RadioButton_male_t.Checked = False
        RadioButton_female_t.Checked = False

    End Sub

    Sub back_to_home_from_regirtration_student()

        PictureBox_home.Visible = True


        Label_title.Visible = True


        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True


        PictureBox_setting.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        If Radio_persian.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If


        PictureBox_level_test.Visible = True
        PictureBox_charts_show.Visible = True
        PictureBox_Accounting.Visible = True



        Label_name_s.Visible = False
        Label_name_father_s.Visible = False
        Label_name_mother_s.Visible = False
        Label_phone_s.Visible = False
        Label_phone_father_s.Visible = False
        Label_phone_mother_s.Visible = False
        Label_telephone.Visible = False
        Label_address.Visible = False
        Label_date.Visible = False
        Label_datebirth.Visible = False
        Label_codemeli_s.Visible = False
        Label_level_s.Visible = False
        Label_gender_s.Visible = False


        TextBox_name_s.Visible = False
        TextBox_name_father_s.Visible = False
        TextBox_name_mother_s.Visible = False
        TextBox_phone_s.Visible = False
        TextBox_phone_father_s.Visible = False
        TextBox_phone_mother_s.Visible = False
        TextBox_telephone.Visible = False
        TextBox_address.Visible = False
        TextBox_date_s_year.Visible = False
        TextBox_date_s_month.Visible = False
        TextBox_date_s_day.Visible = False
        TextBox_datebirth_s_year.Visible = False
        TextBox_datebirth_s_month.Visible = False
        TextBox_datebirth_s_day.Visible = False
        TextBox_codemeli_s.Visible = False


        RadioButton_female_s.Visible = False
        RadioButton_male_s.Visible = False

        Label_language_s_edit.Visible = False
        ComboBox_language_s_edit.Visible = False


        ComboBox_level_s.Visible = False
        TextBox_level_s.Visible = False
        PictureBox_level_s.Visible = False



        PictureBox_select_language_item.Visible = False

        Label_select_language_s.Visible = False

        CheckBox_en.Visible = False
        CheckBox_tur.Visible = False
        CheckBox_spa.Visible = False
        CheckBox_ita.Visible = False
        CheckBox_fre.Visible = False
        CheckBox_arab.Visible = False
        CheckBox_chi.Visible = False
        CheckBox_japa.Visible = False
        CheckBox_kor.Visible = False

        PictureBox_en.Visible = False
        PictureBox_tur.Visible = False
        PictureBox_spa.Visible = False
        PictureBox_ita.Visible = False
        PictureBox_fre.Visible = False
        PictureBox_arab.Visible = False
        PictureBox_chi.Visible = False
        PictureBox_japa.Visible = False
        PictureBox_kor.Visible = False

        PictureBox_select_language_next_level.Visible = False



        PictureBox_back_to_home_from_registration_students.Visible = False
        PictureBox_complete_registration_students.Visible = False
        PictureBox_select_language_next_level.Visible = False

        Label_edit.Visible = False
    End Sub
    Sub back_to_home_from_registration_teacher()

        PictureBox_home.Visible = True


        Label_title.Visible = True


        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True

        PictureBox_setting.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        If Radio_persian.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If


        PictureBox_level_test.Visible = True
        PictureBox_charts_show.Visible = True
        PictureBox_Accounting.Visible = True



        Label_name_t.Visible = False
        Label_lastname_t.Visible = False
        Label_phone_t.Visible = False
        Label_telephone_t.Visible = False
        Label_address_t.Visible = False
        Label_datebirth_t.Visible = False
        Label_date_t.Visible = False
        Label_codemeli_t.Visible = False
        Label_evidence.Visible = False
        Label_gender_t.Visible = False


        TextBox_name_t.Visible = False
        TextBox_lastname_t.Visible = False
        TextBox_phone_t.Visible = False
        TextBox_telephone_t.Visible = False
        TextBox_address_t.Visible = False
        TextBox_datebirth_t_day.Visible = False
        TextBox_datebirth_t_month.Visible = False
        TextBox_datebirth_t_year.Visible = False
        TextBox_date_t_day.Visible = False
        TextBox_date_t_month.Visible = False
        TextBox_date_t_year.Visible = False
        TextBox_codemeli_t.Visible = False
        TextBox_evidence.Visible = False


        RadioButton_male_t.Visible = False
        RadioButton_female_t.Visible = False

        Label_language_t_edit.Visible = False
        ComboBox_language_t_edit.Visible = False



        PictureBox_select_language_item.Visible = False

        Label_select_language_t.Visible = False

        CheckBox_en.Visible = False
        CheckBox_tur.Visible = False
        CheckBox_spa.Visible = False
        CheckBox_ita.Visible = False
        CheckBox_fre.Visible = False
        CheckBox_arab.Visible = False
        CheckBox_chi.Visible = False
        CheckBox_japa.Visible = False
        CheckBox_kor.Visible = False

        PictureBox_en.Visible = False
        PictureBox_tur.Visible = False
        PictureBox_spa.Visible = False
        PictureBox_ita.Visible = False
        PictureBox_fre.Visible = False
        PictureBox_arab.Visible = False
        PictureBox_chi.Visible = False
        PictureBox_japa.Visible = False
        PictureBox_kor.Visible = False

        PictureBox_select_language_next_level.Visible = False



        PictureBox_back_to_home_from_registration_teachers.Visible = False
        PictureBox_complete_registration_teachers.Visible = False
        PictureBox_select_language_next_level.Visible = False

        Label_edit.Visible = False
    End Sub

    Sub complete_student_list()

        database_add_s()

        Label_name_s.Visible = False
        Label_name_father_s.Visible = False
        Label_name_mother_s.Visible = False
        Label_phone_s.Visible = False
        Label_phone_father_s.Visible = False
        Label_phone_mother_s.Visible = False
        Label_telephone.Visible = False
        Label_address.Visible = False
        Label_date.Visible = False
        Label_datebirth.Visible = False
        Label_codemeli_s.Visible = False
        Label_level_s.Visible = False
        Label_gender_s.Visible = False


        TextBox_name_s.Visible = False
        TextBox_name_father_s.Visible = False
        TextBox_name_mother_s.Visible = False
        TextBox_phone_s.Visible = False
        TextBox_phone_father_s.Visible = False
        TextBox_phone_mother_s.Visible = False
        TextBox_telephone.Visible = False
        TextBox_address.Visible = False
        TextBox_date_s_year.Visible = False
        TextBox_date_s_month.Visible = False
        TextBox_date_s_day.Visible = False
        TextBox_datebirth_s_year.Visible = False
        TextBox_datebirth_s_month.Visible = False
        TextBox_datebirth_s_day.Visible = False
        TextBox_codemeli_s.Visible = False


        RadioButton_female_s.Visible = False
        RadioButton_male_s.Visible = False


        ComboBox_level_s.Visible = False
        TextBox_level_s.Visible = False
        PictureBox_level_s.Visible = False


        PictureBox_back_to_home_from_registration_students.Visible = False
        PictureBox_complete_registration_students.Visible = False


        PictureBox_back_to_home_from_students_and_teachers_list.Visible = True


        StudentDataGridView.Visible = True

        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
        End If

        Label_students_teachers_count.Visible = True
        Label_boy_count.Visible = True
        Label_girl_count.Visible = True

        PictureBox_population_count.Visible = True
        PictureBox_boy_count.Visible = True
        PictureBox_girl_count.Visible = True

        Label_students_teachers_count.Text = StudentDataGridView.RowCount

        gender_count_s()

        GridColor(StudentDataGridView)





        count_row = StudentDataGridView.Rows.Count - 1
        StudentDataGridView.CurrentCell = StudentDataGridView.Rows(count_row).Cells(0)
        For b = 0 To 14
            StudentDataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
        Next

    End Sub
    Sub complete_teacher_list()

        database_add_t()


        Label_name_t.Visible = False
        Label_lastname_t.Visible = False
        Label_phone_t.Visible = False
        Label_telephone_t.Visible = False
        Label_address_t.Visible = False
        Label_datebirth_t.Visible = False
        Label_date_t.Visible = False
        Label_codemeli_t.Visible = False
        Label_evidence.Visible = False
        Label_gender_t.Visible = False


        TextBox_name_t.Visible = False
        TextBox_lastname_t.Visible = False
        TextBox_phone_t.Visible = False
        TextBox_telephone_t.Visible = False
        TextBox_address_t.Visible = False
        TextBox_datebirth_t_day.Visible = False
        TextBox_datebirth_t_month.Visible = False
        TextBox_datebirth_t_year.Visible = False
        TextBox_date_t_day.Visible = False
        TextBox_date_t_month.Visible = False
        TextBox_date_t_year.Visible = False
        TextBox_codemeli_t.Visible = False
        TextBox_evidence.Visible = False


        RadioButton_male_t.Visible = False
        RadioButton_female_t.Visible = False


        PictureBox_back_to_home_from_registration_teachers.Visible = False
        PictureBox_complete_registration_teachers.Visible = False


        PictureBox_back_to_home_from_students_and_teachers_list.Visible = True


        TeachersDataGridView.Visible = True

        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
        End If

        Label_students_teachers_count.Visible = True
        Label_boy_count.Visible = True
        Label_girl_count.Visible = True

        PictureBox_population_count.Visible = True
        PictureBox_boy_count.Visible = True
        PictureBox_girl_count.Visible = True

        Label_students_teachers_count.Text = TeachersDataGridView.RowCount

        gender_count_t()

        GridColor(TeachersDataGridView)


        count_row = TeachersDataGridView.Rows.Count - 1
        TeachersDataGridView.CurrentCell = TeachersDataGridView.Rows(count_row).Cells(0)
        For b = 0 To 11
            TeachersDataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
        Next

    End Sub

    Sub complete_edit_s()
        database_edit_s()

        Label_name_s.Visible = False
        Label_name_father_s.Visible = False
        Label_name_mother_s.Visible = False
        Label_phone_s.Visible = False
        Label_phone_father_s.Visible = False
        Label_phone_mother_s.Visible = False
        Label_telephone.Visible = False
        Label_address.Visible = False
        Label_date.Visible = False
        Label_datebirth.Visible = False
        Label_codemeli_s.Visible = False
        Label_level_s.Visible = False
        Label_gender_s.Visible = False


        TextBox_name_s.Visible = False
        TextBox_name_father_s.Visible = False
        TextBox_name_mother_s.Visible = False
        TextBox_phone_s.Visible = False
        TextBox_phone_father_s.Visible = False
        TextBox_phone_mother_s.Visible = False
        TextBox_telephone.Visible = False
        TextBox_address.Visible = False
        TextBox_date_s_year.Visible = False
        TextBox_date_s_month.Visible = False
        TextBox_date_s_day.Visible = False
        TextBox_datebirth_s_year.Visible = False
        TextBox_datebirth_s_month.Visible = False
        TextBox_datebirth_s_day.Visible = False
        TextBox_codemeli_s.Visible = False


        RadioButton_female_s.Visible = False
        RadioButton_male_s.Visible = False


        ComboBox_level_s.Visible = False
        TextBox_level_s.Visible = False
        PictureBox_level_s.Visible = False


        Label_language_s_edit.Visible = False
        ComboBox_language_s_edit.Visible = False


        PictureBox_back_to_home_from_registration_students.Visible = False
        PictureBox_complete_registration_students.Visible = False

        Label_edit.Visible = False


        PictureBox_back_to_home_from_students_and_teachers_list.Visible = True


        StudentDataGridView.Visible = True

        PictureBox_edit_students.Visible = True

        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
        End If

        Label_students_teachers_count.Visible = True
        Label_boy_count.Visible = True
        Label_girl_count.Visible = True

        PictureBox_population_count.Visible = True
        PictureBox_boy_count.Visible = True
        PictureBox_girl_count.Visible = True

        Label_students_teachers_count.Text = StudentDataGridView.RowCount

        gender_count_s()

        GridColor(StudentDataGridView)



        '  For b = 0 To 14
        'StudentDataGridView.Rows.Item(cont_s).Cells.Item(b).Style.BackColor = Color.Green
        '  Next
    End Sub

    Sub complete_edit_t()
        database_edit_t()


        Label_name_t.Visible = False
        Label_lastname_t.Visible = False
        Label_phone_t.Visible = False
        Label_telephone_t.Visible = False
        Label_address_t.Visible = False
        Label_datebirth_t.Visible = False
        Label_date_t.Visible = False
        Label_codemeli_t.Visible = False
        Label_evidence.Visible = False
        Label_gender_t.Visible = False


        TextBox_name_t.Visible = False
        TextBox_lastname_t.Visible = False
        TextBox_phone_t.Visible = False
        TextBox_telephone_t.Visible = False
        TextBox_address_t.Visible = False
        TextBox_datebirth_t_day.Visible = False
        TextBox_datebirth_t_month.Visible = False
        TextBox_datebirth_t_year.Visible = False
        TextBox_date_t_day.Visible = False
        TextBox_date_t_month.Visible = False
        TextBox_date_t_year.Visible = False
        TextBox_codemeli_t.Visible = False
        TextBox_evidence.Visible = False


        RadioButton_male_t.Visible = False
        RadioButton_female_t.Visible = False

        Label_language_t_edit.Visible = False
        ComboBox_language_t_edit.Visible = False


        PictureBox_back_to_home_from_registration_teachers.Visible = False
        PictureBox_complete_registration_teachers.Visible = False

        Label_edit.Visible = False


        PictureBox_back_to_home_from_students_and_teachers_list.Visible = True


        TeachersDataGridView.Visible = True

        PictureBox_edit_teachers.Visible = True

        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
        End If

        Label_students_teachers_count.Visible = True
        Label_boy_count.Visible = True
        Label_girl_count.Visible = True

        PictureBox_population_count.Visible = True
        PictureBox_boy_count.Visible = True
        PictureBox_girl_count.Visible = True

        Label_students_teachers_count.Text = TeachersDataGridView.RowCount

        gender_count_t()

        GridColor(TeachersDataGridView)

        '  TeachersBindingSource.MoveLast()


        '   For b = 0 To 11
        'TeachersDataGridView.Rows.Item(TeachersDataGridView.RowCount - 1).Cells.Item(b).Style.BackColor = Color.Green
        '    Next
    End Sub

    Sub show_student_teachers_list()
        PictureBox_home.Visible = False

        Label_title.Visible = False

        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False

        PictureBox_back_to_home_from_students_and_teachers_list.Visible = True



        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If

        Label_students_teachers_count.Visible = True
        Label_boy_count.Visible = True
        Label_girl_count.Visible = True

        PictureBox_population_count.Visible = True
        PictureBox_boy_count.Visible = True
        PictureBox_girl_count.Visible = True

        If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)


    End Sub

    Sub b_f_student_and_teacher_list()
        PictureBox_home.Visible = True

        Label_title.Visible = True


        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True

        PictureBox_setting.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        If Radio_persian.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If

        PictureBox_level_test.Visible = True
        PictureBox_charts_show.Visible = True
        PictureBox_Accounting.Visible = True





        StudentDataGridView.Visible = False
        TeachersDataGridView.Visible = False

        PictureBox_back_to_home_from_students_and_teachers_list.Visible = False

        PictureBox_delete_students.Visible = False
        PictureBox_delete_teachers.Visible = False

        PictureBox_edit_students.Visible = False
        PictureBox_edit_teachers.Visible = False



        TextBox_search.Visible = False
        PictureBox_search.Visible = False
        PictureBox_search.Location = New System.Drawing.Point(485, 25)



        Label_students_teachers_count.Visible = False


        Label_boy_count.Visible = False
        Label_girl_count.Visible = False

        PictureBox_population_count.Visible = False
        PictureBox_boy_count.Visible = False
        PictureBox_girl_count.Visible = False



    End Sub



    Sub language_count_s()

        language_English = 0
        language_Turkish = 0
        language_Spanish = 0
        language_Italian = 0
        language_French = 0
        language_Arabic = 0
        language_Chinese = 0
        language_Japanese = 0
        language_Korean = 0

        For i = 0 To StudentDataGridView.RowCount - 1
            Select Case StudentDataGridView.Rows.Item(i).Cells(13).Value
                Case "English"
                    language_English = language_English + 1
                Case "Turkish"
                    language_Turkish = language_Turkish + 1
                Case "Spanish"
                    language_Spanish = language_Spanish + 1
                Case "Italian"
                    language_Italian = language_Italian + 1
                Case "French"
                    language_French = language_French + 1
                Case "Arabic"
                    language_Arabic = language_Arabic + 1
                Case "Chinese"
                    language_Chinese = language_Chinese + 1
                Case "Japanese"
                    language_Japanese = language_Japanese + 1
                Case "Korean"
                    language_Korean = language_Korean + 1
                Case "انگلیسی"
                    language_English = language_English + 1
                Case "ترکی"
                    language_Turkish = language_Turkish + 1
                Case "اسپانیایی"
                    language_Spanish = language_Spanish + 1
                Case "ایتالیایی"
                    language_Italian = language_Italian + 1
                Case "فرانسه ای"
                    language_French = language_French + 1
                Case "عربی"
                    language_Arabic = language_Arabic + 1
                Case "چینی"
                    language_Chinese = language_Chinese + 1
                Case "ژاپنی"
                    language_Japanese = language_Japanese + 1
                Case "کره ای"
                    language_Korean = language_Korean + 1
            End Select
        Next
        language_count_all = 0
        language_count_all = language_count_all + language_English + language_Turkish + language_Spanish + language_Italian + language_French + language_Arabic + language_Chinese + language_Japanese + language_Korean
    End Sub
    Sub gender_count_s()
        Male = 0
        Female = 0
        For i = 0 To StudentDataGridView.RowCount - 1
            Select Case StudentDataGridView.Rows.Item(i).Cells(12).Value
                Case "زن"
                    Female = Female + 1
                Case "Female"
                    Female = Female + 1
                Case "مرد"
                    Male = Male + 1
                Case "Male"
                    Male = Male + 1
            End Select
            Label_boy_count.Text = Male
            Label_girl_count.Text = Female
        Next
        gender_count_all = 0
        gender_count_all = gender_count_all + Male + Female
    End Sub

    Sub language_count_t()
        language_English = 0
        language_Turkish = 0
        language_Spanish = 0
        language_Italian = 0
        language_French = 0
        language_Arabic = 0
        language_Chinese = 0
        language_Japanese = 0
        language_Korean = 0

        For i = 0 To TeachersDataGridView.RowCount - 1
            Select Case TeachersDataGridView.Rows.Item(i).Cells(11).Value
                Case "English"
                    language_English = language_English + 1
                Case "Turkish"
                    language_Turkish = language_Turkish + 1
                Case "Spanish"
                    language_Spanish = language_Spanish + 1
                Case "Italian"
                    language_Italian = language_Italian + 1
                Case "French"
                    language_French = language_French + 1
                Case "Arabic"
                    language_Arabic = language_Arabic + 1
                Case "Chinese"
                    language_Chinese = language_Chinese + 1
                Case "Japanese"
                    language_Japanese = language_Japanese + 1
                Case "Korean"
                    language_Korean = language_Korean + 1
                Case "انگلیسی"
                    language_English = language_English + 1
                Case "ترکی"
                    language_Turkish = language_Turkish + 1
                Case "اسپانیایی"
                    language_Spanish = language_Spanish + 1
                Case "ایتالیایی"
                    language_Italian = language_Italian + 1
                Case "فرانسه ای"
                    language_French = language_French + 1
                Case "عربی"
                    language_Arabic = language_Arabic + 1
                Case "چینی"
                    language_Chinese = language_Chinese + 1
                Case "ژاپنی"
                    language_Japanese = language_Japanese + 1
                Case "کره ای"
                    language_Korean = language_Korean + 1
            End Select
        Next
        language_count_all = 0
        language_count_all = language_count_all + language_English + language_Turkish + language_Spanish + language_Italian + language_French + language_Arabic + language_Chinese + language_Japanese + language_Korean
    End Sub
    Sub gender_count_t()
        Male = 0
        Female = 0
        For i = 0 To TeachersDataGridView.RowCount - 1
            Select Case TeachersDataGridView.Rows.Item(i).Cells(10).Value
                Case "زن"
                    Female = Female + 1
                Case "Female"
                    Female = Female + 1
                Case "مرد"
                    Male = Male + 1
                Case "Male"
                    Male = Male + 1
            End Select
            Label_boy_count.Text = Male
            Label_girl_count.Text = Female
        Next
        gender_count_all = 0
        gender_count_all = gender_count_all + Male + Female
    End Sub

    Sub language_count_s_t()

        language_English = 0
        language_Turkish = 0
        language_Spanish = 0
        language_Italian = 0
        language_French = 0
        language_Arabic = 0
        language_Chinese = 0
        language_Japanese = 0
        language_Korean = 0

        For i = 0 To StudentDataGridView.RowCount - 1
            Select Case StudentDataGridView.Rows.Item(i).Cells(13).Value
                Case "English"
                    language_English = language_English + 1
                Case "Turkish"
                    language_Turkish = language_Turkish + 1
                Case "Spanish"
                    language_Spanish = language_Spanish + 1
                Case "Italian"
                    language_Italian = language_Italian + 1
                Case "French"
                    language_French = language_French + 1
                Case "Arabic"
                    language_Arabic = language_Arabic + 1
                Case "Chinese"
                    language_Chinese = language_Chinese + 1
                Case "Japanese"
                    language_Japanese = language_Japanese + 1
                Case "Korean"
                    language_Korean = language_Korean + 1
                Case "انگلیسی"
                    language_English = language_English + 1
                Case "ترکی"
                    language_Turkish = language_Turkish + 1
                Case "اسپانیایی"
                    language_Spanish = language_Spanish + 1
                Case "ایتالیایی"
                    language_Italian = language_Italian + 1
                Case "فرانسه ای"
                    language_French = language_French + 1
                Case "عربی"
                    language_Arabic = language_Arabic + 1
                Case "چینی"
                    language_Chinese = language_Chinese + 1
                Case "ژاپنی"
                    language_Japanese = language_Japanese + 1
                Case "کره ای"
                    language_Korean = language_Korean + 1
            End Select
        Next
        For i = 0 To TeachersDataGridView.RowCount - 1
            Select Case TeachersDataGridView.Rows.Item(i).Cells(11).Value
                Case "English"
                    language_English = language_English + 1
                Case "Turkish"
                    language_Turkish = language_Turkish + 1
                Case "Spanish"
                    language_Spanish = language_Spanish + 1
                Case "Italian"
                    language_Italian = language_Italian + 1
                Case "French"
                    language_French = language_French + 1
                Case "Arabic"
                    language_Arabic = language_Arabic + 1
                Case "Chinese"
                    language_Chinese = language_Chinese + 1
                Case "Japanese"
                    language_Japanese = language_Japanese + 1
                Case "Korean"
                    language_Korean = language_Korean + 1
                Case "انگلیسی"
                    language_English = language_English + 1
                Case "ترکی"
                    language_Turkish = language_Turkish + 1
                Case "اسپانیایی"
                    language_Spanish = language_Spanish + 1
                Case "ایتالیایی"
                    language_Italian = language_Italian + 1
                Case "فرانسه ای"
                    language_French = language_French + 1
                Case "عربی"
                    language_Arabic = language_Arabic + 1
                Case "چینی"
                    language_Chinese = language_Chinese + 1
                Case "ژاپنی"
                    language_Japanese = language_Japanese + 1
                Case "کره ای"
                    language_Korean = language_Korean + 1
            End Select
        Next
        language_count_all = 0
        language_count_all = language_count_all + language_English + language_Turkish + language_Spanish + language_Italian + language_French + language_Arabic + language_Chinese + language_Japanese + language_Korean
    End Sub
    Sub gender_count_s_t()
        Male = 0
        Female = 0
        For i = 0 To StudentDataGridView.RowCount - 1
            Select Case StudentDataGridView.Rows.Item(i).Cells(12).Value
                Case "زن"
                    Female = Female + 1
                Case "Female"
                    Female = Female + 1
                Case "مرد"
                    Male = Male + 1
                Case "Male"
                    Male = Male + 1
            End Select
        Next
        For i = 0 To TeachersDataGridView.RowCount - 1
            Select Case TeachersDataGridView.Rows.Item(i).Cells(10).Value
                Case "زن"
                    Female = Female + 1
                Case "Female"
                    Female = Female + 1
                Case "مرد"
                    Male = Male + 1
                Case "Male"
                    Male = Male + 1
            End Select
        Next
        gender_count_all = 0
        gender_count_all = gender_count_all + Male + Female
    End Sub

   
   
    Sub chart_students_language()
        Chart_students.Series("Chart_students_gender").Enabled = False
        Chart_students.Series("Chart_students_birthday").Enabled = False
        Chart_students.Series("Chart_students_date_of_registration").Enabled = False
        Chart_students.Series("Chart_students_language").Enabled = True

        language_count_s()


        Chart_students.Series("Chart_students_language").Points(0).YValues(0) = language_English
        Chart_students.Series("Chart_students_language").Points(1).YValues(0) = language_Turkish
        Chart_students.Series("Chart_students_language").Points(2).YValues(0) = language_Spanish
        Chart_students.Series("Chart_students_language").Points(3).YValues(0) = language_Italian
        Chart_students.Series("Chart_students_language").Points(4).YValues(0) = language_French
        Chart_students.Series("Chart_students_language").Points(5).YValues(0) = language_Arabic
        Chart_students.Series("Chart_students_language").Points(6).YValues(0) = language_Chinese
        Chart_students.Series("Chart_students_language").Points(7).YValues(0) = language_Japanese
        Chart_students.Series("Chart_students_language").Points(8).YValues(0) = language_Korean


        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_students.Series("Chart_students_language").Points(0).Label = "English"
                If Not language_Turkish = 0 Then Chart_students.Series("Chart_students_language").Points(1).Label = "Turkish"
                If Not language_Spanish = 0 Then Chart_students.Series("Chart_students_language").Points(2).Label = "Spanish"
                If Not language_Italian = 0 Then Chart_students.Series("Chart_students_language").Points(3).Label = "Italian"
                If Not language_French = 0 Then Chart_students.Series("Chart_students_language").Points(4).Label = "French"
                If Not language_Arabic = 0 Then Chart_students.Series("Chart_students_language").Points(5).Label = "Arabic"
                If Not language_Chinese = 0 Then Chart_students.Series("Chart_students_language").Points(6).Label = "Chinese"
                If Not language_Japanese = 0 Then Chart_students.Series("Chart_students_language").Points(7).Label = "Japanese"
                If Not language_Korean = 0 Then Chart_students.Series("Chart_students_language").Points(8).Label = "Korean"
            Case 0
                If Not language_English = 0 Then Chart_students.Series("Chart_students_language").Points(0).Label = "انگلیسی"
                If Not language_Turkish = 0 Then Chart_students.Series("Chart_students_language").Points(1).Label = "ترکی"
                If Not language_Spanish = 0 Then Chart_students.Series("Chart_students_language").Points(2).Label = "اسپانیایی"
                If Not language_Italian = 0 Then Chart_students.Series("Chart_students_language").Points(3).Label = "ایتالیایی"
                If Not language_French = 0 Then Chart_students.Series("Chart_students_language").Points(4).Label = "فرانسه ای"
                If Not language_Arabic = 0 Then Chart_students.Series("Chart_students_language").Points(5).Label = "عربی"
                If Not language_Chinese = 0 Then Chart_students.Series("Chart_students_language").Points(6).Label = "چینی"
                If Not language_Japanese = 0 Then Chart_students.Series("Chart_students_language").Points(7).Label = "ژاپنی"
                If Not language_Korean = 0 Then Chart_students.Series("Chart_students_language").Points(8).Label = "کره ای"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_students.Series("Chart_students_language").Points(0).ToolTip = language_English & "  " & "language learners are studying English" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_students.Series("Chart_students_language").Points(1).ToolTip = language_Turkish & "  " & "language learners are studying Turkish" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_students.Series("Chart_students_language").Points(2).ToolTip = language_Spanish & "  " & "language learners are studying Spanish" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_students.Series("Chart_students_language").Points(3).ToolTip = language_Italian & "  " & "language learners are studying Italian" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_students.Series("Chart_students_language").Points(4).ToolTip = language_French & "  " & "language learners are studying French" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_students.Series("Chart_students_language").Points(5).ToolTip = language_Arabic & "  " & "language learners are studying Arabic" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_students.Series("Chart_students_language").Points(6).ToolTip = language_Chinese & "  " & "language learners are studying Chinese" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_students.Series("Chart_students_language").Points(7).ToolTip = language_Japanese & "  " & "language learners are studying Japanese" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_students.Series("Chart_students_language").Points(8).ToolTip = language_Korean & "  " & "language learners are studying Korean" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_students.Series("Chart_students_language").Points(0).ToolTip = language_English & "  " & "language learner is studying English" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_students.Series("Chart_students_language").Points(1).ToolTip = language_Turkish & "  " & "language learner is studying Turkish" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_students.Series("Chart_students_language").Points(2).ToolTip = language_Spanish & "  " & "language learner is studying Spanish" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_students.Series("Chart_students_language").Points(3).ToolTip = language_Italian & "  " & "language learner is studying Italian" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_students.Series("Chart_students_language").Points(4).ToolTip = language_French & "  " & "language learner is studying French" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_students.Series("Chart_students_language").Points(5).ToolTip = language_Arabic & "  " & "language learner is studying Arabic" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_students.Series("Chart_students_language").Points(6).ToolTip = language_Chinese & "  " & "language learner is studying Chinese" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_students.Series("Chart_students_language").Points(7).ToolTip = language_Japanese & "  " & "language learner is studying Japanese" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_students.Series("Chart_students_language").Points(8).ToolTip = language_Korean & "  " & "language learner is studying Korean" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
            Case 0
                If Not language_English = 0 Then Chart_students.Series("Chart_students_language").Points(0).ToolTip = language_English & "زبان آموز در حال تحصیل در زبان انگلیسی هستند" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_students.Series("Chart_students_language").Points(1).ToolTip = language_Turkish & "زبان آموز در حال تحصیل در زبان ترکی هستند" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_students.Series("Chart_students_language").Points(2).ToolTip = language_Spanish & "زبان آموز در حال تحصیل در زبان اسپانیایی هستند" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_students.Series("Chart_students_language").Points(3).ToolTip = language_Italian & "زبان آموز در حال تحصیل در زبان ایتالیایی هستند" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_students.Series("Chart_students_language").Points(4).ToolTip = language_French & "زبان آموز در حال تحصیل در زبان فرانسه ای هستند" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_students.Series("Chart_students_language").Points(5).ToolTip = language_Arabic & "زبان آموز در حال تحصیل در زبان عربی هستند" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_students.Series("Chart_students_language").Points(6).ToolTip = language_Chinese & "زبان آموز در حال تحصیل در زبان چینی هستند" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_students.Series("Chart_students_language").Points(7).ToolTip = language_Japanese & "زبان آموز در حال تحصیل در زبان ژاپنی هستند" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_students.Series("Chart_students_language").Points(8).ToolTip = language_Korean & "زبان آموز در حال تحصیل در زبان کره ای هستند" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_students.Series("Chart_students_language").Points(0).ToolTip = language_English & "زبان آموز در حال تحصیل در زبان انگلیسی است" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_students.Series("Chart_students_language").Points(1).ToolTip = language_Turkish & "زبان آموز در حال تحصیل در زبان ترکی است" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_students.Series("Chart_students_language").Points(2).ToolTip = language_Spanish & "زبان آموز در حال تحصیل در زبان اسپانیایی است" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_students.Series("Chart_students_language").Points(3).ToolTip = language_Italian & "زبان آموز در حال تحصیل در زبان ایتالیایی است" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_students.Series("Chart_students_language").Points(4).ToolTip = language_French & "زبان آموز در حال تحصیل در زبان فرانسه ای است" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_students.Series("Chart_students_language").Points(5).ToolTip = language_Arabic & "زبان آموز در حال تحصیل در زبان عربی است" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_students.Series("Chart_students_language").Points(6).ToolTip = language_Chinese & "زبان آموز در حال تحصیل در زبان چینی است" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_students.Series("Chart_students_language").Points(7).ToolTip = language_Japanese & "زبان آموز در حال تحصیل در زبان ژاپنی است" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_students.Series("Chart_students_language").Points(8).ToolTip = language_Korean & "زبان آموز در حال تحصیل در زبان کره ای است" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
        End Select
    End Sub
    Sub chart_students_gender()
        Chart_students.Series("Chart_students_language").Enabled = False
        Chart_students.Series("Chart_students_birthday").Enabled = False
        Chart_students.Series("Chart_students_date_of_registration").Enabled = False
        Chart_students.Series("Chart_students_gender").Enabled = True

        gender_count_s()


        Chart_students.Series("Chart_students_gender").Points(0).YValues(0) = Male
        Chart_students.Series("Chart_students_gender").Points(1).YValues(0) = Female



        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_students.Series("Chart_students_gender").Points(0).Label = "MALE"
                If Not Female = 0 Then Chart_students.Series("Chart_students_gender").Points(1).Label = "FEMALE"
            Case 0
                If Not Male = 0 Then Chart_students.Series("Chart_students_gender").Points(0).Label = "مرد"
                If Not Female = 0 Then Chart_students.Series("Chart_students_gender").Points(1).Label = "زن"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_students.Series("Chart_students_gender").Points(0).ToolTip = Male & "  " & "male language learners are studying at this institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_students.Series("Chart_students_gender").Points(1).ToolTip = Female & "  " & "female language learners are studying at this institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_students.Series("Chart_students_gender").Points(0).ToolTip = Male & "  " & "male language learner is studying at this institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_students.Series("Chart_students_gender").Points(1).ToolTip = Female & "  " & "female language learner is studying at this institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
            Case 0
                If Not Male = 0 Then Chart_students.Series("Chart_students_gender").Points(0).ToolTip = Male & "زبان آموز مرد در حال تحصیل در این آموزشگاه هستند" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_students.Series("Chart_students_gender").Points(1).ToolTip = Female & "زبان آموز زن در حال تحصیل در این آموزشگاه هستند" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_students.Series("Chart_students_gender").Points(0).ToolTip = Male & "زبان آموز مرد در حال تحصیل در این آموزشگاه است" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_students.Series("Chart_students_gender").Points(1).ToolTip = Female & "زبان آموز زن در حال تحصیل در این آموزشگاه است" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
        End Select
    End Sub
    Sub chart_student_birthday()
        Chart_students.Series("Chart_students_language").Enabled = False
        Chart_students.Series("Chart_students_gender").Enabled = False
        Chart_students.Series("Chart_students_date_of_registration").Enabled = False
        Chart_students.Series("Chart_students_birthday").Enabled = True


        birthday_count_all = 0

        birthday_count_chart_student = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_student = birthday_count_chart_student + 1

            Dim searchQuery As String = ("SELECT * From student WHERE CONCAT(birthday_s,language_s) like N'%" & birthday_count_chart_student & "%'")
            Dim command As New SqlCommand(searchQuery, connect_S)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            StudentDataGridView.DataSource = DataTable

            Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) = StudentDataGridView.Rows.Count

            If Not Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) = 0 Then
                Chart_students.Series(2).Points(birthday_count_chart_student - 1300).Label = birthday_count_chart_student
                birthday_count_all = birthday_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) > 1 Then Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip = StudentDataGridView.Rows.Count & "  " & "language learners were born in" & "  " & birthday_count_chart_student
                    If Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) = 1 Then Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip = StudentDataGridView.Rows.Count & "  " & "language learner was born in" & "  " & birthday_count_chart_student
                Case 0
                    If Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) > 1 Then Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip = StudentDataGridView.Rows.Count & "زبان آموز متولد سال" & "  " & birthday_count_chart_student & "  " & "هستند"
                    If Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) = 1 Then Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip = StudentDataGridView.Rows.Count & "زبان آموز متولد سال" & "  " & birthday_count_chart_student & "  " & "است"
            End Select
        Next


        birthday_count_all = birthday_count_all + 1
        birthday_count_chart_student = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_student = birthday_count_chart_student + 1


            Dim searchQuery As String = ("SELECT * From student WHERE CONCAT(birthday_s,language_s) like N'%" & birthday_count_chart_student & "%'")
            Dim command As New SqlCommand(searchQuery, connect_S)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            StudentDataGridView.DataSource = DataTable

            Chart_students.Series(2).Points(birthday_count_chart_student - 1300).YValues(0) = StudentDataGridView.Rows.Count
          
            Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip = Chart_students.Series(2).Points(birthday_count_chart_student - 1300).ToolTip & vbNewLine & Math.Round(StudentDataGridView.Rows.Count * 100 / birthday_count_all) & "%"
        Next
    End Sub
    Sub chart_student_date_of_registration()
        Chart_students.Series("Chart_students_language").Enabled = False
        Chart_students.Series("Chart_students_gender").Enabled = False
        Chart_students.Series("Chart_students_birthday").Enabled = False
        Chart_students.Series("Chart_students_date_of_registration").Enabled = True

        date_of_registration_count_all = 0

        date_of_registration_count_chart_student = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_student = date_of_registration_count_chart_student + 1

            Dim searchQuery As String = ("SELECT * From student WHERE CONCAT(date_s,language_s) like N'%" & date_of_registration_count_chart_student & "%'")
            Dim command As New SqlCommand(searchQuery, connect_S)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            StudentDataGridView.DataSource = DataTable

            Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) = StudentDataGridView.Rows.Count

            If Not Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) = 0 Then
                Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).Label = date_of_registration_count_chart_student
                date_of_registration_count_all = date_of_registration_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) > 1 Then Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip = StudentDataGridView.Rows.Count & "  " & "language learners have been registered at this institute in" & "  " & date_of_registration_count_chart_student
                    If Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) = 1 Then Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip = StudentDataGridView.Rows.Count & "  " & "language learner has been registered at this institute in" & "  " & date_of_registration_count_chart_student
                Case 0
                    If Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) > 1 Then Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip = StudentDataGridView.Rows.Count & "زبان آموز در سال" & "  " & date_of_registration_count_chart_student & "  " & "در این آموزشگاه ثبت نام کرده اند"
                    If Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) = 1 Then Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip = StudentDataGridView.Rows.Count & "زبان آموز در سال" & "  " & date_of_registration_count_chart_student & "  " & "در این آموزشگاه ثبت نام کرده است"
            End Select
        Next


        date_of_registration_count_all = date_of_registration_count_all + 1
        date_of_registration_count_chart_student = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_student = date_of_registration_count_chart_student + 1

            Dim searchQuery As String = ("SELECT * From student WHERE CONCAT(date_s,language_s) like N'%" & date_of_registration_count_chart_student & "%'")
            Dim command As New SqlCommand(searchQuery, connect_S)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            StudentDataGridView.DataSource = DataTable

            Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).YValues(0) = StudentDataGridView.Rows.Count

            Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip = Chart_students.Series(3).Points(date_of_registration_count_chart_student - 1350).ToolTip & vbNewLine & Math.Round(StudentDataGridView.Rows.Count * 100 / date_of_registration_count_all) & "%"
        Next
    End Sub

    Sub chart_teachers_language()
        Chart_teachers.Series("Chart_teachers_gender").Enabled = False
        Chart_teachers.Series("Chart_teachers_language").Enabled = True
        Chart_teachers.Series("Chart_teachers_date_of_registration").Enabled = False
        Chart_teachers.Series("Chart_teachers_birthday").Enabled = False

        language_count_t()


        Chart_teachers.Series("Chart_teachers_language").Points(0).YValues(0) = language_English
        Chart_teachers.Series("Chart_teachers_language").Points(1).YValues(0) = language_Turkish
        Chart_teachers.Series("Chart_teachers_language").Points(2).YValues(0) = language_Spanish
        Chart_teachers.Series("Chart_teachers_language").Points(3).YValues(0) = language_Italian
        Chart_teachers.Series("Chart_teachers_language").Points(4).YValues(0) = language_French
        Chart_teachers.Series("Chart_teachers_language").Points(5).YValues(0) = language_Arabic
        Chart_teachers.Series("Chart_teachers_language").Points(6).YValues(0) = language_Chinese
        Chart_teachers.Series("Chart_teachers_language").Points(7).YValues(0) = language_Japanese
        Chart_teachers.Series("Chart_teachers_language").Points(8).YValues(0) = language_Korean


        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(0).Label = "English"
                If Not language_Turkish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(1).Label = "Turkish"
                If Not language_Spanish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(2).Label = "Spanish"
                If Not language_Italian = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(3).Label = "Italian"
                If Not language_French = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(4).Label = "French"
                If Not language_Arabic = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(5).Label = "Arabic"
                If Not language_Chinese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(6).Label = "Chinese"
                If Not language_Japanese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(7).Label = "Japanese"
                If Not language_Korean = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(8).Label = "Korean"
            Case 0
                If Not language_English = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(0).Label = "انگلیسی"
                If Not language_Turkish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(1).Label = "ترکی"
                If Not language_Spanish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(2).Label = "اسپانیایی"
                If Not language_Italian = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(3).Label = "ایتالیایی"
                If Not language_French = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(4).Label = "فرانسه ای"
                If Not language_Arabic = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(5).Label = "عربی"
                If Not language_Chinese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(6).Label = "چینی"
                If Not language_Japanese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(7).Label = "ژاپنی"
                If Not language_Korean = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(8).Label = "کره ای"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(0).ToolTip = language_English & "  " & "teachers are teaching English" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(1).ToolTip = language_Turkish & "  " & "teachers are teaching Turkish" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(2).ToolTip = language_Spanish & "  " & "teachers are teaching Spanish" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(3).ToolTip = language_Italian & "  " & "teachers are teaching Italian" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(4).ToolTip = language_French & "  " & "teachers are teaching French" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(5).ToolTip = language_Arabic & "  " & "teachers are teaching Arabic" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(6).ToolTip = language_Chinese & "  " & "teachers are teaching Chinese" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(7).ToolTip = language_Japanese & "  " & "teachers are teaching Japanese" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(8).ToolTip = language_Korean & "  " & "teachers are teaching Korean" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(0).ToolTip = language_English & "  " & "teacher is teaching English" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(1).ToolTip = language_Turkish & "  " & "teacher is teaching Turkish" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(2).ToolTip = language_Spanish & "  " & "teacher is teaching Spanish" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(3).ToolTip = language_Italian & "  " & "teacher is teaching Italian" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(4).ToolTip = language_French & "  " & "teacher is teaching French" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(5).ToolTip = language_Arabic & "  " & "teacher is teaching Arabic" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(6).ToolTip = language_Chinese & "  " & "teacher is teaching Chinese" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(7).ToolTip = language_Japanese & "  " & "teacher is teaching Japanese" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(8).ToolTip = language_Korean & "  " & "teacher is teaching Korean" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
            Case 0
                If Not language_English = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(0).ToolTip = language_English & "معلم در حال تدریس زبان انگلیسی هستند" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(1).ToolTip = language_Turkish & "معلم در حال تدریس زبان ترکی هستند" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(2).ToolTip = language_Spanish & "معلم در حال تدریس زبان اسپانیایی هستند" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(3).ToolTip = language_Italian & "معلم در حال تدریس زبان ایتالیایی هستند" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(4).ToolTip = language_French & "معلم در حال تدریس زبان فرانسه ای هستند" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(5).ToolTip = language_Arabic & "معلم در حال تدریس زبان عربی هستند" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(6).ToolTip = language_Chinese & "معلم در حال تدریس زبان چینی هستند" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(7).ToolTip = language_Japanese & "معلم در حال تدریس زبان ژاپنی هستند" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_teachers.Series("Chart_teachers_language").Points(8).ToolTip = language_Korean & "معلم در حال تدریس زبان کره ای هستند" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(0).ToolTip = language_English & "معلم در حال تدریس زبان انگلیسی است" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(1).ToolTip = language_Turkish & "معلم در حال تدریس زبان ترکی است" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(2).ToolTip = language_Spanish & "معلم در حال تدریس زبان اسپانیایی است" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(3).ToolTip = language_Italian & "معلم در حال تدریس زبان ایتالیایی است" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(4).ToolTip = language_French & "معلم در حال تدریس زبان فرانسه ای است" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(5).ToolTip = language_Arabic & "معلم در حال تدریس زبان عربی است" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(6).ToolTip = language_Chinese & "معلم در حال تدریس زبان چینی است" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(7).ToolTip = language_Japanese & "معلم در حال تدریس زبان ژاپنی است" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_teachers.Series("Chart_teachers_language").Points(8).ToolTip = language_Korean & "معلم در حال تدریس زبان کره ای است" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
        End Select
    End Sub
    Sub chart_teachers_gender()
        Chart_teachers.Series("Chart_teachers_gender").Enabled = True
        Chart_teachers.Series("Chart_teachers_language").Enabled = False
        Chart_teachers.Series("Chart_teachers_date_of_registration").Enabled = False
        Chart_teachers.Series("Chart_teachers_birthday").Enabled = False

        gender_count_t()


        Chart_teachers.Series("Chart_teachers_gender").Points(0).YValues(0) = Male
        Chart_teachers.Series("Chart_teachers_gender").Points(1).YValues(0) = Female



        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).Label = "MALE"
                If Not Female = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).Label = "FEMALE"
            Case 0
                If Not Male = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).Label = "مرد"
                If Not Female = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).Label = "زن"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).ToolTip = Male & "  " & "male teachers are teaching at this institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).ToolTip = Female & "  " & "female teachers are teaching at this institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).ToolTip = Male & "  " & "male teacher is teaching at this institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).ToolTip = Female & "  " & "female teacher is teaching at this institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
            Case 0
                If Not Male = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).ToolTip = Male & "معلم مرد در حال تدریس در این آموزشگاه هستند" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).ToolTip = Female & "معلم زن در حال تدریس در این آموزشگاه هستند" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_teachers.Series("Chart_teachers_gender").Points(0).ToolTip = Male & "معلم مرد در حال تدریس در این آموزشگاه است" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_teachers.Series("Chart_teachers_gender").Points(1).ToolTip = Female & "معلم زن در حال تدریس در این آموزشگاه است" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
        End Select
    End Sub
    Sub chart_teachers_birthday()
        Chart_teachers.Series("Chart_teachers_language").Enabled = False
        Chart_teachers.Series("Chart_teachers_gender").Enabled = False
        Chart_teachers.Series("Chart_teachers_date_of_registration").Enabled = False
        Chart_teachers.Series("Chart_teachers_birthday").Enabled = True

        birthday_count_all = 0

        birthday_count_chart_teachers = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_teachers = birthday_count_chart_teachers + 1

            Dim searchQuery As String = ("SELECT * From teachers WHERE CONCAT(birthday_t,language_t) like N'%" & birthday_count_chart_teachers & "%'")
            Dim command As New SqlCommand(searchQuery, connect_T)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            TeachersDataGridView.DataSource = DataTable

            Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) = TeachersDataGridView.Rows.Count

            If Not Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) = 0 Then
                Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).Label = birthday_count_chart_teachers
                birthday_count_all = birthday_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) > 1 Then Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip = TeachersDataGridView.Rows.Count & "  " & "teachers were born in" & "  " & birthday_count_chart_teachers
                    If Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) = 1 Then Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip = TeachersDataGridView.Rows.Count & "  " & "teacher was born in" & "  " & birthday_count_chart_teachers
                Case 0
                    If Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) > 1 Then Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip = TeachersDataGridView.Rows.Count & "معلم متولد سال" & "  " & birthday_count_chart_teachers & "  " & "هستند"
                    If Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) = 1 Then Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip = TeachersDataGridView.Rows.Count & "معلم متولد سال" & "  " & birthday_count_chart_teachers & "  " & "است"
            End Select
        Next

        birthday_count_all = birthday_count_all + 1
        birthday_count_chart_teachers = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_teachers = birthday_count_chart_teachers + 1

            Dim searchQuery As String = ("SELECT * From teachers WHERE CONCAT(birthday_t,language_t) like N'%" & birthday_count_chart_teachers & "%'")
            Dim command As New SqlCommand(searchQuery, connect_T)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            TeachersDataGridView.DataSource = DataTable

            Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).YValues(0) = TeachersDataGridView.Rows.Count

            Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip = Chart_teachers.Series(2).Points(birthday_count_chart_teachers - 1300).ToolTip & vbNewLine & Math.Round(TeachersDataGridView.Rows.Count * 100 / birthday_count_all) & "%"
        Next
    End Sub
    Sub chart_teachers_date_of_registration()
        Chart_teachers.Series("Chart_teachers_language").Enabled = False
        Chart_teachers.Series("Chart_teachers_gender").Enabled = False
        Chart_teachers.Series("Chart_teachers_birthday").Enabled = False
        Chart_teachers.Series("Chart_teachers_date_of_registration").Enabled = True

        date_of_registration_count_all = 0

        date_of_registration_count_chart_teachers = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_teachers = date_of_registration_count_chart_teachers + 1

            Dim searchQuery As String = ("SELECT * From teachers WHERE CONCAT(data_t,language_t) like N'%" & date_of_registration_count_chart_teachers & "%'")
            Dim command As New SqlCommand(searchQuery, connect_T)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            TeachersDataGridView.DataSource = DataTable

            Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) = TeachersDataGridView.Rows.Count

            If Not Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) = 0 Then
                Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).Label = date_of_registration_count_chart_teachers
                date_of_registration_count_all = date_of_registration_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) > 1 Then Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip = TeachersDataGridView.Rows.Count & "  " & "teachers have been employed at this institute in" & "  " & date_of_registration_count_chart_teachers
                    If Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) = 1 Then Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip = TeachersDataGridView.Rows.Count & "  " & "teacher has been employed at this institute in" & "  " & date_of_registration_count_chart_teachers
                Case 0
                    If Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) > 1 Then Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip = TeachersDataGridView.Rows.Count & "معلم در سال" & "  " & date_of_registration_count_chart_teachers & "  " & "در این آموزشگاه استخدام شده اند"
                    If Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) = 1 Then Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip = TeachersDataGridView.Rows.Count & "معلم در سال" & "  " & date_of_registration_count_chart_teachers & "  " & "در این آموزشگاه استخدام شده است"
            End Select
        Next

        date_of_registration_count_all = date_of_registration_count_all + 1
        date_of_registration_count_chart_teachers = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_teachers = date_of_registration_count_chart_teachers + 1

            Dim searchQuery As String = ("SELECT * From teachers WHERE CONCAT(data_t,language_t) like N'%" & date_of_registration_count_chart_teachers & "%'")
            Dim command As New SqlCommand(searchQuery, connect_T)
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim DataTable As New DataTable
            da.Fill(DataTable)
            TeachersDataGridView.DataSource = DataTable

            Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).YValues(0) = TeachersDataGridView.Rows.Count

            Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip = Chart_teachers.Series(3).Points(date_of_registration_count_chart_teachers - 1350).ToolTip & vbNewLine & Math.Round(TeachersDataGridView.Rows.Count * 100 / date_of_registration_count_all) & "%"
        Next
    End Sub

    Sub chart_all_language()
        Chart_all.Series("Chart_all_gender").Enabled = False
        Chart_all.Series("Chart_all_date_of_registration").Enabled = False
        Chart_all.Series("Chart_all_birthday").Enabled = False
        Chart_all.Series("Chart_all_language").Enabled = True

        language_count_s_t()


        Chart_all.Series("Chart_all_language").Points(0).YValues(0) = language_English
        Chart_all.Series("Chart_all_language").Points(1).YValues(0) = language_Turkish
        Chart_all.Series("Chart_all_language").Points(2).YValues(0) = language_Spanish
        Chart_all.Series("Chart_all_language").Points(3).YValues(0) = language_Italian
        Chart_all.Series("Chart_all_language").Points(4).YValues(0) = language_French
        Chart_all.Series("Chart_all_language").Points(5).YValues(0) = language_Arabic
        Chart_all.Series("Chart_all_language").Points(6).YValues(0) = language_Chinese
        Chart_all.Series("Chart_all_language").Points(7).YValues(0) = language_Japanese
        Chart_all.Series("Chart_all_language").Points(8).YValues(0) = language_Korean


        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_all.Series("Chart_all_language").Points(0).Label = "English"
                If Not language_Turkish = 0 Then Chart_all.Series("Chart_all_language").Points(1).Label = "Turkish"
                If Not language_Spanish = 0 Then Chart_all.Series("Chart_all_language").Points(2).Label = "Spanish"
                If Not language_Italian = 0 Then Chart_all.Series("Chart_all_language").Points(3).Label = "Italian"
                If Not language_French = 0 Then Chart_all.Series("Chart_all_language").Points(4).Label = "French"
                If Not language_Arabic = 0 Then Chart_all.Series("Chart_all_language").Points(5).Label = "Arabic"
                If Not language_Chinese = 0 Then Chart_all.Series("Chart_all_language").Points(6).Label = "Chinese"
                If Not language_Japanese = 0 Then Chart_all.Series("Chart_all_language").Points(7).Label = "Japanese"
                If Not language_Korean = 0 Then Chart_all.Series("Chart_all_language").Points(8).Label = "Korean"
            Case 0
                If Not language_English = 0 Then Chart_all.Series("Chart_all_language").Points(0).Label = "انگلیسی"
                If Not language_Turkish = 0 Then Chart_all.Series("Chart_all_language").Points(1).Label = "ترکی"
                If Not language_Spanish = 0 Then Chart_all.Series("Chart_all_language").Points(2).Label = "اسپانیایی"
                If Not language_Italian = 0 Then Chart_all.Series("Chart_all_language").Points(3).Label = "ایتالیایی"
                If Not language_French = 0 Then Chart_all.Series("Chart_all_language").Points(4).Label = "فرانسه ای"
                If Not language_Arabic = 0 Then Chart_all.Series("Chart_all_language").Points(5).Label = "عربی"
                If Not language_Chinese = 0 Then Chart_all.Series("Chart_all_language").Points(6).Label = "چینی"
                If Not language_Japanese = 0 Then Chart_all.Series("Chart_all_language").Points(7).Label = "ژاپنی"
                If Not language_Korean = 0 Then Chart_all.Series("Chart_all_language").Points(8).Label = "کره ای"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not language_English = 0 Then Chart_all.Series("Chart_all_language").Points(0).ToolTip = "In total," & "  " & language_English & "  " & "persons are working or studying English at this institute" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_all.Series("Chart_all_language").Points(1).ToolTip = "In total," & "  " & language_Turkish & "  " & "persons are working or studying Turkish at this institute" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_all.Series("Chart_all_language").Points(2).ToolTip = "In total," & "  " & language_Spanish & "  " & "persons are working or studying Spanish at this institute" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_all.Series("Chart_all_language").Points(3).ToolTip = "In total," & "  " & language_Italian & "  " & "persons are working or studying Italian at this institute" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_all.Series("Chart_all_language").Points(4).ToolTip = "In total," & "  " & language_French & "  " & "persons are working or studying French at this institute" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_all.Series("Chart_all_language").Points(5).ToolTip = "In total," & "  " & language_Arabic & "  " & "persons are working or studying Arabic at this institute" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_all.Series("Chart_all_language").Points(6).ToolTip = "In total," & "  " & language_Chinese & "  " & "persons are working or studying Chinese at this institute" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_all.Series("Chart_all_language").Points(7).ToolTip = "In total," & "  " & language_Japanese & "  " & "persons are working or studying Japanese at this institute" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_all.Series("Chart_all_language").Points(8).ToolTip = "In total," & "  " & language_Korean & "  " & "persons are working or studying Korean at this institute" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_all.Series("Chart_all_language").Points(0).ToolTip = "In total," & "  " & language_English & "  " & "person is working or studying English at this institute" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_all.Series("Chart_all_language").Points(1).ToolTip = "In total," & "  " & language_Turkish & "  " & "person is working or studying Turkish at this institute" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_all.Series("Chart_all_language").Points(2).ToolTip = "In total," & "  " & language_Spanish & "  " & "person is working or studying Spanish at this institute" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_all.Series("Chart_all_language").Points(3).ToolTip = "In total," & "  " & language_Italian & "  " & "person is working or studying Italian at this institute" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_all.Series("Chart_all_language").Points(4).ToolTip = "In total," & "  " & language_French & "  " & "person is working or studying French at this institute" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_all.Series("Chart_all_language").Points(5).ToolTip = "In total," & "  " & language_Arabic & "  " & "person is working or studying Arabic at this institute" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_all.Series("Chart_all_language").Points(6).ToolTip = "In total," & "  " & language_Chinese & "  " & "person is working or studying Chinese at this institute" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_all.Series("Chart_all_language").Points(7).ToolTip = "In total," & "  " & language_Japanese & "  " & "person is working or studying Japanese at this institute" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_all.Series("Chart_all_language").Points(8).ToolTip = "In total," & "  " & language_Korean & "  " & "person is working or studying Korean at this institute" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
            Case 0
                If Not language_English = 0 Then Chart_all.Series("Chart_all_language").Points(0).ToolTip = "در مجموع،" & "  " & language_English & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان انگلیسی هستند" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If Not language_Turkish = 0 Then Chart_all.Series("Chart_all_language").Points(1).ToolTip = "در مجموع،" & "  " & language_Turkish & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ترکی هستند" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If Not language_Spanish = 0 Then Chart_all.Series("Chart_all_language").Points(2).ToolTip = "در مجموع،" & "  " & language_Spanish & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان اسپانیایی هستند" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If Not language_Italian = 0 Then Chart_all.Series("Chart_all_language").Points(3).ToolTip = "در مجموع،" & "  " & language_Italian & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ایتالیایی هستند" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If Not language_French = 0 Then Chart_all.Series("Chart_all_language").Points(4).ToolTip = "در مجموع،" & "  " & language_French & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان فرانسه ای هستند" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If Not language_Arabic = 0 Then Chart_all.Series("Chart_all_language").Points(5).ToolTip = "در مجموع،" & "  " & language_Arabic & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان عربی هستند" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If Not language_Chinese = 0 Then Chart_all.Series("Chart_all_language").Points(6).ToolTip = "در مجموع،" & "  " & language_Chinese & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان چینی هستند" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If Not language_Japanese = 0 Then Chart_all.Series("Chart_all_language").Points(7).ToolTip = "در مجموع،" & "  " & language_Japanese & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ژاپنی هستند" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If Not language_Korean = 0 Then Chart_all.Series("Chart_all_language").Points(8).ToolTip = "در مجموع،" & "  " & language_Korean & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان کره ای هستند" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
                If language_English = 1 Then Chart_all.Series("Chart_all_language").Points(0).ToolTip = "در مجموع،" & "  " & language_English & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان انگلیسی است" & vbNewLine & Math.Round(language_English * 100 / language_count_all) & "%"
                If language_Turkish = 1 Then Chart_all.Series("Chart_all_language").Points(1).ToolTip = "در مجموع،" & "  " & language_Turkish & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ترکی است" & vbNewLine & Math.Round(language_Turkish * 100 / language_count_all) & "%"
                If language_Spanish = 1 Then Chart_all.Series("Chart_all_language").Points(2).ToolTip = "در مجموع،" & "  " & language_Spanish & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان اسپانیایی است" & vbNewLine & Math.Round(language_Spanish * 100 / language_count_all) & "%"
                If language_Italian = 1 Then Chart_all.Series("Chart_all_language").Points(3).ToolTip = "در مجموع،" & "  " & language_Italian & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ایتالیایی است" & vbNewLine & Math.Round(language_Italian * 100 / language_count_all) & "%"
                If language_French = 1 Then Chart_all.Series("Chart_all_language").Points(4).ToolTip = "در مجموع،" & "  " & language_French & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان فرانسه ای است" & vbNewLine & Math.Round(language_French * 100 / language_count_all) & "%"
                If language_Arabic = 1 Then Chart_all.Series("Chart_all_language").Points(5).ToolTip = "در مجموع،" & "  " & language_Arabic & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان عربی است" & vbNewLine & Math.Round(language_Arabic * 100 / language_count_all) & "%"
                If language_Chinese = 1 Then Chart_all.Series("Chart_all_language").Points(6).ToolTip = "در مجموع،" & "  " & language_Chinese & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان چینی است" & vbNewLine & Math.Round(language_Chinese * 100 / language_count_all) & "%"
                If language_Japanese = 1 Then Chart_all.Series("Chart_all_language").Points(7).ToolTip = "در مجموع،" & "  " & language_Japanese & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان ژاپنی است" & vbNewLine & Math.Round(language_Japanese * 100 / language_count_all) & "%"
                If language_Korean = 1 Then Chart_all.Series("Chart_all_language").Points(8).ToolTip = "در مجموع،" & "  " & language_Korean & "  " & "نفر در این موسسه در حال فعالیت تحصیلی یا کاری در زبان کره ای است" & vbNewLine & Math.Round(language_Korean * 100 / language_count_all) & "%"
        End Select
    End Sub
    Sub chart_all_gender()
        Chart_all.Series("Chart_all_language").Enabled = False
        Chart_all.Series("Chart_all_date_of_registration").Enabled = False
        Chart_all.Series("Chart_all_birthday").Enabled = False
        Chart_all.Series("Chart_all_gender").Enabled = True

        gender_count_s_t()


        Chart_all.Series("Chart_all_gender").Points(0).YValues(0) = Male
        Chart_all.Series("Chart_all_gender").Points(1).YValues(0) = Female



        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_all.Series("Chart_all_gender").Points(0).Label = "MALE"
                If Not Female = 0 Then Chart_all.Series("Chart_all_gender").Points(1).Label = "FEMALE"
            Case 0
                If Not Male = 0 Then Chart_all.Series("Chart_all_gender").Points(0).Label = "مرد"
                If Not Female = 0 Then Chart_all.Series("Chart_all_gender").Points(1).Label = "زن"
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                If Not Male = 0 Then Chart_all.Series("Chart_all_gender").Points(0).ToolTip = "In total," & "  " & Male & "  " & "male are studying or working at the institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_all.Series("Chart_all_gender").Points(1).ToolTip = "In total," & "  " & Female & "  " & "female are studying or working at the institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_all.Series("Chart_all_gender").Points(0).ToolTip = "In total," & "  " & Male & "  " & "male is studying or working at the institute" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_all.Series("Chart_all_gender").Points(1).ToolTip = "In total," & "  " & Female & "  " & "female is studying or working at the institute" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
            Case 0
                If Not Male = 0 Then Chart_all.Series("Chart_all_gender").Points(0).ToolTip = "در مجموع،" & "  " & Male & "  " & "مرد در حال فعالیت تحصیلی یا کاری در این آموزشگاه هستند" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Not Female = 0 Then Chart_all.Series("Chart_all_gender").Points(1).ToolTip = "در مجموع،" & "  " & Female & "  " & "زن در حال فعالیت تحصیلی یا کاری در این آموزشگاه هستند" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
                If Male = 1 Then Chart_all.Series("Chart_all_gender").Points(0).ToolTip = "در مجموع،" & "  " & Male & "  " & "مرد در حال فعالیت تحصیلی یا کاری در این آموزشگاه است" & vbNewLine & Math.Round(Male * 100 / gender_count_all) & "%"
                If Female = 1 Then Chart_all.Series("Chart_all_gender").Points(1).ToolTip = "در مجموع،" & "  " & Female & "  " & "زن در حال فعالیت تحصیلی یا کاری در این آموزشگاه است" & vbNewLine & Math.Round(Female * 100 / gender_count_all) & "%"
        End Select
    End Sub
    Sub chart_all_birthday()
        Chart_all.Series("Chart_all_language").Enabled = False
        Chart_all.Series("Chart_all_gender").Enabled = False
        Chart_all.Series("Chart_all_date_of_registration").Enabled = False
        Chart_all.Series("Chart_all_birthday").Enabled = True

        birthday_count_all = 0

        birthday_count_chart_all = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_all = birthday_count_chart_all + 1

            Dim searchQuery_s As String = ("SELECT * From student WHERE CONCAT(birthday_s,language_s) like N'%" & birthday_count_chart_all & "%'")
            Dim command_s As New SqlCommand(searchQuery_s, connect_S)
            Dim da_s As SqlDataAdapter = New SqlDataAdapter(command_s)
            Dim DataTable_s As New DataTable
            da_s.Fill(DataTable_s)
            StudentDataGridView.DataSource = DataTable_s

            Dim searchQuery_t As String = ("SELECT * From teachers WHERE CONCAT(birthday_t,language_t) like N'%" & birthday_count_chart_all & "%'")
            Dim command_t As New SqlCommand(searchQuery_t, connect_T)
            Dim da_t As SqlDataAdapter = New SqlDataAdapter(command_t)
            Dim DataTable_t As New DataTable
            da_t.Fill(DataTable_t)
            TeachersDataGridView.DataSource = DataTable_t

            Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count

            If Not Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) = 0 Then
                Chart_all.Series(2).Points(birthday_count_chart_all - 1300).Label = birthday_count_chart_all
                birthday_count_all = birthday_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) > 1 Then Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip = "In total," & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "persons at this institute were born in" & "  " & birthday_count_chart_all
                    If Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) = 1 Then Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip = "In total," & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "person at this institute was born in" & "  " & birthday_count_chart_all
                Case 0
                    If Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) > 1 Then Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip = "در مجموع،" & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "نفر در این آموزشگاه متولد سال" & "  " & birthday_count_chart_all & "  " & "هستند"
                    If Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) = 1 Then Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip = "در مجموع،" & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "نفر در این آموزشگاه متولد سال" & "  " & birthday_count_chart_all & "  " & "است"
            End Select
        Next


        birthday_count_all = birthday_count_all + 1
        birthday_count_chart_all = 1299
        For i = 1299 To 1439 Step 1
            birthday_count_chart_all = birthday_count_chart_all + 1

            Dim searchQuery_s As String = ("SELECT * From student WHERE CONCAT(birthday_s,language_s) like N'%" & birthday_count_chart_all & "%'")
            Dim command_s As New SqlCommand(searchQuery_s, connect_S)
            Dim da_s As SqlDataAdapter = New SqlDataAdapter(command_s)
            Dim DataTable_s As New DataTable
            da_s.Fill(DataTable_s)
            StudentDataGridView.DataSource = DataTable_s

            Dim searchQuery_t As String = ("SELECT * From teachers WHERE CONCAT(birthday_t,language_t) like N'%" & birthday_count_chart_all & "%'")
            Dim command_t As New SqlCommand(searchQuery_t, connect_T)
            Dim da_t As SqlDataAdapter = New SqlDataAdapter(command_t)
            Dim DataTable_t As New DataTable
            da_t.Fill(DataTable_t)
            TeachersDataGridView.DataSource = DataTable_t

            Chart_all.Series(2).Points(birthday_count_chart_all - 1300).YValues(0) = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count
            Dim s_t_rows_plus As Integer
            s_t_rows_plus = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count
            Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip = Chart_all.Series(2).Points(birthday_count_chart_all - 1300).ToolTip & vbNewLine & Math.Round(s_t_rows_plus * 100 / birthday_count_all) & "%"
        Next
    End Sub
    Sub chart_all_date_of_registration()
        Chart_all.Series("Chart_all_language").Enabled = False
        Chart_all.Series("Chart_all_gender").Enabled = False
        Chart_all.Series("Chart_all_birthday").Enabled = False
        Chart_all.Series("Chart_all_date_of_registration").Enabled = True

        date_of_registration_count_all = 0

        date_of_registration_count_chart_all = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_all = date_of_registration_count_chart_all + 1

            Dim searchQuery_s As String = ("SELECT * From student WHERE CONCAT(date_s,language_s) like N'%" & date_of_registration_count_chart_all & "%'")
            Dim command_s As New SqlCommand(searchQuery_s, connect_S)
            Dim da_s As SqlDataAdapter = New SqlDataAdapter(command_s)
            Dim DataTable_s As New DataTable
            da_s.Fill(DataTable_s)
            StudentDataGridView.DataSource = DataTable_s

            Dim searchQuery_t As String = ("SELECT * From teachers WHERE CONCAT(data_t,language_t) like N'%" & date_of_registration_count_chart_all & "%'")
            Dim command_t As New SqlCommand(searchQuery_t, connect_T)
            Dim da_t As SqlDataAdapter = New SqlDataAdapter(command_t)
            Dim DataTable_t As New DataTable
            da_t.Fill(DataTable_t)
            TeachersDataGridView.DataSource = DataTable_t


            Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count

            If Not Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = 0 Then
                Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).Label = date_of_registration_count_chart_all
                date_of_registration_count_all = date_of_registration_count_all + 1
            End If


            Select Case My.Settings.p_e_language
                Case 1
                    If Not Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = 0 Then Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip = "In total," & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "persons have been employed or registered at this institute in" & "  " & date_of_registration_count_chart_all
                    If Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = 1 Then Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip = "In total," & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "person has been employed or registered at this institute in" & "  " & date_of_registration_count_chart_all
                Case 0
                    If Not Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = 0 Then Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip = "در مجموع،" & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "نفر در سال" & "  " & date_of_registration_count_chart_all & "  " & "در این آموزشگاه ثبت نام یا استخدام شده اند"
                    If Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = 1 Then Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip = "در مجموع،" & "  " & StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count & "  " & "نفر در سال" & "  " & date_of_registration_count_chart_all & "  " & "در این آموزشگاه ثبت نام یا استخدام شده است"
            End Select
        Next



        date_of_registration_count_all = date_of_registration_count_all + 1
        date_of_registration_count_chart_all = 1349
        For i = 1349 To 1439 Step 1
            date_of_registration_count_chart_all = date_of_registration_count_chart_all + 1

            Dim searchQuery_s As String = ("SELECT * From student WHERE CONCAT(date_s,language_s) like N'%" & date_of_registration_count_chart_all & "%'")
            Dim command_s As New SqlCommand(searchQuery_s, connect_S)
            Dim da_s As SqlDataAdapter = New SqlDataAdapter(command_s)
            Dim DataTable_s As New DataTable
            da_s.Fill(DataTable_s)
            StudentDataGridView.DataSource = DataTable_s

            Dim searchQuery_t As String = ("SELECT * From teachers WHERE CONCAT(data_t,language_t) like N'%" & date_of_registration_count_chart_all & "%'")
            Dim command_t As New SqlCommand(searchQuery_t, connect_T)
            Dim da_t As SqlDataAdapter = New SqlDataAdapter(command_t)
            Dim DataTable_t As New DataTable
            da_t.Fill(DataTable_t)
            TeachersDataGridView.DataSource = DataTable_t


            Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).YValues(0) = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count
            Dim s_t_rows_plus As Integer
            s_t_rows_plus = StudentDataGridView.Rows.Count + TeachersDataGridView.Rows.Count
            Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip = Chart_all.Series(3).Points(date_of_registration_count_chart_all - 1350).ToolTip & vbNewLine & Math.Round(s_t_rows_plus * 100 / date_of_registration_count_all) & "%"
        Next
    End Sub

    Sub charts_type_Scroll()
        If Chart_students.Visible = True Then
            If TrackBar_charts_type.Value = 0 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid
            Part_charts_type_students = TrackBar_charts_type.Value
        End If

        If Chart_teachers.Visible = True Then
            If TrackBar_charts_type.Value = 0 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid
            Part_charts_type_teachers = TrackBar_charts_type.Value
        End If

        If Chart_all.Visible = True Then
            If TrackBar_charts_type.Value = 0 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid

            If TrackBar_charts_type.Value = 0 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            If TrackBar_charts_type.Value = 1 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            If TrackBar_charts_type.Value = 2 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
            If TrackBar_charts_type.Value = 3 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            If TrackBar_charts_type.Value = 4 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            If TrackBar_charts_type.Value = 5 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            If TrackBar_charts_type.Value = 6 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            If TrackBar_charts_type.Value = 7 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
            If TrackBar_charts_type.Value = 8 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            If TrackBar_charts_type.Value = 9 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            If TrackBar_charts_type.Value = 10 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar
            If TrackBar_charts_type.Value = 11 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
            If TrackBar_charts_type.Value = 12 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            If TrackBar_charts_type.Value = 13 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko
            If TrackBar_charts_type.Value = 14 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            If TrackBar_charts_type.Value = 15 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            If TrackBar_charts_type.Value = 16 Then Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid
            Part_charts_type_all = TrackBar_charts_type.Value
        End If
    End Sub
    Sub charts_color_Scroll()
        If Chart_students.Visible = True Then
            If TrackBar_charts_color.Value = 0 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent
            Part_charts_color_students = TrackBar_charts_color.Value
        End If
        If Chart_teachers.Visible = True Then
            If TrackBar_charts_color.Value = 0 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent
            Part_charts_color_teachers = TrackBar_charts_color.Value
        End If
        If Chart_all.Visible = True Then
            If TrackBar_charts_color.Value = 0 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            If TrackBar_charts_color.Value = 0 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Berry
            If TrackBar_charts_color.Value = 1 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Bright
            If TrackBar_charts_color.Value = 2 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            If TrackBar_charts_color.Value = 3 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
            If TrackBar_charts_color.Value = 4 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
            If TrackBar_charts_color.Value = 5 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Excel
            If TrackBar_charts_color.Value = 6 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Fire
            If TrackBar_charts_color.Value = 7 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Grayscale
            If TrackBar_charts_color.Value = 8 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Light
            If TrackBar_charts_color.Value = 9 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.Pastel
            If TrackBar_charts_color.Value = 10 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
            If TrackBar_charts_color.Value = 11 Then Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent
            Part_charts_color_all = TrackBar_charts_color.Value
        End If

    End Sub



    Sub about_us()
        PictureBox_home.Visible = False


        Label_title.Visible = False


        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)

        PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_





        PictureBox_Logo_a.Visible = True
        PictureBox_logo_b.Visible = True

        PictureBox_Logo.Visible = True

        PictureBox_programmer_name_B.Visible = True
        PictureBox_programmer_name_D.Visible = True

        Label_programmer_name_B.Visible = True
        Label_programmer_name_D.Visible = True

        PictureBox_programmer_phone_B.Visible = True
        PictureBox_programmer_phone_D.Visible = True

        Label_programmer_phone_B.Visible = True
        Label_programmer_phone_D.Visible = True

        PictureBox_programmer_gmail_B.Visible = True
        PictureBox_programmer_gmail_D.Visible = True

        Label_programmer_gmail_B.Visible = True
        Label_programmer_gmail_D.Visible = True

        PictureBox_back_to_home_from_about_us.Visible = True
    End Sub
    Sub b_f_about_us()
        PictureBox_Logo_a.Visible = False
        PictureBox_logo_b.Visible = False

        PictureBox_Logo.Visible = False

        PictureBox_programmer_name_B.Visible = False
        PictureBox_programmer_name_D.Visible = False

        Label_programmer_name_B.Visible = False
        Label_programmer_name_D.Visible = False

        PictureBox_programmer_phone_B.Visible = False
        PictureBox_programmer_phone_D.Visible = False

        Label_programmer_phone_B.Visible = False
        Label_programmer_phone_D.Visible = False

        PictureBox_programmer_gmail_B.Visible = False
        PictureBox_programmer_gmail_D.Visible = False

        Label_programmer_gmail_B.Visible = False
        Label_programmer_gmail_D.Visible = False

        PictureBox_back_to_home_from_about_us.Visible = False





        PictureBox_home.Visible = True

        Label_title.Visible = True

        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True

        PictureBox_setting.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        If Radio_persian.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If

        PictureBox_level_test.Visible = True
        PictureBox_charts_show.Visible = True
        PictureBox_Accounting.Visible = True
    End Sub




    Sub msg_box_type_attention()
        PictureBox_msg_box_left.BackgroundImage = Global.language_class.My.Resources.Resources.attention_left
        PictureBox_msg_box_right.BackgroundImage = Global.language_class.My.Resources.Resources.attention_right
    End Sub
    Sub msg_box_type_info()
        PictureBox_msg_box_left.BackgroundImage = Global.language_class.My.Resources.Resources.info_left
        PictureBox_msg_box_right.BackgroundImage = Global.language_class.My.Resources.Resources.info_right
    End Sub
    Sub msg_box_one_option()
        Panel_msg_box.Visible = True

        Label_msg_box_option_2.Visible = False

        If My.Settings.p_e_language = 1 Then
            Label_msg_box_title.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_detail.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_option_1.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_option_2.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Else
            Label_msg_box_title.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_detail.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_option_1.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_option_2.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        End If

        Label_msg_box_option_1.Location = New System.Drawing.Point(0, 150)
        Label_msg_box_option_1.Size = New System.Drawing.Size(500, 50)


        Button_students.Enabled = False
        Button_teachers.Enabled = False
        Button_delete_s.Enabled = False
        Button_edit_s.Enabled = False
        Button_add_s.Enabled = False
        Button_add_t.Enabled = False
        Button_edit_t.Enabled = False
        Button_delete_t.Enabled = False

        PictureBox_back_to_home_from_students_and_teachers_list.Enabled = False
        PictureBox_complete_registration_students.Enabled = False
        PictureBox_complete_registration_teachers.Enabled = False
        PictureBox_back_to_home_from_registration_students.Enabled = False
        PictureBox_back_to_home_from_registration_teachers.Enabled = False
        PictureBox_more_students.Enabled = False
        PictureBox_more_teachers.Enabled = False
        PictureBox_edit_students.Enabled = False
        PictureBox_edit_teachers.Enabled = False
        PictureBox_delete_students.Enabled = False
        PictureBox_delete_teachers.Enabled = False
        PictureBox_about_us.Enabled = False
        PictureBox_back_to_home_from_about_us.Enabled = False
        PictureBox_change_password_done.Enabled = False
        PictureBox_change_password_leave.Enabled = False
        PictureBox_password.Enabled = False
        PictureBox_change_passwors.Enabled = False
        PictureBox_setting.Enabled = False
        PictureBox_level_s.Enabled = False
        PictureBox_search.Enabled = False
        PictureBox_select_language_next_level.Enabled = False
        PictureBox_level_test.Enabled = False
        PictureBox_b_f_level_test.Enabled = False
        PictureBox_return_password.Enabled = False
        PictureBox_back_to_password.Enabled = False
        PictureBox_msg_box_left.Enabled = False
        PictureBox_msg_box_right.Enabled = False
        PictureBox_charts_show.Enabled = False
        PictureBox_charts_show_all.Enabled = False
        PictureBox_charts_show_teachers.Enabled = False
        PictureBox_charts_show_students.Enabled = False
        PictureBox_charts_show_back.Enabled = False
        PictureBox_charts_2d_3d.Enabled = False
        PictureBox_charts_change_type.Enabled = False
        PictureBox_charts_change_color.Enabled = False
        PictureBox_Part_charts_tips.Enabled = False
        PictureBox_Part_charts_restore_to_default.Enabled = False
        PictureBox_music.Enabled = False
        PictureBox_Accounting.Enabled = False

        Label_l_t_answer_1.Enabled = False
        Label_l_t_answer_2.Enabled = False
        Label_l_t_answer_3.Enabled = False
        Label_l_t_answer_4.Enabled = False
        Label_forgotten_password.Enabled = False
        Label_charts_choose_language.Enabled = False
        Label_charts_choose_gender.Enabled = False
        Label_charts_choose_birthday.Enabled = False
        Label_charts_choose_date_of_registration.Enabled = False

        GroupBox_setting.Enabled = False

        TrackBar_charts_type.Enabled = False
        TrackBar_charts_color.Enabled = False

        Panel_change_password.Enabled = False

        Radio_persian.Enabled = False
        Radio_english.Enabled = False
        RadioButton_male_s.Enabled = False
        RadioButton_female_s.Enabled = False
        RadioButton_male_t.Enabled = False
        RadioButton_female_t.Enabled = False

        CheckBox_en.Enabled = False
        CheckBox_tur.Enabled = False
        CheckBox_spa.Enabled = False
        CheckBox_ita.Enabled = False
        CheckBox_fre.Enabled = False
        CheckBox_arab.Enabled = False
        CheckBox_chi.Enabled = False
        CheckBox_japa.Enabled = False
        CheckBox_kor.Enabled = False

        TextBox_name_s.Enabled = False
        TextBox_name_father_s.Enabled = False
        TextBox_name_mother_s.Enabled = False
        TextBox_phone_s.Enabled = False
        TextBox_phone_father_s.Enabled = False
        TextBox_phone_mother_s.Enabled = False
        TextBox_telephone.Enabled = False
        TextBox_address.Enabled = False
        TextBox_codemeli_s.Enabled = False
        TextBox_datebirth_s_day.Enabled = False
        TextBox_datebirth_s_month.Enabled = False
        TextBox_datebirth_s_year.Enabled = False
        TextBox_datebirth_s_result.Enabled = False
        TextBox_date_s_day.Enabled = False
        TextBox_date_s_month.Enabled = False
        TextBox_date_s_year.Enabled = False
        TextBox_date_s_result.Enabled = False
        TextBox_gender_s.Enabled = False
        TextBox_level_s.Enabled = False
        TextBox_name_t.Enabled = False
        TextBox_lastname_t.Enabled = False
        TextBox_phone_t.Enabled = False
        TextBox_telephone_t.Enabled = False
        TextBox_address_t.Enabled = False
        TextBox_codemeli_t.Enabled = False
        TextBox_evidence.Enabled = False
        TextBox_datebirth_t_day.Enabled = False
        TextBox_datebirth_t_month.Enabled = False
        TextBox_datebirth_t_year.Enabled = False
        TextBox_datebirth_t_result.Enabled = False
        TextBox_date_t_day.Enabled = False
        TextBox_date_t_month.Enabled = False
        TextBox_date_t_year.Enabled = False
        TextBox_date_t_result.Enabled = False
        TextBox_gender_t.Enabled = False
        TextBox_password.Enabled = False
        TextBox_change_password_1.Enabled = False
        TextBox_change_password_2.Enabled = False
        TextBox_app_off.Enabled = False
        TextBox_search.Enabled = False
        Textbox_return_password.Enabled = False
        Textbox_return_password_p_1.Enabled = False
        Textbox_return_password_p_2.Enabled = False

        ComboBox_level_s.Enabled = False
        ComboBox_language_s_edit.Enabled = False
        ComboBox_language_t_edit.Enabled = False

    End Sub
    Sub msg_box_two_option()
        Panel_msg_box.Visible = True

        Label_msg_box_option_2.Visible = True

        If My.Settings.p_e_language = 1 Then
            Label_msg_box_title.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_detail.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_option_1.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_msg_box_option_2.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Else
            Label_msg_box_title.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_detail.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_option_1.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_msg_box_option_2.Font = New System.Drawing.Font("B nazanin", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        End If

        Label_msg_box_option_1.Location = New System.Drawing.Point(0, 150)
        Label_msg_box_option_1.Size = New System.Drawing.Size(250, 50)


        Button_students.Enabled = False
        Button_teachers.Enabled = False
        Button_delete_s.Enabled = False
        Button_edit_s.Enabled = False
        Button_add_s.Enabled = False
        Button_add_t.Enabled = False
        Button_edit_t.Enabled = False
        Button_delete_t.Enabled = False

        PictureBox_back_to_home_from_students_and_teachers_list.Enabled = False
        PictureBox_complete_registration_students.Enabled = False
        PictureBox_complete_registration_teachers.Enabled = False
        PictureBox_back_to_home_from_registration_students.Enabled = False
        PictureBox_back_to_home_from_registration_teachers.Enabled = False
        PictureBox_more_students.Enabled = False
        PictureBox_more_teachers.Enabled = False
        PictureBox_edit_students.Enabled = False
        PictureBox_edit_teachers.Enabled = False
        PictureBox_delete_students.Enabled = False
        PictureBox_delete_teachers.Enabled = False
        PictureBox_about_us.Enabled = False
        PictureBox_back_to_home_from_about_us.Enabled = False
        PictureBox_change_password_done.Enabled = False
        PictureBox_change_password_leave.Enabled = False
        PictureBox_password.Enabled = False
        PictureBox_change_passwors.Enabled = False
        PictureBox_setting.Enabled = False
        PictureBox_level_s.Enabled = False
        PictureBox_search.Enabled = False
        PictureBox_select_language_next_level.Enabled = False
        PictureBox_level_test.Enabled = False
        PictureBox_b_f_level_test.Enabled = False
        PictureBox_return_password.Enabled = False
        PictureBox_back_to_password.Enabled = False
        PictureBox_msg_box_left.Enabled = False
        PictureBox_msg_box_right.Enabled = False
        PictureBox_charts_show.Enabled = False
        PictureBox_charts_show_all.Enabled = False
        PictureBox_charts_show_teachers.Enabled = False
        PictureBox_charts_show_students.Enabled = False
        PictureBox_charts_show_back.Enabled = False
        PictureBox_charts_2d_3d.Enabled = False
        PictureBox_charts_change_type.Enabled = False
        PictureBox_charts_change_color.Enabled = False
        PictureBox_Part_charts_tips.Enabled = False
        PictureBox_Part_charts_restore_to_default.Enabled = False
        PictureBox_music.Enabled = False
        PictureBox_Accounting.Enabled = False

        Label_l_t_answer_1.Enabled = False
        Label_l_t_answer_2.Enabled = False
        Label_l_t_answer_3.Enabled = False
        Label_l_t_answer_4.Enabled = False
        Label_forgotten_password.Enabled = False
        Label_charts_choose_language.Enabled = False
        Label_charts_choose_gender.Enabled = False
        Label_charts_choose_birthday.Enabled = False
        Label_charts_choose_date_of_registration.Enabled = False

        GroupBox_setting.Enabled = False

        TrackBar_charts_type.Enabled = False
        TrackBar_charts_color.Enabled = False

        Panel_change_password.Enabled = False

        Radio_persian.Enabled = False
        Radio_english.Enabled = False
        RadioButton_male_s.Enabled = False
        RadioButton_female_s.Enabled = False
        RadioButton_male_t.Enabled = False
        RadioButton_female_t.Enabled = False

        CheckBox_en.Enabled = False
        CheckBox_tur.Enabled = False
        CheckBox_spa.Enabled = False
        CheckBox_ita.Enabled = False
        CheckBox_fre.Enabled = False
        CheckBox_arab.Enabled = False
        CheckBox_chi.Enabled = False
        CheckBox_japa.Enabled = False
        CheckBox_kor.Enabled = False

        TextBox_name_s.Enabled = False
        TextBox_name_father_s.Enabled = False
        TextBox_name_mother_s.Enabled = False
        TextBox_phone_s.Enabled = False
        TextBox_phone_father_s.Enabled = False
        TextBox_phone_mother_s.Enabled = False
        TextBox_telephone.Enabled = False
        TextBox_address.Enabled = False
        TextBox_codemeli_s.Enabled = False
        TextBox_datebirth_s_day.Enabled = False
        TextBox_datebirth_s_month.Enabled = False
        TextBox_datebirth_s_year.Enabled = False
        TextBox_datebirth_s_result.Enabled = False
        TextBox_date_s_day.Enabled = False
        TextBox_date_s_month.Enabled = False
        TextBox_date_s_year.Enabled = False
        TextBox_date_s_result.Enabled = False
        TextBox_gender_s.Enabled = False
        TextBox_level_s.Enabled = False
        TextBox_name_t.Enabled = False
        TextBox_lastname_t.Enabled = False
        TextBox_phone_t.Enabled = False
        TextBox_telephone_t.Enabled = False
        TextBox_address_t.Enabled = False
        TextBox_codemeli_t.Enabled = False
        TextBox_evidence.Enabled = False
        TextBox_datebirth_t_day.Enabled = False
        TextBox_datebirth_t_month.Enabled = False
        TextBox_datebirth_t_year.Enabled = False
        TextBox_datebirth_t_result.Enabled = False
        TextBox_date_t_day.Enabled = False
        TextBox_date_t_month.Enabled = False
        TextBox_date_t_year.Enabled = False
        TextBox_date_t_result.Enabled = False
        TextBox_gender_t.Enabled = False
        TextBox_password.Enabled = False
        TextBox_change_password_1.Enabled = False
        TextBox_change_password_2.Enabled = False
        TextBox_app_off.Enabled = False
        TextBox_search.Enabled = False
        Textbox_return_password.Enabled = False
        Textbox_return_password_p_1.Enabled = False
        Textbox_return_password_p_2.Enabled = False

        ComboBox_level_s.Enabled = False
        ComboBox_language_s_edit.Enabled = False
        ComboBox_language_t_edit.Enabled = False


    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'click
    Private Sub Button_add_s_Click(sender As Object, e As EventArgs)
        regitration_students()
    End Sub
    Private Sub Button_add_t_Click(sender As Object, e As EventArgs)
        registration_teachers()
    End Sub

    Private Sub PictureBox_more_students_Click(sender As Object, e As EventArgs)

        If Button_edit_s.Visible = False Then
            Button_edit_s.Visible = True
            Button_delete_s.Visible = True
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_students, "کمتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_students, "less")
            End If
        Else
            Button_edit_s.Visible = False
            Button_delete_s.Visible = False
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            End If
        End If

    End Sub
    Private Sub PictureBox_more_teachers_Click(sender As Object, e As EventArgs)

        If Button_edit_t.Visible = False Then
            Button_edit_t.Visible = True
            Button_delete_t.Visible = True
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "کمتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "less")
            End If
        Else
            Button_edit_t.Visible = False
            Button_delete_t.Visible = False
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
            End If
        End If

    End Sub

    Private Sub Button_delete_s_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()
        StudentDataGridView.Visible = True

        database_show_student()

        GridColor(StudentDataGridView)

        Label_students_teachers_count.Text = StudentDataGridView.RowCount

        gender_count_s()

        PictureBox_delete_students.Visible = True
        If Radio_persian.Checked = True Then
            MessageBox.Show("برای حذف ابتدا بر روی اطلاعات شخص مورد نظر کلیک کرده سپس بر روی علامت ضربدر کلیک کنید ***** توجه:ردیف اول به صورت پیش فرض انتخاب شده است", "حذف دانش آموزان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("To delete at first click on the person's information then click on the cross mark ***** Note: The first row is selected by default", "Remove students", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Button_delete_t_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()
        TeachersDataGridView.Visible = True

        database_show_teacher()

        GridColor(TeachersDataGridView)

        Label_students_teachers_count.Text = TeachersDataGridView.RowCount

        gender_count_t()

        PictureBox_delete_teachers.Visible = True
        If Radio_persian.Checked = True Then
            MessageBox.Show("برای حذف ابتدا بر روی اطلاعات شخص مورد نظر کلیک کرده سپس بر روی علامت ضربدر کلیک کنید ***** توجه:ردیف اول به صورت پیش فرض انتخاب شده است", "حذف معلم ها", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("To delete at first click on the person's information then click on the cross mark ***** Note: The first row is selected by default", "Remove teachers", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Button_edit_s_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()
        StudentDataGridView.Visible = True

        database_show_student()

        GridColor(StudentDataGridView)

        Label_students_teachers_count.Text = StudentDataGridView.RowCount

        gender_count_s()

        PictureBox_edit_students.Visible = True
        If Radio_persian.Checked = True Then
            MessageBox.Show("برای ویرایش ابتدا بر روی اطلاعات شخص مورد نظر کلیک کرده سپس بر روی علامت مداد کلیک کنید ***** توجه:ردیف اول به صورت پیش فرض انتخاب شده است", "ویرایش دانش آموزان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("To Edit at first click on the person's information then click on the Pencil mark ***** Note: The first row is selected by default", "Edit students", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub Button_edit_t_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()
        TeachersDataGridView.Visible = True

        database_show_teacher()

        GridColor(TeachersDataGridView)

        Label_students_teachers_count.Text = TeachersDataGridView.RowCount

        gender_count_t()

        PictureBox_edit_teachers.Visible = True
        If Radio_persian.Checked = True Then
            MessageBox.Show("برای ویرایش ابتدا بر روی اطلاعات شخص مورد نظر کلیک کرده سپس بر روی علامت مداد کلیک کنید ***** توجه:ردیف اول به صورت پیش فرض انتخاب شده است", "ویرایش  معلم ها", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("To Edit at first click on the person's information then click on the Pencil mark ***** Note: The first row is selected by default", "Edit teachers", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub PictureBox_edit_students_Click(sender As Object, e As EventArgs)
        Label_edit.Visible = True

        Label_name_s.Visible = True
        Label_name_father_s.Visible = True
        Label_name_mother_s.Visible = True
        Label_phone_s.Visible = True
        Label_phone_father_s.Visible = True
        Label_phone_mother_s.Visible = True
        Label_telephone.Visible = True
        Label_address.Visible = True
        Label_date.Visible = True
        Label_datebirth.Visible = True
        Label_codemeli_s.Visible = True
        Label_level_s.Visible = True
        Label_gender_s.Visible = True


        TextBox_name_s.Visible = True
        TextBox_name_father_s.Visible = True
        TextBox_name_mother_s.Visible = True
        TextBox_phone_s.Visible = True
        TextBox_phone_father_s.Visible = True
        TextBox_phone_mother_s.Visible = True
        TextBox_telephone.Visible = True
        TextBox_address.Visible = True
        TextBox_date_s_year.Visible = True
        TextBox_date_s_month.Visible = True
        TextBox_date_s_day.Visible = True
        TextBox_datebirth_s_year.Visible = True
        TextBox_datebirth_s_month.Visible = True
        TextBox_datebirth_s_day.Visible = True
        TextBox_codemeli_s.Visible = True


        RadioButton_female_s.Visible = True
        RadioButton_male_s.Visible = True

        Label_language_s_edit.Visible = True
        ComboBox_language_s_edit.Visible = True

        PictureBox_level_s.Visible = True
        PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.icon
        If Radio_english.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_level_s, "Listing method")
        Else
            ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت لیست")
        End If
        TextBox_level_s.Visible = True


        PictureBox_back_to_home_from_registration_students.Visible = True
        PictureBox_complete_registration_students.Visible = True

        TextBox_name_s.Text = String.Empty
        TextBox_name_father_s.Text = String.Empty
        TextBox_name_mother_s.Text = String.Empty
        TextBox_phone_s.Text = String.Empty
        TextBox_phone_father_s.Text = String.Empty
        TextBox_phone_mother_s.Text = String.Empty
        TextBox_telephone.Text = String.Empty
        TextBox_address.Text = String.Empty
        TextBox_codemeli_s.Text = String.Empty
        TextBox_date_s_year.Text = "سال"
        TextBox_date_s_month.Text = "ماه"
        TextBox_date_s_day.Text = "روز"
        TextBox_date_s_result.Text = String.Empty
        TextBox_datebirth_s_year.Text = "سال"
        TextBox_datebirth_s_month.Text = "ماه"
        TextBox_datebirth_s_day.Text = "روز"
        TextBox_datebirth_s_result.Text = String.Empty

        TextBox_level_s.Text = String.Empty
        Label_level_s_result.Text = String.Empty

        If Radio_english.Checked = True Then
            TextBox_datebirth_s_year.Text = "Y"
            TextBox_datebirth_s_month.Text = "M"
            TextBox_datebirth_s_day.Text = "D"
            TextBox_date_s_year.Text = "Y"
            TextBox_date_s_month.Text = "M"
            TextBox_date_s_day.Text = "D"
        End If




        If Radio_english.Checked = True Then
            ComboBox_language_s_edit.Items.Clear()
            ComboBox_language_s_edit.Items.Add("English")
            ComboBox_language_s_edit.Items.Add("Turkish")
            ComboBox_language_s_edit.Items.Add("Spanish")
            ComboBox_language_s_edit.Items.Add("Italian")
            ComboBox_language_s_edit.Items.Add("French")
            ComboBox_language_s_edit.Items.Add("Arabic")
            ComboBox_language_s_edit.Items.Add("Chinese")
            ComboBox_language_s_edit.Items.Add("Japanese")
            ComboBox_language_s_edit.Items.Add("Korean")
        Else
            ComboBox_language_s_edit.Items.Clear()
            ComboBox_language_s_edit.Items.Add("انگلیسی")
            ComboBox_language_s_edit.Items.Add("ترکی")
            ComboBox_language_s_edit.Items.Add("اسپانیایی")
            ComboBox_language_s_edit.Items.Add("ایتالیایی")
            ComboBox_language_s_edit.Items.Add("فرانسه ای")
            ComboBox_language_s_edit.Items.Add("عربی")
            ComboBox_language_s_edit.Items.Add("چینی")
            ComboBox_language_s_edit.Items.Add("ژاپنی")
            ComboBox_language_s_edit.Items.Add("کره ای")
        End If




        save_ID_number = StudentDataGridView.CurrentRow.Cells(0).Value
        TextBox_name_s.Text = StudentDataGridView.CurrentRow.Cells(1).Value.ToString
        TextBox_name_father_s.Text = StudentDataGridView.CurrentRow.Cells(2).Value.ToString
        TextBox_name_mother_s.Text = StudentDataGridView.CurrentRow.Cells(3).Value.ToString
        TextBox_phone_s.Text = StudentDataGridView.CurrentRow.Cells(4).Value.ToString
        TextBox_phone_father_s.Text = StudentDataGridView.CurrentRow.Cells(5).Value.ToString
        TextBox_phone_mother_s.Text = StudentDataGridView.CurrentRow.Cells(6).Value.ToString
        TextBox_telephone.Text = StudentDataGridView.CurrentRow.Cells(7).Value.ToString
        TextBox_address.Text = StudentDataGridView.CurrentRow.Cells(8).Value.ToString
        TextBox_codemeli_s.Text = StudentDataGridView.CurrentRow.Cells(9).Value.ToString
        TextBox_datebirth_s_result.Text = StudentDataGridView.CurrentRow.Cells(10).Value.ToString
        TextBox_date_s_result.Text = StudentDataGridView.CurrentRow.Cells(11).Value.ToString
        TextBox_gender_s.Text = StudentDataGridView.CurrentRow.Cells(12).Value.ToString
        Label_select_language_result.Text = StudentDataGridView.CurrentRow.Cells(13).Value.ToString
        ComboBox_language_s_edit.Text = StudentDataGridView.CurrentRow.Cells(13).Value.ToString
        Label_level_s_result.Text = StudentDataGridView.CurrentRow.Cells(14).Value.ToString
        TextBox_level_s.Text = StudentDataGridView.CurrentRow.Cells(14).Value.ToString




        Select Case TextBox_gender_s.Text
            Case "مرد"
                RadioButton_male_s.Checked = True
            Case "زن"
                RadioButton_female_s.Checked = True
            Case "Female"
                RadioButton_female_s.Checked = True
            Case "Male"
                RadioButton_male_s.Checked = True
        End Select



        StudentDataGridView.Visible = False
        PictureBox_back_to_home_from_students_and_teachers_list.Visible = False

        TextBox_search.Visible = False
        PictureBox_search.Visible = False
        PictureBox_search.Location = New System.Drawing.Point(485, 25)

        Label_students_teachers_count.Visible = False
        Label_boy_count.Visible = False
        Label_girl_count.Visible = False

        PictureBox_population_count.Visible = False
        PictureBox_boy_count.Visible = False
        PictureBox_girl_count.Visible = False

        PictureBox_edit_students.Visible = False


    End Sub
    Private Sub PictureBox_edit_teachers_Click(sender As Object, e As EventArgs)
        Label_edit.Visible = True


        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False


        Label_name_t.Visible = True
        Label_lastname_t.Visible = True
        Label_phone_t.Visible = True
        Label_telephone_t.Visible = True
        Label_address_t.Visible = True
        Label_datebirth_t.Visible = True
        Label_date_t.Visible = True
        Label_codemeli_t.Visible = True
        Label_evidence.Visible = True
        Label_gender_t.Visible = True


        TextBox_name_t.Visible = True
        TextBox_lastname_t.Visible = True
        TextBox_phone_t.Visible = True
        TextBox_telephone_t.Visible = True
        TextBox_address_t.Visible = True
        TextBox_datebirth_t_day.Visible = True
        TextBox_datebirth_t_month.Visible = True
        TextBox_datebirth_t_year.Visible = True
        TextBox_date_t_day.Visible = True
        TextBox_date_t_month.Visible = True
        TextBox_date_t_year.Visible = True
        TextBox_codemeli_t.Visible = True
        TextBox_evidence.Visible = True


        RadioButton_male_t.Visible = True
        RadioButton_female_t.Visible = True

        Label_language_t_edit.Visible = True
        ComboBox_language_t_edit.Visible = True


        PictureBox_back_to_home_from_registration_teachers.Visible = True
        PictureBox_complete_registration_teachers.Visible = True

        TextBox_name_t.Text = String.Empty
        TextBox_lastname_t.Text = String.Empty
        TextBox_phone_t.Text = String.Empty
        TextBox_telephone_t.Text = String.Empty
        TextBox_address_t.Text = String.Empty
        TextBox_datebirth_t_day.Text = "روز"
        TextBox_datebirth_t_month.Text = "ماه"
        TextBox_datebirth_t_year.Text = "سال"
        TextBox_datebirth_t_result.Text = String.Empty
        TextBox_date_t_day.Text = "روز"
        TextBox_date_t_month.Text = "ماه"
        TextBox_date_t_year.Text = "سال"
        TextBox_date_t_result.Text = String.Empty
        TextBox_codemeli_t.Text = String.Empty
        TextBox_evidence.Text = String.Empty

        If Radio_english.Checked = True Then
            TextBox_datebirth_t_year.Text = "Y"
            TextBox_datebirth_t_month.Text = "M"
            TextBox_datebirth_t_day.Text = "D"
            TextBox_date_t_year.Text = "Y"
            TextBox_date_t_month.Text = "M"
            TextBox_date_t_day.Text = "D"
        End If




        If Radio_english.Checked = True Then
            ComboBox_language_t_edit.Items.Clear()
            ComboBox_language_t_edit.Items.Add("English")
            ComboBox_language_t_edit.Items.Add("Turkish")
            ComboBox_language_t_edit.Items.Add("Spanish")
            ComboBox_language_t_edit.Items.Add("Italian")
            ComboBox_language_t_edit.Items.Add("French")
            ComboBox_language_t_edit.Items.Add("Arabic")
            ComboBox_language_t_edit.Items.Add("Chinese")
            ComboBox_language_t_edit.Items.Add("Japanese")
            ComboBox_language_t_edit.Items.Add("Korean")
        Else
            ComboBox_language_t_edit.Items.Clear()
            ComboBox_language_t_edit.Items.Add("انگلیسی")
            ComboBox_language_t_edit.Items.Add("ترکی")
            ComboBox_language_t_edit.Items.Add("اسپانیایی")
            ComboBox_language_t_edit.Items.Add("ایتالیایی")
            ComboBox_language_t_edit.Items.Add("فرانسه ای")
            ComboBox_language_t_edit.Items.Add("عربی")
            ComboBox_language_t_edit.Items.Add("چینی")
            ComboBox_language_t_edit.Items.Add("ژاپنی")
            ComboBox_language_t_edit.Items.Add("کره ای")
        End If




        save_ID_number = TeachersDataGridView.CurrentRow.Cells(0).Value
        TextBox_name_t.Text = TeachersDataGridView.CurrentRow.Cells(1).Value.ToString
        TextBox_lastname_t.Text = TeachersDataGridView.CurrentRow.Cells(2).Value.ToString
        TextBox_phone_t.Text = TeachersDataGridView.CurrentRow.Cells(3).Value.ToString
        TextBox_telephone_t.Text = TeachersDataGridView.CurrentRow.Cells(4).Value.ToString
        TextBox_address_t.Text = TeachersDataGridView.CurrentRow.Cells(5).Value.ToString
        TextBox_codemeli_t.Text = TeachersDataGridView.CurrentRow.Cells(6).Value.ToString
        TextBox_evidence.Text = TeachersDataGridView.CurrentRow.Cells(7).Value.ToString
        TextBox_datebirth_t_result.Text = TeachersDataGridView.CurrentRow.Cells(8).Value.ToString
        TextBox_date_t_result.Text = TeachersDataGridView.CurrentRow.Cells(9).Value.ToString
        TextBox_gender_t.Text = TeachersDataGridView.CurrentRow.Cells(10).Value.ToString
        Label_select_language_result.Text = TeachersDataGridView.CurrentRow.Cells(11).Value.ToString
        ComboBox_language_t_edit.Text = TeachersDataGridView.CurrentRow.Cells(11).Value.ToString




        Select Case TextBox_gender_t.Text
            Case "مرد"
                RadioButton_male_t.Checked = True
            Case "زن"
                RadioButton_female_t.Checked = True
            Case "Female"
                RadioButton_female_t.Checked = True
            Case "Male"
                RadioButton_male_t.Checked = True
        End Select




        TeachersDataGridView.Visible = False
        PictureBox_back_to_home_from_students_and_teachers_list.Visible = False

        TextBox_search.Visible = False
        PictureBox_search.Visible = False
        PictureBox_search.Location = New System.Drawing.Point(485, 25)


        PictureBox_population_count.Visible = False
        PictureBox_boy_count.Visible = False
        PictureBox_girl_count.Visible = False

        Label_students_teachers_count.Visible = False
        Label_boy_count.Visible = False
        Label_girl_count.Visible = False

        PictureBox_edit_teachers.Visible = False
    End Sub

    Private Sub Button_students_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()

        StudentDataGridView.Visible = True

        database_show_student()

        GridColor(StudentDataGridView)

        Label_students_teachers_count.Text = StudentDataGridView.RowCount

        gender_count_s()
    End Sub
    Private Sub Button_teachers_Click(sender As Object, e As EventArgs)
        show_student_teachers_list()
        TeachersDataGridView.Visible = True

        database_show_teacher()

        GridColor(TeachersDataGridView)

        Label_students_teachers_count.Text = TeachersDataGridView.RowCount

        gender_count_t()
    End Sub

    Private Sub PictureBox_setting_Click(sender As Object, e As EventArgs)
        If PictureBox_setting.Location = New System.Drawing.Point(5, 25) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.delete_cross__1_
        Else
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If


        If PictureBox_setting.Location = New System.Drawing.Point(5, 25) Then
            GroupBox_setting.Location = New System.Drawing.Point(-1, 0)
            PictureBox_setting.Location = New System.Drawing.Point(210, 25)
        Else
            GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
            PictureBox_setting.Location = New System.Drawing.Point(5, 25)
        End If



    End Sub

    Private Sub PictureBox_about_us_Click(sender As Object, e As EventArgs)
        about_us()
    End Sub
    Private Sub PictureBox_back_to_home_from_about_us_Click(sender As Object, e As EventArgs)
        b_f_about_us()
    End Sub

    Private Sub TextBox_datebirth_s_day_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_day.Text = "روز" Then
            TextBox_datebirth_s_day.Text = String.Empty
        End If
        If TextBox_datebirth_s_day.Text = "D" Then
            TextBox_datebirth_s_day.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_datebirth_s_month_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_month.Text = "ماه" Then
            TextBox_datebirth_s_month.Text = String.Empty
        End If
        If TextBox_datebirth_s_month.Text = "M" Then
            TextBox_datebirth_s_month.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_datebirth_s_year_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_year.Text = "سال" Then
            TextBox_datebirth_s_year.Text = String.Empty
        End If
        If TextBox_datebirth_s_year.Text = "Y" Then
            TextBox_datebirth_s_year.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox_date_s_day_Click(sender As Object, e As EventArgs)
        If TextBox_date_s_day.Text = "روز" Then
            TextBox_date_s_day.Text = String.Empty
        End If
        If TextBox_date_s_day.Text = "D" Then
            TextBox_date_s_day.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_date_s_month_Click(sender As Object, e As EventArgs)
        If TextBox_date_s_month.Text = "ماه" Then
            TextBox_date_s_month.Text = String.Empty
        End If
        If TextBox_date_s_month.Text = "M" Then
            TextBox_date_s_month.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_date_s_year_Click(sender As Object, e As EventArgs)
        If TextBox_date_s_year.Text = "سال" Then
            TextBox_date_s_year.Text = String.Empty
        End If
        If TextBox_date_s_year.Text = "Y" Then
            TextBox_date_s_year.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox_datebirth_t_day_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_day.Text = "روز" Then
            TextBox_datebirth_t_day.Text = String.Empty
        End If
        If TextBox_datebirth_t_day.Text = "D" Then
            TextBox_datebirth_t_day.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_datebirth_t_month_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_month.Text = "ماه" Then
            TextBox_datebirth_t_month.Text = String.Empty
        End If
        If TextBox_datebirth_t_month.Text = "M" Then
            TextBox_datebirth_t_month.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_datebirth_t_year_Click(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_year.Text = "سال" Then
            TextBox_datebirth_t_year.Text = String.Empty
        End If
        If TextBox_datebirth_t_year.Text = "Y" Then
            TextBox_datebirth_t_year.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox_date_t_day_Click(sender As Object, e As EventArgs)
        If TextBox_date_t_day.Text = "روز" Then
            TextBox_date_t_day.Text = String.Empty
        End If
        If TextBox_date_t_day.Text = "D" Then
            TextBox_date_t_day.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_date_t_month_Click(sender As Object, e As EventArgs)
        If TextBox_date_t_month.Text = "ماه" Then
            TextBox_date_t_month.Text = String.Empty
        End If
        If TextBox_date_t_month.Text = "M" Then
            TextBox_date_t_month.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_date_t_year_Click(sender As Object, e As EventArgs)
        If TextBox_date_t_year.Text = "سال" Then
            TextBox_date_t_year.Text = String.Empty
        End If
        If TextBox_date_t_year.Text = "Y" Then
            TextBox_date_t_year.Text = String.Empty
        End If
    End Sub

    Private Sub PictureBox_password_Click(sender As Object, e As EventArgs)

        If TextBox_password.Text = String.Empty And Radio_english.Checked = True Then
            TextBox_password.UseSystemPasswordChar = False
            TextBox_password.Text = "This field cannot be empty"
        End If
        If TextBox_password.Text = String.Empty And Radio_english.Checked = False Then
            TextBox_password.UseSystemPasswordChar = False
            TextBox_password.Text = "این فیلد نمیتواند خالی باشد"
        End If





        If TextBox_password.Text = My.Settings.change_password Or TextBox_password.Text = "danip" Then
            If Panel_change_password.Visible = True Then
                Label_Timer_lock_app.Visible = False
                My.Settings.Timer_lock_app = "0"

                Label_password.Visible = False
                TextBox_password.Visible = False
                PictureBox_password.Visible = False

                Label_change_password_1.Visible = True
                Label_change_password_2.Visible = True

                TextBox_change_password_1.Visible = True
                TextBox_change_password_2.Visible = True

                PictureBox_change_password_leave.Visible = True
                PictureBox_change_password_done.Visible = True

                TextBox_change_password_1.Focus()
            Else
                enter_app()
            End If
        End If



        Select Case TextBox_password.Text
            Case Is <> "This field cannot be empty"
                If Not Label_password.ForeColor = Color.Red Then
                    Label_password.ForeColor = Color.Blue
                End If
                If Radio_english.Checked = True Then
                    TextBox_password.UseSystemPasswordChar = False
                    Label_password.Text = "Wrong password"
                    TextBox_password.Text = "Please try again"
                    timers_lock()
                    Label_password.ForeColor = Color.Red
                    Label_forgotten_password.Visible = True
                End If
        End Select

        Select Case TextBox_password.Text
            Case Is <> "این فیلد نمیتواند خالی باشد"
                If Not Label_password.ForeColor = Color.Red Then
                    Label_password.ForeColor = Color.Blue
                End If
                If Radio_persian.Checked = True Then
                    TextBox_password.UseSystemPasswordChar = False
                    Label_password.Text = "رمز ورود اشتباه است"
                    TextBox_password.Text = "لطفا دوباره امتحان کنید"
                    timers_lock()
                    Label_password.ForeColor = Color.Red
                    Label_forgotten_password.Visible = True
                End If
        End Select






        If TextBox_password.Text = "This field cannot be empty" Then
            TextBox_password.Text = "This field cannot be empty"
        End If
        If TextBox_password.Text = "این فیلد نمیتواند خالی باشد" Then
            TextBox_password.Text = "این فیلد نمیتواند خالی باشد"
        End If



        If Label_title.Visible = True And Panel_change_password.Visible = False Then
            Label_forgotten_password.Visible = False
        End If
    End Sub
    Private Sub TextBox_password_Click(sender As Object, e As EventArgs)

        If TextBox_password.Text = "این فیلد نمیتواند خالی باشد" Then
            TextBox_password.Text = String.Empty
            TextBox_password.UseSystemPasswordChar = True
        End If
        If TextBox_password.Text = "This field cannot be empty" Then
            TextBox_password.Text = String.Empty
            TextBox_password.UseSystemPasswordChar = True
        End If



        If TextBox_password.Text = "Please try again" Then
            TextBox_password.Text = String.Empty
            TextBox_password.UseSystemPasswordChar = True
        End If
        If TextBox_password.Text = "لطفا دوباره امتحان کنید" Then
            TextBox_password.Text = String.Empty
            TextBox_password.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub PictureBox_change_passwors_Click(sender As Object, e As EventArgs)

        Panel_change_password.Visible = True
        Panel_change_password.Controls.Add(Label_Timer_lock_app)
        Panel_change_password.Controls.Add(Label_password)
        Panel_change_password.Controls.Add(TextBox_password)
        Panel_change_password.Controls.Add(PictureBox_password)
        Panel_change_password.Controls.Add(Label_forgotten_password)
        Panel_change_password.Controls.Add(Label_return_password)
        Panel_change_password.Controls.Add(Textbox_return_password)
        Panel_change_password.Controls.Add(PictureBox_return_password)
        Panel_change_password.Controls.Add(PictureBox_back_to_password)



        Button_students.Enabled = False
        Button_teachers.Enabled = False
        Button_add_s.Enabled = False
        Button_edit_s.Enabled = False
        Button_delete_s.Enabled = False
        Button_add_t.Enabled = False
        Button_edit_t.Enabled = False
        Button_delete_t.Enabled = False

        PictureBox_more_students.Enabled = False
        PictureBox_more_teachers.Enabled = False

        PictureBox_setting.Enabled = False
        PictureBox_about_us.Enabled = False
        PictureBox_change_passwors.Enabled = False

        PictureBox_music.Enabled = False

        Radio_persian.Enabled = False
        Radio_english.Enabled = False

        PictureBox_level_test.Enabled = False
        PictureBox_charts_show.Enabled = False
        PictureBox_Accounting.Enabled = False





        Label_Timer_lock_app.Location = New System.Drawing.Point(50, 60)
        Label_Timer_lock_app.Size = New System.Drawing.Size(300, 30)


        Label_password.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Label_password.Location = New System.Drawing.Point(50, 100)
        Label_password.Size = New System.Drawing.Size(300, 30)
        Label_password.ForeColor = Color.Black
        Label_password.Visible = True


        TextBox_password.Location = New System.Drawing.Point(75, 140)
        TextBox_password.Size = New System.Drawing.Size(250, 30)
        TextBox_password.Text = String.Empty
        TextBox_password.Visible = True


        PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.enter
        PictureBox_password.Location = New System.Drawing.Point(175.5, 205)
        PictureBox_password.Size = New System.Drawing.Size(50, 50)
        PictureBox_password.Visible = True


        Label_forgotten_password.Location = New System.Drawing.Point(100, 170)
        Label_forgotten_password.Size = New System.Drawing.Size(200, 25)
        Label_forgotten_password.Visible = False


        Label_return_password.Location = New System.Drawing.Point(50, 40)
        Label_return_password.Size = New System.Drawing.Size(300, 100)
        Label_return_password.ForeColor = Color.Black
        Label_return_password.Visible = False


        Textbox_return_password.Location = New System.Drawing.Point(75, 140)
        Textbox_return_password.Size = New System.Drawing.Size(250, 30)
        Textbox_return_password.Text = String.Empty
        Textbox_return_password.Visible = False


        PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next
        PictureBox_return_password.Location = New System.Drawing.Point(175.5, 180)
        PictureBox_return_password.Visible = False


        PictureBox_back_to_password.BackgroundImage = Global.language_class.My.Resources.Resources.back
        PictureBox_back_to_password.Location = New System.Drawing.Point(5, 5)
        PictureBox_back_to_password.Visible = False


        If Radio_english.Checked = True Then
            Label_password.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_password.Text = "Please enter the old password"
        Else
            Label_password.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Label_password.Text = "لطفا گذرواژه قدیمی را وارد کنید"
        End If


        PictureBox_change_password_leave.Visible = True

        TextBox_password.UseSystemPasswordChar = True

        TextBox_password.Focus()

    End Sub

    Private Sub PictureBox_change_password_done_Click(sender As Object, e As EventArgs)

        If TextBox_change_password_1.Text = TextBox_change_password_2.Text Then
            My.Settings.change_password = TextBox_change_password_2.Text
            If Radio_persian.Checked = True Then
                MessageBox.Show("تغییر گذرواژه با موفقیت انجام شد", "تغییر گذروازه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Password changed successfully", "Passwors changed", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

            Button_students.Enabled = True
            Button_teachers.Enabled = True
            Button_add_s.Enabled = True
            Button_edit_s.Enabled = True
            Button_delete_s.Enabled = True
            Button_add_t.Enabled = True
            Button_edit_t.Enabled = True
            Button_delete_t.Enabled = True

            PictureBox_more_students.Enabled = True
            PictureBox_more_teachers.Enabled = True

            PictureBox_setting.Enabled = True
            PictureBox_about_us.Enabled = True
            PictureBox_change_passwors.Enabled = True

            PictureBox_music.Enabled = True

            Radio_persian.Enabled = True
            Radio_english.Enabled = True

            PictureBox_level_test.Enabled = True
            PictureBox_charts_show.Enabled = True
            PictureBox_Accounting.Enabled = True




            Label_change_password_1.Visible = False
            Label_change_password_2.Visible = False
            Label_change_password_error.Visible = False

            TextBox_change_password_1.Visible = False
            TextBox_change_password_2.Visible = False

            PictureBox_change_password_leave.Visible = False
            PictureBox_change_password_done.Visible = False

            TextBox_password.Text = String.Empty

            TextBox_change_password_1.Text = String.Empty
            TextBox_change_password_2.Text = String.Empty

            Panel_change_password.Visible = False

        Else
            TextBox_change_password_1.Text = String.Empty
            TextBox_change_password_2.Text = String.Empty
            TextBox_change_password_1.Focus()
            Label_change_password_error.Visible = True
        End If

    End Sub
    Private Sub PictureBox_change_password_leave_Click(sender As Object, e As EventArgs)


        Button_students.Enabled = True
        Button_teachers.Enabled = True
        Button_add_s.Enabled = True
        Button_edit_s.Enabled = True
        Button_delete_s.Enabled = True
        Button_add_t.Enabled = True
        Button_edit_t.Enabled = True
        Button_delete_t.Enabled = True

        PictureBox_more_students.Enabled = True
        PictureBox_more_teachers.Enabled = True

        PictureBox_setting.Enabled = True
        PictureBox_about_us.Enabled = True
        PictureBox_change_passwors.Enabled = True

        PictureBox_music.Enabled = True

        Radio_persian.Enabled = True
        Radio_english.Enabled = True

        PictureBox_level_test.Enabled = True
        PictureBox_charts_show.Enabled = True
        PictureBox_Accounting.Enabled = True






        Label_change_password_1.Visible = False
        Label_change_password_2.Visible = False
        Label_change_password_error.Visible = False

        TextBox_change_password_1.Visible = False
        TextBox_change_password_2.Visible = False

        PictureBox_change_password_leave.Visible = False
        PictureBox_change_password_done.Visible = False

        TextBox_password.Text = String.Empty

        TextBox_change_password_1.Text = String.Empty
        TextBox_change_password_2.Text = String.Empty

        Panel_change_password.Visible = False

    End Sub

    Private Sub PictureBox_back_to_home_from_registration_students_Click(sender As Object, e As EventArgs)
        Dim warning As String

        If Label_edit.Visible = True Then
            If Radio_english.Checked = True Then
                warning = MessageBox.Show("Are you sure to cancel Edition?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                warning = MessageBox.Show("آیا از لغو کردن ویرایش مطمعن هستید؟", "لغو", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If
        Else
            If Radio_english.Checked = True Then
                warning = MessageBox.Show("Are you sure to cancel Registration?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                warning = MessageBox.Show("آیا از لغو کردن ثبت نام مطمعن هستید؟", "لغو", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If
        End If

        If warning = DialogResult.Yes Then
            back_to_home_from_regirtration_student()
        End If
    End Sub
    Private Sub PictureBox_back_to_home_from_registration_teachers_Click(sender As Object, e As EventArgs)
        Dim warning As String

        If Label_edit.Visible = True Then
            If Radio_english.Checked = True Then
                warning = MessageBox.Show("Are you sure to cancel Edition?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                warning = MessageBox.Show("آیا از لغو کردن ویرایش مطمعن هستید؟", "لغو", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If
        Else
            If Radio_english.Checked = True Then
                warning = MessageBox.Show("Are you sure to cancel Registration?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                warning = MessageBox.Show("آیا از لغو کردن ثبت نام مطمعن هستید؟", "لغو", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If
        End If

        If warning = DialogResult.Yes Then
            back_to_home_from_registration_teacher()
        End If
    End Sub

    Private Sub PictureBox_complete_registration_students_Click(sender As Object, e As EventArgs)
        Dim warning As String


        If Radio_english.Checked = True Then
            warning = MessageBox.Show("Are you sure about accuracy of the information?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            warning = MessageBox.Show("آیا از صحت اطلاعات مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If


        If warning = DialogResult.Yes Then
            If Label_edit.Visible = True Then
                complete_edit_s()
            Else
                complete_student_list()
            End If
        End If

    End Sub
    Private Sub PictureBox_complete_registration_teachers_Click(sender As Object, e As EventArgs)
        Dim warning As String


        If Radio_english.Checked = True Then
            warning = MessageBox.Show("Are you sure about accuracy of the information?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            warning = MessageBox.Show("آیا از صحت اطلاعات مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If


        If warning = DialogResult.Yes Then
            If Label_edit.Visible = True Then
                complete_edit_t()
            Else
                complete_teacher_list()
            End If
        End If
    End Sub

    Private Sub PictureBox_select_language_next_level_Click(sender As Object, e As EventArgs)

        If Label_select_language_result.Text = String.Empty Then
            If Radio_persian.Checked = True Then
                MessageBox.Show("لطفا یک زبان را انتخاب نمایید", "انتخاب زبان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Please select a language", "Select language", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Else
            If Label_select_language_s.Visible = True Then
                regitration_students_next_level()
            Else
                regitration_teachers_next_level()
            End If
        End If
    End Sub

    Private Sub PictureBox_back_to_home_from_students_and_teachers_list_Click(sender As Object, e As EventArgs)
        b_f_student_and_teacher_list()
    End Sub

    Private Sub PictureBox_delete_students_Click(sender As Object, e As EventArgs)
        Dim warning As String

        If Radio_english.Checked = True Then
            warning = MessageBox.Show("Are you sure to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            warning = MessageBox.Show("آیا از حذف این آیتم مطمعن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If

        If warning = DialogResult.Yes Then
            database_delete_s()
            GridColor(StudentDataGridView)
            Label_students_teachers_count.Text = StudentDataGridView.RowCount
            gender_count_s()
        End If

    End Sub
    Private Sub PictureBox_delete_teachers_Click(sender As Object, e As EventArgs)
        Dim warning As String

        If Radio_english.Checked = True Then
            warning = MessageBox.Show("Are you sure to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            warning = MessageBox.Show("آیا از حذف این آیتم مطمعن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If

        If warning = DialogResult.Yes Then
            database_delete_t()
            GridColor(TeachersDataGridView)
            Label_students_teachers_count.Text = TeachersDataGridView.RowCount
            gender_count_t()
        End If

    End Sub

    Private Sub PictureBox_search_Click(sender As Object, e As EventArgs)
        If TextBox_search.Visible = False Then
            TextBox_search.Visible = True
            PictureBox_search.Location = New System.Drawing.Point(485, 2)
        Else
            TextBox_search.Visible = False
            TextBox_search.Text = String.Empty
            If My.Settings.p_e_language = 1 Then
                TextBox_search.Text = "Search"
            Else
                TextBox_search.Text = "جستجو"
            End If
            PictureBox_search.Location = New System.Drawing.Point(485, 25)
        End If
    End Sub

    Private Sub PictureBox_level_s_Click(sender As Object, e As EventArgs)
        If ComboBox_level_s.Visible = True Then
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.icon
            If Radio_english.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_level_s, "Listing method")
            Else
                ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت لیست")
            End If
            TextBox_level_s.Visible = True
            ComboBox_level_s.Visible = False
        Else
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.writing
            If Radio_english.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_level_s, "Entering manually")
            Else
                ToolTip_main.SetToolTip(PictureBox_level_s, "وارد کردن به صورت دستی")
            End If
            TextBox_level_s.Visible = False
            ComboBox_level_s.Visible = True
        End If
    End Sub

    Private Sub PictureBox_level_test_Click(sender As Object, e As EventArgs)
        If Label_l_t_number.Text = 25 Then
            If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                Part_level_test_go_next_question = "next"
            End If
            If Part_level_test_go_next_question = "next" Then
                Label_l_t_number.Visible = False
                Label_l_t_question.Visible = False
                Label_l_t_answer_1.Visible = False
                Label_l_t_answer_2.Visible = False
                Label_l_t_answer_3.Visible = False
                Label_l_t_answer_4.Visible = False
                PictureBox_level_test.Visible = False

                Chart_l_t_resut.Visible = True
                Label_l_t_result_percent.Visible = True
                Label_l_t_result_score.Visible = True
                Label_l_t_result_explain.Visible = True
                Label_l_t_result_table_english.Visible = True
                Label_l_t_result_table_persian.Visible = True


                PictureBox_b_f_level_test.Location = New System.Drawing.Point(470, 435)
                PictureBox_b_f_level_test.Size = New System.Drawing.Size(30, 30)


                Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).YValues(0) = Part_level_test_count_correct_answer * 100 / 25
                Chart_l_t_resut.Series("Chart_l_t_resut").Points(1).YValues(0) = 100 - Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).YValues(0)
                Select Case My.Settings.p_e_language
                    Case 1
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).Label = "TRUE"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(1).Label = "FALSE"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).ToolTip = "You answered  " & Part_level_test_count_correct_answer * 100 / 25 & "%" & "  Of the questions correctly"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(1).ToolTip = "You answered  " & 100 - Part_level_test_count_correct_answer * 100 / 25 & "%" & "  Of the questions wrong"
                    Case 0
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).Label = "درست"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(1).Label = "غلط"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(0).ToolTip = "شما به  " & "%" & Part_level_test_count_correct_answer * 100 / 25 & "  از سوالات درست پاسخ داده اید"
                        Chart_l_t_resut.Series("Chart_l_t_resut").Points(1).ToolTip = "شما به  " & "%" & 100 - Part_level_test_count_correct_answer * 100 / 25 & "  از سوالات اشتباه پاسخ داده اید"
                End Select



                Select Case My.Settings.p_e_language
                    Case 1
                        Label_l_t_result_percent.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Label_l_t_result_percent.Text = "You answered" & vbNewLine & Part_level_test_count_correct_answer * 100 / 25 & "%" & vbNewLine & "Of the questions correctly"
                    Case 0
                        Label_l_t_result_percent.Font = New System.Drawing.Font("B NAZANIN", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                        Label_l_t_result_percent.Text = "شما به" & vbNewLine & Part_level_test_count_correct_answer * 100 / 25 & "%" & vbNewLine & "از سوالات درست پاسخ داده اید"
                End Select


                Select Case My.Settings.p_e_language
                    Case 1
                        Label_l_t_result_score.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Label_l_t_result_score.Text = "You answered" & vbNewLine & Part_level_test_count_correct_answer & " out of 25" & vbNewLine & "questions correctly"
                    Case 0
                        Label_l_t_result_score.Font = New System.Drawing.Font("B NAZANIN", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                        Label_l_t_result_score.Text = "شما به" & vbNewLine & Part_level_test_count_correct_answer & "سوال از 25 سوال " & vbNewLine & "درست پاسخ داده اید"
                End Select


                Select Case My.Settings.p_e_language
                    Case 1
                        Label_l_t_result_explain.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Label_l_t_result_explain.Text = "It should be noted that the results of this level test can be somewhat error-prone, as the correct test of the level of language learners need to test their other language skills including speaking, listening and writing." & vbNewLine & "Based on your test score, here is information about the Cambridge English exams that might be most appropriate for you."
                    Case 0
                        Label_l_t_result_explain.Font = New System.Drawing.Font("B NAZANIN", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                        Label_l_t_result_explain.Text = "لازم به ذکر است نتایج حاصل شده در این آزمون تعیین سطح می تواند تا حدودی دارای خطا باشد، چراکه آزمودن صحیح تعیین سطح زبان آموزان نیازمند بررسی سایر مهاریت های زبانی ایشان از جمله مکالمه ، شنیداری و نوشتاری است" & vbNewLine & "با مقایسه نمره خود و اطلاعات مندرج در جدول زیر که اطلاعاتی درباره آزمون تعیین سطح کمبریج ارائه نموده است می توانید سطح زبان خود را به صورت تقریبی تعیین نمایید"
                End Select


                Label_l_t_result_table_english.Text = "👉 Score 6 to 10: Beginner." & vbNewLine & "👉 Score 11 to 12: Can indicate beginner or intermediate levels." & vbNewLine & "👉 Score 13 to 15: Average." & vbNewLine & "👉 Score 16 to 17: May indicate intermediate or above average levels." & vbNewLine & "👉 Score 18 to 19: Above average. A person who reaches this level has the chance to live, work or study in English-speaking countries." & vbNewLine & "👉 Score 20 to 21: Can indicate above-average or advanced level." & vbNewLine & "👉 Score 22: Can indicate advanced or high-level." & vbNewLine & "👉 Points 23 to 25: high-level."
                Label_l_t_result_table_persian.Text = "👈🏻 امتیاز 6 تا 10:  مبتدی." & vbNewLine & "👈🏻 امتیاز 11 تا 12: می تواند نشان دهنده سطوح مبتدی یا متوسط باشد." & vbNewLine & "👈🏻 امتیاز 13 تا 15: متوسط." & vbNewLine & "👈🏻 امتیاز 16 تا 17: می تواند نشان دهنده سطوح متوسط یا فوق متوسط باشد." & vbNewLine & "👈🏻 امتیاز 18 تا 19: فوق متوسط. فردی که به این سطح می رسد این شانس را داراست تا در کشورهای انگلیسی زبان زندگی، کار و یا تحصیل کند." & vbNewLine & "👈🏻 امتیاز 20 تا 21: می تواند نشان دهنده سطوح فوق متوسط یا پیشرفته باشد." & vbNewLine & "👈🏻 امتیاز 22: می تواند نشان دهنده سطوح پیشرفته یا فوق پیشرفته باشد." & vbNewLine & "👈🏻 امتیاز 23 تا 25: فوق پیشرفته."
            End If
        End If





        Select Case Label_level_test_explain.Visible
            Case True
                Label_level_test_explain.Visible = False

                Label_l_t_number.Visible = True
                Label_l_t_question.Visible = True
                Label_l_t_answer_1.Visible = True
                Label_l_t_answer_2.Visible = True
                Label_l_t_answer_3.Visible = True
                Label_l_t_answer_4.Visible = True

                PictureBox_b_f_level_test.Location = New System.Drawing.Point(850, 415)
                PictureBox_level_test.Location = New System.Drawing.Point(910, 410)

                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources._next

                Part_level_test_count_correct_answer = 0

                Label_l_t_number.Text = 1
                level_test_q_a()
                Part_level_test_go_next_question = "no"
            Case False
                If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
                    Part_level_test_go_next_question = "next"
                End If
                If Part_level_test_go_next_question = "no" And Label_l_t_number.Text < 25 Then
                    If Radio_persian.Checked = True Then
                        MessageBox.Show("برای رفتن به سوال بعد حتما باید یک گزینه را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("You must select an option to move on to the next question", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    End If
                End If
                If Part_level_test_go_next_question = "no" And Label_l_t_number.Text = 25 Then
                    If Radio_persian.Checked = True Then
                        MessageBox.Show("برای مشاهده نتیجه حتما باید یک گزینه را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("You must select an option to see result", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    End If
                End If
                If Part_level_test_go_next_question = "next" Then
                    level_test_count_correct_a()
                    level_test_number_change()
                    level_test_q_a()
                    If Label_l_t_number.Text = "25" Then
                        PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.show_answer_1_
                    End If
                    Part_level_test_go_next_question = "no"
                End If
        End Select




        Select Case PictureBox_setting.Visible
            Case True
                ToolTip_main.SetToolTip(PictureBox_level_test, "")

                PictureBox_home.Visible = False

                Label_title.Visible = False

                Button_students.Visible = False
                Button_teachers.Visible = False
                Button_add_s.Visible = False
                Button_edit_s.Visible = False
                Button_delete_s.Visible = False
                Button_add_t.Visible = False
                Button_edit_t.Visible = False
                Button_delete_t.Visible = False

                PictureBox_setting.Visible = False

                PictureBox_more_students.Visible = False
                PictureBox_more_teachers.Visible = False

                If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
                    PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
                End If

                GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
                PictureBox_setting.Location = New System.Drawing.Point(5, 25)

                PictureBox_charts_show.Visible = False
                PictureBox_Accounting.Visible = False

                PictureBox_b_f_level_test.Visible = True

                PictureBox_level_test.Location = New System.Drawing.Point(475, 410)

                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.start_test_1_
                Label_level_test_explain.Visible = True

                Select Case My.Settings.p_e_language
                    Case 1
                        PictureBox_b_f_level_test.Location = New System.Drawing.Point(910, 420)
                        Label_level_test_explain.TextAlign = System.Drawing.ContentAlignment.TopRight
                        Label_level_test_explain.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Label_level_test_explain.Text = ".This English Level Test is a standard test designed by the University of Cambridge" & vbNewLine & ".This level test contains 25 multiple choice questions, all of which are General English" & vbNewLine & ".You will receive a score for each question and the total score is 25" & vbNewLine & ".Keep in mind that all questions must be answered to complete the test" & vbNewLine & "By doing this test, you will know the approximate level of your language. In total (according to the University of Cambridge) the points :earned can be interpreted as follows" & vbNewLine & ".Score 6 to 10: Beginner 👉" & vbNewLine & ".Score 11 to 12: Can indicate beginner or intermediate levels 👉🏻" & vbNewLine & ".Score 13 to 15: Average 👉🏻" & vbNewLine & ".Score 16 to 17: May indicate intermediate or above average levels 👉🏻" & vbNewLine & ".Score 18 to 19: Above average. A person who reaches this level has the chance to live, work or study in English-speaking countries 👉🏻" & vbNewLine & ".Score 20 to 21: Can indicate above-average or advanced level 👉🏻" & vbNewLine & ".Score 22: Can indicate advanced or high-level 👉" & vbNewLine & ".Points 23 to 25: high-level 👉🏻" & vbNewLine & ".No time limit has been specified for this test"
                    Case 0
                        PictureBox_b_f_level_test.Location = New System.Drawing.Point(30, 420)
                        Label_level_test_explain.TextAlign = System.Drawing.ContentAlignment.TopLeft
                        Label_level_test_explain.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                        Label_level_test_explain.Text = "آزمون تعیین سطح انگلیسی حاضر آزمون استانداردی است که توسط دانشگاه کمبریج طراحی شده است." & vbNewLine & " این آزمون تعیین سطح شامل 25 سوال چند گزینه ای است که همه آنها مربوط به انگلیسی عمومی می باشند." & vbNewLine & "با پاسخ دادن به هر سوال یک امتیاز دریافت خواهید کرد و مجموع امتیازات هم 25 است." & vbNewLine & " در نظر داشته باشید برای اتمام آزمون باید به تمامی سوالات پاسخ داده شود." & vbNewLine & "با انجام این آزمون تعیین سطح، از سطح تقریبی زبان خود آگاه خواهید شد. در مجموع (طبق دانشگاه کمبریج) امتیازات کسب شده را می توان به سطوح زیر تفسیر کرد:" & vbNewLine & "👈🏻 امتیاز 6 تا 10:  مبتدی." & vbNewLine & "👈🏻 امتیاز 11 تا 12: می تواند نشان دهنده سطوح مبتدی یا متوسط باشد." & vbNewLine & "👈🏻 امتیاز 13 تا 15: متوسط." & vbNewLine & "👈🏻 امتیاز 16 تا 17: می تواند نشان دهنده سطوح متوسط یا فوق متوسط باشد." & vbNewLine & "👈🏻 امتیاز 18 تا 19: فوق متوسط. فردی که به این سطح می رسد این شانس را داراست تا در کشورهای انگلیسی زبان زندگی، کار و یا تحصیل کند." & vbNewLine & "👈🏻 امتیاز 20 تا 21: می تواند نشان دهنده سطوح فوق متوسط یا پیشرفته باشد." & vbNewLine & "👈🏻 امتیاز 22: می تواند نشان دهنده سطوح پیشرفته یا فوق پیشرفته باشد." & vbNewLine & "👈🏻 امتیاز 23 تا 25: فوق پیشرفته." & vbNewLine & "هیچ محدودیت زمانی برای این آزمون مشخص نشده است."
                End Select
        End Select

    End Sub
    Private Sub PictureBox_b_f_level_test_Click(sender As Object, e As EventArgs)
        If My.Settings.p_e_language = 1 Then
            ToolTip_main.SetToolTip(PictureBox_level_test, "Level test")
        Else
            ToolTip_main.SetToolTip(PictureBox_level_test, "آزمون تعیین سطح")
        End If

        PictureBox_home.Visible = True

        Label_title.Visible = True

        Button_students.Visible = True
        Button_teachers.Visible = True
        Button_add_s.Visible = True
        Button_add_t.Visible = True

        PictureBox_setting.Visible = True

        PictureBox_more_students.Visible = True
        PictureBox_more_teachers.Visible = True
        PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        If Radio_persian.Checked = True Then
            ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
        Else
            ToolTip_main.SetToolTip(PictureBox_more_students, "more")
            ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
        End If

        PictureBox_level_test.Visible = True
        PictureBox_charts_show.Visible = True
        PictureBox_Accounting.Visible = True


        PictureBox_b_f_level_test.Visible = False
        Label_level_test_explain.Visible = False

        PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.level_test
        PictureBox_level_test.Location = New System.Drawing.Point(30, 410)
        PictureBox_b_f_level_test.Size = New System.Drawing.Size(40, 40)

        Label_l_t_number.Visible = False
        Label_l_t_question.Visible = False
        Label_l_t_answer_1.Visible = False
        Label_l_t_answer_2.Visible = False
        Label_l_t_answer_3.Visible = False
        Label_l_t_answer_4.Visible = False

        Label_l_t_number.Text = 0
        Part_level_test_count_correct_answer = 0

        Chart_l_t_resut.Visible = False
        Label_l_t_result_percent.Visible = False
        Label_l_t_result_score.Visible = False
        Label_l_t_result_explain.Visible = False
        Label_l_t_result_table_english.Visible = False
        Label_l_t_result_table_persian.Visible = False

        Part_level_test_go_next_question = "next"
    End Sub

    Private Sub Label_l_t_answer_1_Click(sender As Object, e As EventArgs)

        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_q_a()
            Label_l_t_answer_1.Text = "⚪️   " + Label_l_t_answer_1.Text
            Label_l_t_answer_1.ForeColor = Color.Black
        Else
            level_test_q_a()
            Label_l_t_answer_1.Text = "🛑   " + Label_l_t_answer_1.Text
            Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
        End If

    End Sub
    Private Sub Label_l_t_answer_2_Click(sender As Object, e As EventArgs)
        If Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_q_a()
            Label_l_t_answer_2.Text = "⚪️   " + Label_l_t_answer_2.Text
            Label_l_t_answer_2.ForeColor = Color.Black
        Else
            level_test_q_a()
            Label_l_t_answer_2.Text = "🛑   " + Label_l_t_answer_2.Text
            Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
        End If

    End Sub
    Private Sub Label_l_t_answer_3_Click(sender As Object, e As EventArgs)
        If Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_q_a()
            Label_l_t_answer_3.Text = "⚪️   " + Label_l_t_answer_3.Text
            Label_l_t_answer_3.ForeColor = Color.Black
        Else
            level_test_q_a()
            Label_l_t_answer_3.Text = "🛑   " + Label_l_t_answer_3.Text
            Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
        End If
    End Sub
    Private Sub Label_l_t_answer_4_Click(sender As Object, e As EventArgs)
        If Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_q_a()
            Label_l_t_answer_4.Text = "⚪️   " + Label_l_t_answer_4.Text
            Label_l_t_answer_4.ForeColor = Color.Black
        Else
            level_test_q_a()
            Label_l_t_answer_4.Text = "🛑   " + Label_l_t_answer_4.Text
            Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98)
        End If
    End Sub

    Private Sub PictureBox_music_Click(sender As Object, e As EventArgs)
        If My.Settings.music = 1 Then
            My.Settings.music = 0
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__2_
            MediaPlayer_music.Ctlcontrols.stop()
        Else
            My.Settings.music = 1
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__4_
            MediaPlayer_music.Ctlcontrols.play()
        End If
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'textchanged
    Private Sub TextBox_datebirth_s_day_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_day.TextLength = 2 Then TextBox_datebirth_s_month.Focus()
        If TextBox_datebirth_s_year.TextLength = 4 Then
            TextBox_datebirth_s_result.Text = TextBox_datebirth_s_year.Text + " / " + TextBox_datebirth_s_month.Text + " / " + TextBox_datebirth_s_day.Text
        End If
    End Sub
    Private Sub TextBox_datebirth_s_month_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_month.TextLength = 2 Then TextBox_datebirth_s_year.Focus()
        If TextBox_datebirth_s_year.TextLength = 4 Then
            TextBox_datebirth_s_result.Text = TextBox_datebirth_s_year.Text + " / " + TextBox_datebirth_s_month.Text + " / " + TextBox_datebirth_s_day.Text
        End If
    End Sub
    Private Sub TextBox_datebirth_s_year_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_s_year.TextLength = 4 Then
            TextBox_datebirth_s_result.Text = TextBox_datebirth_s_year.Text + " / " + TextBox_datebirth_s_month.Text + " / " + TextBox_datebirth_s_day.Text
        End If
    End Sub

    Private Sub TextBox_date_s_day_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_s_day.TextLength = 2 Then TextBox_date_s_month.Focus()
        If TextBox_date_s_year.TextLength = 4 Then
            TextBox_date_s_result.Text = TextBox_date_s_year.Text + " / " + TextBox_date_s_month.Text + " / " + TextBox_date_s_day.Text
        End If
    End Sub
    Private Sub TextBox_date_s_month_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_s_month.TextLength = 2 Then TextBox_date_s_year.Focus()
        If TextBox_date_s_year.TextLength = 4 Then
            TextBox_date_s_result.Text = TextBox_date_s_year.Text + " / " + TextBox_date_s_month.Text + " / " + TextBox_date_s_day.Text
        End If
    End Sub
    Private Sub TextBox_date_s_year_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_s_year.TextLength = 4 Then
            TextBox_date_s_result.Text = TextBox_date_s_year.Text + " / " + TextBox_date_s_month.Text + " / " + TextBox_date_s_day.Text
        End If
    End Sub

    Private Sub TextBox_datebirth_t_day_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_day.TextLength = 2 Then TextBox_datebirth_t_month.Focus()
        If TextBox_datebirth_t_year.TextLength = 4 Then
            TextBox_datebirth_t_result.Text = TextBox_datebirth_t_year.Text + " / " + TextBox_datebirth_t_month.Text + " / " + TextBox_datebirth_t_day.Text
        End If
    End Sub
    Private Sub TextBox_datebirth_t_month_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_month.TextLength = 2 Then TextBox_datebirth_t_year.Focus()
        If TextBox_datebirth_t_year.TextLength = 4 Then
            TextBox_datebirth_t_result.Text = TextBox_datebirth_t_year.Text + " / " + TextBox_datebirth_t_month.Text + " / " + TextBox_datebirth_t_day.Text
        End If
    End Sub
    Private Sub TextBox_datebirth_t_year_TextChanged(sender As Object, e As EventArgs)
        If TextBox_datebirth_t_year.TextLength = 4 Then
            TextBox_datebirth_t_result.Text = TextBox_datebirth_t_year.Text + " / " + TextBox_datebirth_t_month.Text + " / " + TextBox_datebirth_t_day.Text
        End If
    End Sub

    Private Sub TextBox_date_t_day_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_t_day.TextLength = 2 Then TextBox_date_t_month.Focus()
        If TextBox_date_t_year.TextLength = 4 Then
            TextBox_date_t_result.Text = TextBox_date_t_year.Text + " / " + TextBox_date_t_month.Text + " / " + TextBox_date_t_day.Text
        End If
    End Sub
    Private Sub TextBox_date_t_month_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_t_month.TextLength = 2 Then TextBox_date_t_year.Focus()
        If TextBox_date_t_year.TextLength = 4 Then
            TextBox_date_t_result.Text = TextBox_date_t_year.Text + " / " + TextBox_date_t_month.Text + " / " + TextBox_date_t_day.Text
        End If
    End Sub
    Private Sub TextBox_date_t_year_TextChanged(sender As Object, e As EventArgs)
        If TextBox_date_t_year.TextLength = 4 Then
            TextBox_date_t_result.Text = TextBox_date_t_year.Text + " / " + TextBox_date_t_month.Text + " / " + TextBox_date_t_day.Text
        End If
    End Sub

    Private Sub TextBox_level_s_TextChanged(sender As Object, e As EventArgs)
        Label_level_s_result.Text = TextBox_level_s.Text
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    '
    'checkchanged
    Private Sub Radio_persian_CheckedChanged(sender As Object, e As EventArgs)

        If Radio_persian.Checked = True Then
            My.Settings.p_e_language = "0"
            persian_language()
            If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
                MessageBox.Show("تغییر زبان با موفقیت انجام شد", "زبان", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Radio_english_CheckedChanged(sender As Object, e As EventArgs)

        If Radio_english.Checked = True Then
            My.Settings.p_e_language = "1"
            English_language()
            If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
                MessageBox.Show("Language Changed successfful", "Language", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub RadioButton_male_s_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton_male_s.Checked = True Then
            TextBox_gender_s.Text = String.Empty
            TextBox_gender_s.Text = RadioButton_male_s.Text
        End If
    End Sub
    Private Sub RadioButton_female_s_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton_female_s.Checked = True Then
            TextBox_gender_s.Text = String.Empty
            TextBox_gender_s.Text = RadioButton_female_s.Text
        End If
    End Sub

    Private Sub RadioButton_male_t_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton_male_t.Checked = True Then
            TextBox_gender_t.Text = String.Empty
            TextBox_gender_t.Text = RadioButton_male_t.Text
        End If
    End Sub
    Private Sub RadioButton_female_t_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton_female_t.Checked = True Then
            TextBox_gender_t.Text = String.Empty
            TextBox_gender_t.Text = RadioButton_female_t.Text
        End If
    End Sub

    Private Sub CheckBox_en_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_en.Checked = True Then

            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_en.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If

    End Sub
    Private Sub CheckBox_tur_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_tur.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_tur.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    Private Sub CheckBox_spa_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_spa.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_spa.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If

    End Sub
    Private Sub CheckBox_ita_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_ita.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_ita.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    Private Sub CheckBox_fre_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_fre.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_fre.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If

    End Sub
    Private Sub CheckBox_arab_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_arab.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_arab.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    Private Sub CheckBox_chi_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_chi.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_japa.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_chi.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    Private Sub CheckBox_japa_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_japa.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_kor.Checked = False

            Label_select_language_result.Text = CheckBox_japa.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    Private Sub CheckBox_kor_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox_kor.Checked = True Then

            CheckBox_en.Checked = False
            CheckBox_tur.Checked = False
            CheckBox_spa.Checked = False
            CheckBox_ita.Checked = False
            CheckBox_fre.Checked = False
            CheckBox_arab.Checked = False
            CheckBox_chi.Checked = False
            CheckBox_japa.Checked = False

            Label_select_language_result.Text = CheckBox_kor.Text
        Else
            Label_select_language_result.Text = String.Empty
        End If
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    '
    ''''Selected Changed
    Private Sub ComboBox_level_s_SelectedIndexChanged(sender As Object, e As EventArgs)
        Label_level_s_result.Text = ComboBox_level_s.Text
    End Sub
    Private Sub ComboBox_language_s_edit_SelectedIndexChanged(sender As Object, e As EventArgs)
        Label_select_language_result.Text = ComboBox_language_s_edit.Text
    End Sub
    Private Sub ComboBox_language_t_edit_SelectedIndexChanged(sender As Object, e As EventArgs)
        Label_select_language_result.Text = ComboBox_language_t_edit.Text
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    '
    'mouse Enter & Leave
    Private Sub PictureBox_password_MouseEnter(sender As Object, e As EventArgs)
        If Panel_change_password.Visible = True Then
            PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.enter__1_
        Else
            PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.lock__1_
        End If
    End Sub
    Private Sub PictureBox_password_MouseLeave(sender As Object, e As EventArgs)
        If Panel_change_password.Visible = True Then
            PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.enter
        Else
            PictureBox_password.BackgroundImage = Global.language_class.My.Resources.Resources.lock
        End If
    End Sub

    Private Sub PictureBox_change_passwors_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_change_passwors.BackgroundImage = Global.language_class.My.Resources.Resources.pin_code__1_
    End Sub
    Private Sub PictureBox_change_passwors_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_change_passwors.BackgroundImage = Global.language_class.My.Resources.Resources.pin_code
    End Sub

    Private Sub PictureBox_setting_MouseEnter(sender As Object, e As EventArgs)
        If PictureBox_setting.Location = New System.Drawing.Point(5, 25) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__2_
        Else
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.delete_cross__2_
        End If
    End Sub
    Private Sub PictureBox_setting_MouseLeave(sender As Object, e As EventArgs)
        If PictureBox_setting.Location = New System.Drawing.Point(5, 25) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        Else
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.delete_cross__1_
        End If
    End Sub

    Private Sub PictureBox_about_us_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.about_us__1_
    End Sub
    Private Sub PictureBox_about_us_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.about_us
    End Sub

    Private Sub PictureBox_back_to_home_from_about_us_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette__1_
    End Sub
    Private Sub PictureBox_back_to_home_from_about_us_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_about_us.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette
    End Sub

    Private Sub PictureBox_more_students_MouseEnter(sender As Object, e As EventArgs)
        If Button_edit_s.Visible = True Then
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis__1_
        Else
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more__1_
        End If

    End Sub
    Private Sub PictureBox_more_students_MouseLeave(sender As Object, e As EventArgs)
        If Button_edit_s.Visible = True Then
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis
        Else
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
        End If
    End Sub

    Private Sub PictureBox_more_teachers_MouseEnter(sender As Object, e As EventArgs)
        If Button_edit_t.Visible = True Then
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis__1_
        Else
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more__1_
        End If
    End Sub
    Private Sub PictureBox_more_teachers_MouseLeave(sender As Object, e As EventArgs)
        If Button_edit_t.Visible = True Then
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.ellipsis
        Else
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
        End If
    End Sub

    Private Sub PictureBox_back_to_home_from_registration_students_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.cancel__1_
    End Sub
    Private Sub PictureBox_back_to_home_from_registration_students_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.cancel
    End Sub

    Private Sub PictureBox_back_to_home_from_registration_teachers_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.cancel__1_
    End Sub
    Private Sub PictureBox_back_to_home_from_registration_teachers_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.cancel
    End Sub

    Private Sub PictureBox_complete_registration_students_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_complete_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.checked__2_
    End Sub
    Private Sub PictureBox_complete_registration_students_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_complete_registration_students.BackgroundImage = Global.language_class.My.Resources.Resources.checked
    End Sub

    Private Sub PictureBox_complete_registration_teachers_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_complete_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.checked__2_
    End Sub
    Private Sub PictureBox_complete_registration_teachers_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_complete_registration_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.checked
    End Sub

    Private Sub PictureBox_back_to_home_from_students_and_teachers_list_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImage = Global.language_class.My.Resources.Resources.back
    End Sub
    Private Sub PictureBox_back_to_home_from_students_and_teachers_list_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
    End Sub

    Private Sub PictureBox_b_f_teacher_list_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImage = Global.language_class.My.Resources.Resources.back
    End Sub
    Private Sub PictureBox_b_f_teacher_list_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_home_from_students_and_teachers_list.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
    End Sub

    Private Sub PictureBox_delete_students_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_delete_students.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button__1_
    End Sub
    Private Sub PictureBox_delete_students_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_delete_students.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
    End Sub

    Private Sub PictureBox_delete_teachers_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_delete_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button__1_
    End Sub
    Private Sub PictureBox_delete_teachers_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_delete_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
    End Sub

    Private Sub PictureBox_change_password_leave_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_change_password_leave.BackgroundImage = Global.language_class.My.Resources.Resources.close__1_
    End Sub
    Private Sub PictureBox_change_password_leave_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_change_password_leave.BackgroundImage = Global.language_class.My.Resources.Resources.close
    End Sub

    Private Sub PictureBox_change_password_done_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_change_password_done.BackgroundImage = Global.language_class.My.Resources.Resources.check_mark__1_
    End Sub
    Private Sub PictureBox_change_password_done_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_change_password_done.BackgroundImage = Global.language_class.My.Resources.Resources.check_mark
    End Sub

    Private Sub PictureBox_search_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_search.BackgroundImage = Global.language_class.My.Resources.Resources.job_seeker__1_
    End Sub
    Private Sub PictureBox_search_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_search.BackgroundImage = Global.language_class.My.Resources.Resources.job_seeker
    End Sub

    Private Sub PictureBox_edit_students_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_edit_students.BackgroundImage = Global.language_class.My.Resources.Resources.edit__1_
    End Sub
    Private Sub PictureBox_edit_students_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_edit_students.BackgroundImage = Global.language_class.My.Resources.Resources.edit
    End Sub

    Private Sub PictureBox_edit_teachers_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_edit_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.edit__1_
    End Sub
    Private Sub PictureBox_edit_teachers_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_edit_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.edit
    End Sub

    Private Sub PictureBox_level_s_MouseEnter(sender As Object, e As EventArgs)
        If TextBox_level_s.Visible = True Then
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.icon__1_
        Else
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.writing__1_
        End If
    End Sub
    Private Sub PictureBox_level_s_MouseLeave(sender As Object, e As EventArgs)
        If TextBox_level_s.Visible = True Then
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.icon
        Else
            PictureBox_level_s.BackgroundImage = Global.language_class.My.Resources.Resources.writing
        End If
    End Sub

    Private Sub PictureBox_select_language_next_level_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_select_language_next_level.BackgroundImage = Global.language_class.My.Resources.Resources.next__1_
    End Sub
    Private Sub PictureBox_select_language_next_level_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_select_language_next_level.BackgroundImage = Global.language_class.My.Resources.Resources._next
    End Sub

    Private Sub PictureBox_level_test_MouseEnter(sender As Object, e As EventArgs)
        If Label_l_t_number.Text = 0 Or 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Or 10 Or 11 Or 12 Or 13 Or 14 Or 15 Or 16 Or 17 Or 18 Or 19 Or 20 Or 21 Or 22 Or 23 Or 24 Then
            If PictureBox_setting.Visible = False And Label_level_test_explain.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.start_test_2_
            End If
            If PictureBox_setting.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.level_test_1_
            End If
            If Label_l_t_question.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.next__1_
            End If
        End If
        If Label_l_t_number.Text = 25 Then
            PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.show_answer_2_
        End If
    End Sub
    Private Sub PictureBox_level_test_MouseLeave(sender As Object, e As EventArgs)
        If Label_l_t_number.Text = 0 Or 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Or 10 Or 11 Or 12 Or 13 Or 14 Or 15 Or 16 Or 17 Or 18 Or 19 Or 20 Or 21 Or 22 Or 23 Or 24 Then
            If PictureBox_setting.Visible = False And Label_level_test_explain.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.start_test_1_
            End If
            If PictureBox_setting.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.level_test
            End If
            If Label_l_t_question.Visible = True Then
                PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources._next
            End If
        End If
        If Label_l_t_number.Text = 25 Then
            PictureBox_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.show_answer_1_
        End If
    End Sub

    Private Sub PictureBox_b_f_level_test_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_b_f_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette__1_
    End Sub
    Private Sub PictureBox_b_f_level_test_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_b_f_level_test.BackgroundImage = Global.language_class.My.Resources.Resources.home_icon_silhouette
    End Sub

    Private Sub Label_l_t_answer_1_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Label_l_t_answer_1.Text = "⚪️   " + Label_l_t_answer_1.Text
        End If
    End Sub
    Private Sub Label_l_t_answer_1_MouseLeave(sender As Object, e As EventArgs)
        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_choose_answer()
        Else
            level_test_q_a()
        End If
    End Sub

    Private Sub Label_l_t_answer_2_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Label_l_t_answer_2.Text = "⚪️   " + Label_l_t_answer_2.Text
        End If
    End Sub
    Private Sub Label_l_t_answer_2_MouseLeave(sender As Object, e As EventArgs)
        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_choose_answer()
        Else
            level_test_q_a()
        End If
    End Sub

    Private Sub Label_l_t_answer_3_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Label_l_t_answer_3.Text = "⚪️   " + Label_l_t_answer_3.Text
        End If
    End Sub
    Private Sub Label_l_t_answer_3_MouseLeave(sender As Object, e As EventArgs)
        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_choose_answer()
        Else
            level_test_q_a()
        End If
    End Sub

    Private Sub Label_l_t_answer_4_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            Label_l_t_answer_4.Text = "⚪️   " + Label_l_t_answer_4.Text
        End If
    End Sub
    Private Sub Label_l_t_answer_4_MouseLeave(sender As Object, e As EventArgs)
        If Label_l_t_answer_1.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_2.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_3.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Or Label_l_t_answer_4.ForeColor = System.Drawing.Color.FromArgb(214, 0, 98) Then
            level_test_choose_answer()
        Else
            level_test_q_a()
        End If
    End Sub

    Private Sub PictureBox_charts_show_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_show.BackgroundImage = Global.language_class.My.Resources.Resources.graph__1_
    End Sub
    Private Sub PictureBox_charts_show_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_show.BackgroundImage = Global.language_class.My.Resources.Resources.graph
    End Sub

    Private Sub PictureBox_charts_show_back_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_show_back.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
    End Sub
    Private Sub PictureBox_charts_show_back_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_show_back.BackgroundImage = Global.language_class.My.Resources.Resources.back
    End Sub

    Private Sub PictureBox_charts_show_all_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart__2_
    End Sub
    Private Sub PictureBox_charts_show_all_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart
    End Sub

    Private Sub PictureBox_charts_show_teachers_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart__1_
    End Sub
    Private Sub PictureBox_charts_show_teachers_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart
    End Sub

    Private Sub PictureBox_charts_show_students_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart__3_
    End Sub
    Private Sub PictureBox_charts_show_students_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_show_choose_item.BackgroundImage = Global.language_class.My.Resources.Resources.line_chart
    End Sub

    Private Sub PictureBox_music_MouseEnter(sender As Object, e As EventArgs)
        If My.Settings.music = 1 Then
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__4_
        Else
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__2_
        End If

    End Sub
    Private Sub PictureBox_music_MouseLeave(sender As Object, e As EventArgs)
        If My.Settings.music = 1 Then
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__3_
        Else
            PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__1_
        End If
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'form
    Private Sub Hammon_FormClosing(sender As Object, e As FormClosingEventArgs)
        Dim warning_close As String

        If Radio_english.Checked = True Then
            warning_close = MessageBox.Show("Do you want to exit the app?", "closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            warning_close = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "بستن", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If

        If warning_close = DialogResult.Yes Then
        Else
            e.Cancel = True
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        control_add()
        add_handler()

        load_app()

        Cursor_change()

        Part_charts_color_students = 2
        Part_charts_color_teachers = 2
        Part_charts_color_all = 2
        Part_charts_type_students = 9
        Part_charts_type_teachers = 9
        Part_charts_type_all = 9
        TrackBar_charts_color.Value = 2
        TrackBar_charts_type.Value = 9

        Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel

        Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut



        Me.ClientSize = New System.Drawing.Size(984, 481)

        Select Case My.Settings.music
            Case 1
                MediaPlayer_music.Ctlcontrols.play()
                PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__3_
            Case 0
                MediaPlayer_music.Ctlcontrols.stop()
                PictureBox_music.BackgroundImage = Global.language_class.My.Resources.Resources.switch__1_
        End Select

        Select Case My.Settings.p_e_language
            Case 1
                Radio_english.Checked = True
            Case 0
                Radio_persian.Checked = True
        End Select

        TextBox_password.Focus()

        database_show_student()
        database_show_teacher()

        If My.Settings.timer_lock_app = "11" Then
            app_off()
        End If
        If My.Settings.timer_lock_app < "5" Then
            My.Settings.timer_lock_app = "0"
        End If

        Label_l_t_number.Text = 0
        Accounting_edit = 0
        Accounting_choose_item = 0
    End Sub

    Private Sub registration_form_Click(sender As Object, e As EventArgs)
        PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)
    End Sub
    Private Sub PictureBox_home_Click(sender As Object, e As EventArgs)
        PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)
    End Sub
    Private Sub Label_title_Click(sender As Object, e As EventArgs)
        PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'search 
    Private Sub TextBox_search_Click(sender As Object, e As EventArgs)
        If TextBox_search.Text = "Search" Then
            TextBox_search.Text = String.Empty
        End If
        If TextBox_search.Text = "جستجو" Then
            TextBox_search.Text = String.Empty
        End If
    End Sub
    Private Sub TextBox_search_LostFocus(sender As Object, e As EventArgs)
        If TextBox_search.Text = String.Empty Then
            If Radio_english.Checked = True Then
                TextBox_search.Text = "Search"
            Else
                TextBox_search.Text = "جستجو"
            End If

            If StudentDataGridView.Visible = True Then
                GridColor(StudentDataGridView)
            Else
                GridColor(TeachersDataGridView)
            End If
        End If
    End Sub
    Private Sub TextBox_search_TextChanged(sender As Object, e As EventArgs)
        get_p_data = PersianCalendar.GetMonth(Now()).ToString

        If TextBox_search.Text = "Search" Or TextBox_search.Text = "جستجو" Then
        Else
            If StudentDataGridView.Visible = True Then
                database_search_s()
                GridColor(StudentDataGridView)
            End If
            If TeachersDataGridView.Visible = True Then
                database_search_t()
                GridColor(TeachersDataGridView)
            End If

            If Accounting_choose_item = 1 Then
                Select Case get_p_data
                    Case 1
                        database_search_m_i_farvardin()
                        GridColor(mony_incoming_farvardin_DataGridView)
                    Case 2
                        database_search_m_i_ordibehesht()
                        GridColor(mony_incoming_ordibehesht_DataGridView)
                    Case 3
                        database_search_m_i_khordad()
                        GridColor(mony_incoming_khordad_DataGridView)
                    Case 4
                        database_search_m_i_tir()
                        GridColor(mony_incoming_tir_DataGridView)
                    Case 5
                        database_search_m_i_mordad()
                        GridColor(mony_incoming_mordad_DataGridView)
                    Case 6
                        database_search_m_i_shahrivar()
                        GridColor(mony_incoming_shahrivar_DataGridView)
                    Case 7
                        database_search_m_i_mehr()
                        GridColor(mony_incoming_mehr_DataGridView)
                    Case 8
                        database_search_m_i_aban()
                        GridColor(mony_incoming_aban_DataGridView)
                    Case 9
                        database_search_m_i_azar()
                        GridColor(mony_incoming_azar_DataGridView)
                    Case 10
                        database_search_m_i_dey()
                        GridColor(mony_incoming_dey_DataGridView)
                    Case 11
                        database_search_m_i_bahman()
                        GridColor(mony_incoming_bahman_DataGridView)
                    Case 12
                        database_search_m_i_esfand()
                        GridColor(mony_incoming_esfand_DataGridView)
                End Select
            End If

            If Accounting_choose_item = 2 Then
                Select Case get_p_data
                    Case 1
                        database_search_m_o_farvardin()
                        GridColor(mony_Output_farvardin_DataGridView)
                    Case 2
                        database_search_m_o_ordibehesht()
                        GridColor(mony_Output_ordibehesht_DataGridView)
                    Case 3
                        database_search_m_o_khordad()
                        GridColor(mony_Output_khordad_DataGridView)
                    Case 4
                        database_search_m_o_tir()
                        GridColor(mony_Output_tir_DataGridView)
                    Case 5
                        database_search_m_o_mordad()
                        GridColor(mony_Output_mordad_DataGridView)
                    Case 6
                        database_search_m_o_shahrivar()
                        GridColor(mony_Output_shahrivar_DataGridView)
                    Case 7
                        database_search_m_o_mehr()
                        GridColor(mony_Output_mehr_DataGridView)
                    Case 8
                        database_search_m_o_aban()
                        GridColor(mony_Output_aban_DataGridView)
                    Case 9
                        database_search_m_o_azar()
                        GridColor(mony_Output_azar_DataGridView)
                    Case 10
                        database_search_m_o_dey()
                        GridColor(mony_Output_dey_DataGridView)
                    Case 11
                        database_search_m_o_bahman()
                        GridColor(mony_Output_bahman_DataGridView)
                    Case 12
                        database_search_m_o_esfand()
                        GridColor(mony_Output_esfand_DataGridView)
                End Select
            End If
        End If
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'Timer_lock_app
    Sub timers_lock()
        My.Settings.Timer_lock_app = My.Settings.Timer_lock_app + 1

        If My.Settings.Timer_lock_app = "5" Then
            Label_Timer_lock_app.Text = "30"
            Label_Timer_lock_app.Visible = True
            Timer_lock_app.Enabled = True
            TextBox_password.Enabled = False
            PictureBox_password.Enabled = False
            PictureBox_change_password_leave.Enabled = False
            Label_forgotten_password.Enabled = False
        End If

        If My.Settings.Timer_lock_app = "6" Then
            Label_Timer_lock_app.Text = "60"
            Label_Timer_lock_app.Visible = True
            Timer_lock_app.Enabled = True
            TextBox_password.Enabled = False
            PictureBox_password.Enabled = False
            PictureBox_change_password_leave.Enabled = False
            Label_forgotten_password.Enabled = False
        End If

        If My.Settings.Timer_lock_app = "7" Then
            Label_Timer_lock_app.Text = "90"
            Label_Timer_lock_app.Visible = True
            Timer_lock_app.Enabled = True
            TextBox_password.Enabled = False
            PictureBox_password.Enabled = False
            PictureBox_change_password_leave.Enabled = False
            Label_forgotten_password.Enabled = False
        End If

        If My.Settings.Timer_lock_app = "8" Then
            Label_Timer_lock_app.Text = "120"
            Label_Timer_lock_app.Visible = True
            Timer_lock_app.Enabled = True
            TextBox_password.Enabled = False
            PictureBox_password.Enabled = False
            PictureBox_change_password_leave.Enabled = False
            Label_forgotten_password.Enabled = False
        End If

        If My.Settings.Timer_lock_app = "9" Then
            Label_Timer_lock_app.Text = "150"
            Label_Timer_lock_app.Visible = True
            Timer_lock_app.Enabled = True
            TextBox_password.Enabled = False
            PictureBox_password.Enabled = False
            PictureBox_change_password_leave.Enabled = False
            Label_forgotten_password.Enabled = False
        End If



        If Panel_change_password.Visible = True Then
            If My.Settings.Timer_lock_app = "10" Then
                My.Settings.Timer_lock_app = My.Settings.Timer_lock_app - 1
                Label_Timer_lock_app.Text = "180"
                Label_Timer_lock_app.Visible = True
                Timer_lock_app.Enabled = True
                TextBox_password.Enabled = False
                PictureBox_password.Enabled = False
                PictureBox_change_password_leave.Enabled = False
                Label_forgotten_password.Enabled = False
            End If
        Else
            If My.Settings.Timer_lock_app = "10" Then
                Label_Timer_lock_app.Text = "180"
                Label_Timer_lock_app.Visible = True
                Timer_lock_app.Enabled = True
                TextBox_password.Enabled = False
                PictureBox_password.Enabled = False
                PictureBox_change_password_leave.Enabled = False
                Label_forgotten_password.Enabled = False
            End If
        End If



        If Panel_change_password.Visible = False Then
            If My.Settings.Timer_lock_app = "11" Then
                app_off()
            End If
        End If

    End Sub
    Private Sub Timer_lock_app_Tick(sender As Object, e As EventArgs)
        Label_Timer_lock_app.Text = Label_Timer_lock_app.Text - 1
    End Sub
    Private Sub Label_Timer_lock_app_TextChanged(sender As Object, e As EventArgs)
        If Label_Timer_lock_app.Text = "0" Then
            Timer_lock_app.Enabled = False
            Label_Timer_lock_app.Text = "***"
            TextBox_password.Enabled = True
            PictureBox_password.Enabled = True
            PictureBox_change_password_leave.Enabled = True
            Label_forgotten_password.Enabled = True
        End If
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'accounting
    Private Sub PictureBox_Accounting_Click(sender As Object, e As EventArgs)
        PictureBox_home.Visible = False

        Label_title.Visible = False

        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False

        If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False





        PictureBox_Accounting_back.Visible = True

        PictureBox_Accounting_money_Incoming.Visible = True
        PictureBox_Accounting_money_Output.Visible = True
        PictureBox_Accounting_money_Turnover.Visible = True
    End Sub
    Private Sub PictureBox_Accounting_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting.BackgroundImage = Global.language_class.My.Resources.Resources.money__1_
    End Sub
    Private Sub PictureBox_Accounting_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting.BackgroundImage = Global.language_class.My.Resources.Resources.money
    End Sub

    Private Sub PictureBox_Accounting_back_Click(sender As Object, e As EventArgs)
        If PictureBox_Accounting_money_Incoming.Visible = True Then
            PictureBox_home.Visible = True

            Label_title.Visible = True


            Button_students.Visible = True
            Button_teachers.Visible = True
            Button_add_s.Visible = True
            Button_add_t.Visible = True

            PictureBox_setting.Visible = True

            PictureBox_more_students.Visible = True
            PictureBox_more_teachers.Visible = True
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_students, "more")
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
            End If

            PictureBox_level_test.Visible = True
            PictureBox_charts_show.Visible = True
            PictureBox_Accounting.Visible = True





            PictureBox_Accounting_back.Visible = False

            PictureBox_Accounting_money_Incoming.Visible = False
            PictureBox_Accounting_money_Output.Visible = False
            PictureBox_Accounting_money_Turnover.Visible = False
        End If


        If Label_Accounting_farvardin.Visible = True Then
            PictureBox_Accounting_add.Visible = False
            PictureBox_Accounting_edit.Visible = False
            PictureBox_Accounting_delete.Visible = False

            Label_Accounting_farvardin.Visible = False
            Label_Accounting_ordibehesht.Visible = False
            Label_Accounting_khordad.Visible = False
            Label_Accounting_tir.Visible = False
            Label_Accounting_mordad.Visible = False
            Label_Accounting_shahrivar.Visible = False
            Label_Accounting_mehr.Visible = False
            Label_Accounting_aban.Visible = False
            Label_Accounting_azar.Visible = False
            Label_Accounting_dey.Visible = False
            Label_Accounting_bahman.Visible = False
            Label_Accounting_esfand.Visible = False


            PictureBox_Accounting_money_Incoming.Visible = True
            PictureBox_Accounting_money_Output.Visible = True
            PictureBox_Accounting_money_Turnover.Visible = True

            Accounting_choose_item = 0
        End If

        If Label_Accounting_money_add_1.Visible = True Then
            Label_Accounting_money_add_1.Visible = False
            Label_Accounting_money_add_2.Visible = False
            Label_Accounting_money_add_3.Visible = False
            Label_Accounting_money_add_4.Visible = False
            Label_Accounting_money_add_5.Visible = False
            Label_Accounting_money_add_6.Visible = False
            Label_Accounting_money_add_7.Visible = False

            TextBox_Accounting_money_add_1.Visible = False
            TextBox_Accounting_money_add_2.Visible = False
            TextBox_Accounting_money_add_3.Visible = False

            PictureBox_Accounting_add_done.Visible = False



            PictureBox_Accounting_add.Visible = True
            PictureBox_Accounting_edit.Visible = True
            PictureBox_Accounting_delete.Visible = True

            Label_Accounting_farvardin.Visible = True
            Label_Accounting_ordibehesht.Visible = True
            Label_Accounting_khordad.Visible = True
            Label_Accounting_tir.Visible = True
            Label_Accounting_mordad.Visible = True
            Label_Accounting_shahrivar.Visible = True
            Label_Accounting_mehr.Visible = True
            Label_Accounting_aban.Visible = True
            Label_Accounting_azar.Visible = True
            Label_Accounting_dey.Visible = True
            Label_Accounting_bahman.Visible = True
            Label_Accounting_esfand.Visible = True
        End If


        If mony_incoming_farvardin_DataGridView.Visible = True Or mony_incoming_ordibehesht_DataGridView.Visible = True Or mony_incoming_khordad_DataGridView.Visible = True Or mony_incoming_tir_DataGridView.Visible = True Or mony_incoming_mordad_DataGridView.Visible = True Or mony_incoming_shahrivar_DataGridView.Visible = True Or mony_incoming_mehr_DataGridView.Visible = True Or mony_incoming_aban_DataGridView.Visible = True Or mony_incoming_azar_DataGridView.Visible = True Or mony_incoming_dey_DataGridView.Visible = True Or mony_incoming_bahman_DataGridView.Visible = True Or mony_incoming_esfand_DataGridView.Visible = True Then
            mony_incoming_farvardin_DataGridView.Visible = False
            mony_incoming_ordibehesht_DataGridView.Visible = False
            mony_incoming_khordad_DataGridView.Visible = False
            mony_incoming_tir_DataGridView.Visible = False
            mony_incoming_mordad_DataGridView.Visible = False
            mony_incoming_shahrivar_DataGridView.Visible = False
            mony_incoming_mehr_DataGridView.Visible = False
            mony_incoming_aban_DataGridView.Visible = False
            mony_incoming_azar_DataGridView.Visible = False
            mony_incoming_dey_DataGridView.Visible = False
            mony_incoming_bahman_DataGridView.Visible = False
            mony_incoming_esfand_DataGridView.Visible = False

            PictureBox_Accounting_edit_choose.Visible = False
            PictureBox_Accounting_delete_choose.Visible = False

            TextBox_search.Visible = False
            PictureBox_search.Visible = False
            PictureBox_search.Location = New System.Drawing.Point(485, 25)



            PictureBox_Accounting_add.Visible = True
            PictureBox_Accounting_edit.Visible = True
            PictureBox_Accounting_delete.Visible = True

            Label_Accounting_farvardin.Visible = True
            Label_Accounting_ordibehesht.Visible = True
            Label_Accounting_khordad.Visible = True
            Label_Accounting_tir.Visible = True
            Label_Accounting_mordad.Visible = True
            Label_Accounting_shahrivar.Visible = True
            Label_Accounting_mehr.Visible = True
            Label_Accounting_aban.Visible = True
            Label_Accounting_azar.Visible = True
            Label_Accounting_dey.Visible = True
            Label_Accounting_bahman.Visible = True
            Label_Accounting_esfand.Visible = True
        End If

        If mony_Output_farvardin_DataGridView.Visible = True Or mony_Output_ordibehesht_DataGridView.Visible = True Or mony_Output_khordad_DataGridView.Visible = True Or mony_Output_tir_DataGridView.Visible = True Or mony_Output_mordad_DataGridView.Visible = True Or mony_Output_shahrivar_DataGridView.Visible = True Or mony_Output_mehr_DataGridView.Visible = True Or mony_Output_aban_DataGridView.Visible = True Or mony_Output_azar_DataGridView.Visible = True Or mony_Output_dey_DataGridView.Visible = True Or mony_Output_bahman_DataGridView.Visible = True Or mony_Output_esfand_DataGridView.Visible = True Then
            mony_Output_farvardin_DataGridView.Visible = False
            mony_Output_ordibehesht_DataGridView.Visible = False
            mony_Output_khordad_DataGridView.Visible = False
            mony_Output_tir_DataGridView.Visible = False
            mony_Output_mordad_DataGridView.Visible = False
            mony_Output_shahrivar_DataGridView.Visible = False
            mony_Output_mehr_DataGridView.Visible = False
            mony_Output_aban_DataGridView.Visible = False
            mony_Output_azar_DataGridView.Visible = False
            mony_Output_dey_DataGridView.Visible = False
            mony_Output_bahman_DataGridView.Visible = False
            mony_Output_esfand_DataGridView.Visible = False

            PictureBox_Accounting_edit_choose.Visible = False
            PictureBox_Accounting_delete_choose.Visible = False

            TextBox_search.Visible = False
            PictureBox_search.Visible = False
            PictureBox_search.Location = New System.Drawing.Point(485, 25)



            PictureBox_Accounting_add.Visible = True
            PictureBox_Accounting_edit.Visible = True
            PictureBox_Accounting_delete.Visible = True

            Label_Accounting_farvardin.Visible = True
            Label_Accounting_ordibehesht.Visible = True
            Label_Accounting_khordad.Visible = True
            Label_Accounting_tir.Visible = True
            Label_Accounting_mordad.Visible = True
            Label_Accounting_shahrivar.Visible = True
            Label_Accounting_mehr.Visible = True
            Label_Accounting_aban.Visible = True
            Label_Accounting_azar.Visible = True
            Label_Accounting_dey.Visible = True
            Label_Accounting_bahman.Visible = True
            Label_Accounting_esfand.Visible = True
        End If
    End Sub
    Private Sub PictureBox_Accounting_back_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_back.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
    End Sub
    Private Sub PictureBox_Accounting_back_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_back.BackgroundImage = Global.language_class.My.Resources.Resources.back
    End Sub

    Private Sub PictureBox_Accounting_money_Incoming_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Incoming.Visible = False
        PictureBox_Accounting_money_Output.Visible = False
        PictureBox_Accounting_money_Turnover.Visible = False


        PictureBox_Accounting_add.Visible = True
        PictureBox_Accounting_edit.Visible = True
        PictureBox_Accounting_delete.Visible = True

        Label_Accounting_farvardin.Visible = True
        Label_Accounting_ordibehesht.Visible = True
        Label_Accounting_khordad.Visible = True
        Label_Accounting_tir.Visible = True
        Label_Accounting_mordad.Visible = True
        Label_Accounting_shahrivar.Visible = True
        Label_Accounting_mehr.Visible = True
        Label_Accounting_aban.Visible = True
        Label_Accounting_azar.Visible = True
        Label_Accounting_dey.Visible = True
        Label_Accounting_bahman.Visible = True
        Label_Accounting_esfand.Visible = True

        Select Case My.Settings.p_e_language
            Case 1
                Label_Accounting_money_add_3.Text = "From"
                Label_Accounting_money_add_7.Text = "received"
            Case 0
                Label_Accounting_money_add_3.Text = "از طرف"
                Label_Accounting_money_add_7.Text = "دریافت شد"
        End Select

        Accounting_choose_item = 1

    End Sub
    Private Sub PictureBox_Accounting_money_Incoming_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Incoming.BackgroundImage = Global.language_class.My.Resources.Resources.money_Incoming_1_
    End Sub
    Private Sub PictureBox_Accounting_money_Incoming_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Incoming.BackgroundImage = Global.language_class.My.Resources.Resources.money_Incoming
    End Sub

    Private Sub PictureBox_Accounting_money_Output_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Incoming.Visible = False
        PictureBox_Accounting_money_Output.Visible = False
        PictureBox_Accounting_money_Turnover.Visible = False


        PictureBox_Accounting_add.Visible = True
        PictureBox_Accounting_edit.Visible = True
        PictureBox_Accounting_delete.Visible = True

        Label_Accounting_farvardin.Visible = True
        Label_Accounting_ordibehesht.Visible = True
        Label_Accounting_khordad.Visible = True
        Label_Accounting_tir.Visible = True
        Label_Accounting_mordad.Visible = True
        Label_Accounting_shahrivar.Visible = True
        Label_Accounting_mehr.Visible = True
        Label_Accounting_aban.Visible = True
        Label_Accounting_azar.Visible = True
        Label_Accounting_dey.Visible = True
        Label_Accounting_bahman.Visible = True
        Label_Accounting_esfand.Visible = True

        Select Case My.Settings.p_e_language
            Case 1
                Label_Accounting_money_add_3.Text = "To the"
                Label_Accounting_money_add_7.Text = "Paid"
            Case 0
                Label_Accounting_money_add_3.Text = "به"
                Label_Accounting_money_add_7.Text = "پرداخت شد"
        End Select


        Accounting_choose_item = 2
    End Sub
    Private Sub PictureBox_Accounting_money_Output_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Output.BackgroundImage = Global.language_class.My.Resources.Resources.money_Output__1_
    End Sub
    Private Sub PictureBox_Accounting_money_Output_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Output.BackgroundImage = Global.language_class.My.Resources.Resources.money_Output
    End Sub

    Private Sub PictureBox_Accounting_money_Turnover_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Incoming.Visible = False
        PictureBox_Accounting_money_Output.Visible = False
        PictureBox_Accounting_money_Turnover.Visible = False

        Accounting_choose_item = 3
    End Sub
    Private Sub PictureBox_Accounting_money_Turnover_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Turnover.BackgroundImage = Global.language_class.My.Resources.Resources.money_flow__1_
    End Sub
    Private Sub PictureBox_Accounting_money_Turnover_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_money_Turnover.BackgroundImage = Global.language_class.My.Resources.Resources.money_flow
    End Sub





    Private Sub Label_Accounting_farvardin_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_farvardin_DataGridView.Visible = True
                database_show_m_i_farvardin()
                GridColor(mony_incoming_farvardin_DataGridView)
            Case 2
                mony_Output_farvardin_DataGridView.Visible = True
                database_show_m_i_farvardin()
                GridColor(mony_Output_farvardin_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_farvardin_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_farvardin.ForeColor = Color.DeepPink
        Label_Accounting_farvardin.Location = New System.Drawing.Point(814, 150)
    End Sub
    Private Sub Label_Accounting_farvardin_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_farvardin.ForeColor = Color.Black
        Label_Accounting_farvardin.Location = New System.Drawing.Point(824, 150)
    End Sub

    Private Sub Label_Accounting_ordibehesht_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_ordibehesht_DataGridView.Visible = True
                database_show_m_i_ordibehesht()
                GridColor(mony_incoming_ordibehesht_DataGridView)
            Case 2
                mony_Output_ordibehesht_DataGridView.Visible = True
                database_show_m_i_ordibehesht()
                GridColor(mony_Output_ordibehesht_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_ordibehesht_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_ordibehesht.ForeColor = Color.DeepPink
        Label_Accounting_ordibehesht.Location = New System.Drawing.Point(814, 190)
    End Sub
    Private Sub Label_Accounting_ordibehesht_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_ordibehesht.ForeColor = Color.Black
        Label_Accounting_ordibehesht.Location = New System.Drawing.Point(824, 190)
    End Sub

    Private Sub Label_Accounting_khordad_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_khordad_DataGridView.Visible = True
                database_show_m_i_khordad()
                GridColor(mony_incoming_khordad_DataGridView)
            Case 2
                mony_Output_khordad_DataGridView.Visible = True
                database_show_m_i_khordad()
                GridColor(mony_Output_khordad_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_khordad_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_khordad.ForeColor = Color.DeepPink
        Label_Accounting_khordad.Location = New System.Drawing.Point(814, 230)
    End Sub
    Private Sub Label_Accounting_khordad_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_khordad.ForeColor = Color.Black
        Label_Accounting_khordad.Location = New System.Drawing.Point(824, 230)
    End Sub

    Private Sub Label_Accounting_tir_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_tir_DataGridView.Visible = True
                database_show_m_i_tir()
                GridColor(mony_incoming_tir_DataGridView)
            Case 2
                mony_Output_tir_DataGridView.Visible = True
                database_show_m_i_tir()
                GridColor(mony_Output_tir_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_tir_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_tir.ForeColor = Color.Green
        Label_Accounting_tir.Location = New System.Drawing.Point(814, 270)
    End Sub
    Private Sub Label_Accounting_tir_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_tir.ForeColor = Color.Black
        Label_Accounting_tir.Location = New System.Drawing.Point(824, 270)
    End Sub

    Private Sub Label_Accounting_mordad_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_mordad_DataGridView.Visible = True
                database_show_m_i_mordad()
                GridColor(mony_incoming_mordad_DataGridView)
            Case 2
                mony_Output_mordad_DataGridView.Visible = True
                database_show_m_i_mordad()
                GridColor(mony_Output_mordad_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_mordad_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_mordad.ForeColor = Color.Green
        Label_Accounting_mordad.Location = New System.Drawing.Point(814, 310)
    End Sub
    Private Sub Label_Accounting_mordad_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_mordad.ForeColor = Color.Black
        Label_Accounting_mordad.Location = New System.Drawing.Point(824, 310)
    End Sub

    Private Sub Label_Accounting_shahrivar_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_shahrivar_DataGridView.Visible = True
                database_show_m_i_shahrivar()
                GridColor(mony_incoming_shahrivar_DataGridView)
            Case 2
                mony_Output_shahrivar_DataGridView.Visible = True
                database_show_m_i_shahrivar()
                GridColor(mony_Output_shahrivar_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_shahrivar_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_shahrivar.ForeColor = Color.Green
        Label_Accounting_shahrivar.Location = New System.Drawing.Point(814, 350)
    End Sub
    Private Sub Label_Accounting_shahrivar_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_shahrivar.ForeColor = Color.Black
        Label_Accounting_shahrivar.Location = New System.Drawing.Point(824, 350)
    End Sub

    Private Sub Label_Accounting_mehr_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_mehr_DataGridView.Visible = True
                database_show_m_i_mehr()
                GridColor(mony_incoming_mehr_DataGridView)
            Case 2
                mony_Output_mehr_DataGridView.Visible = True
                database_show_m_i_mehr()
                GridColor(mony_Output_mehr_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_mehr_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_mehr.ForeColor = Color.DarkOrange
        Label_Accounting_mehr.Location = New System.Drawing.Point(20, 150)
    End Sub
    Private Sub Label_Accounting_mehr_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_mehr.ForeColor = Color.Black
        Label_Accounting_mehr.Location = New System.Drawing.Point(10, 150)
    End Sub

    Private Sub Label_Accounting_aban_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_aban_DataGridView.Visible = True
                database_show_m_i_aban()
                GridColor(mony_incoming_aban_DataGridView)
            Case 2
                mony_Output_aban_DataGridView.Visible = True
                database_show_m_i_aban()
                GridColor(mony_Output_aban_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_aban_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_aban.ForeColor = Color.DarkOrange
        Label_Accounting_aban.Location = New System.Drawing.Point(20, 190)
    End Sub
    Private Sub Label_Accounting_aban_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_aban.ForeColor = Color.Black
        Label_Accounting_aban.Location = New System.Drawing.Point(10, 190)
    End Sub

    Private Sub Label_Accounting_azar_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_azar_DataGridView.Visible = True
                database_show_m_i_azar()
                GridColor(mony_incoming_azar_DataGridView)
            Case 2
                mony_Output_azar_DataGridView.Visible = True
                database_show_m_i_azar()
                GridColor(mony_Output_azar_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_azar_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_azar.ForeColor = Color.DarkOrange
        Label_Accounting_azar.Location = New System.Drawing.Point(20, 230)
    End Sub
    Private Sub Label_Accounting_azar_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_azar.ForeColor = Color.Black
        Label_Accounting_azar.Location = New System.Drawing.Point(10, 230)
    End Sub

    Private Sub Label_Accounting_dey_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_dey_DataGridView.Visible = True
                database_show_m_i_dey()
                GridColor(mony_incoming_dey_DataGridView)
            Case 2
                mony_Output_dey_DataGridView.Visible = True
                database_show_m_i_dey()
                GridColor(mony_Output_dey_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_dey_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_dey.ForeColor = Color.DodgerBlue
        Label_Accounting_dey.Location = New System.Drawing.Point(20, 270)
    End Sub
    Private Sub Label_Accounting_dey_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_dey.ForeColor = Color.Black
        Label_Accounting_dey.Location = New System.Drawing.Point(10, 270)
    End Sub

    Private Sub Label_Accounting_bahman_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_bahman_DataGridView.Visible = True
                database_show_m_i_bahman()
                GridColor(mony_incoming_bahman_DataGridView)

                count_row = mony_incoming_bahman_DataGridView.Rows.Count - 1
                For i = 0 To count_row
                    Label_Accounting_count_amount.Text = Val(Label_Accounting_count_amount.Text.ToString) + Val(mony_incoming_bahman_DataGridView.Rows(i).Cells(1).Value.ToString)
                Next
                Label_Accounting_count_amount_number.Text = mony_incoming_bahman_DataGridView.Rows.Count
            Case 2
                mony_Output_bahman_DataGridView.Visible = True
                database_show_m_i_bahman()
                GridColor(mony_Output_bahman_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_Accounting_count_amount.Visible = True
        PictureBox_Accounting_count_amount_number.Visible = True
        Label_Accounting_count_amount.Visible = True
        Label_Accounting_count_amount_number.Visible = True


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_bahman_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_bahman.ForeColor = Color.DodgerBlue
        Label_Accounting_bahman.Location = New System.Drawing.Point(20, 310)
    End Sub
    Private Sub Label_Accounting_bahman_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_bahman.ForeColor = Color.Black
        Label_Accounting_bahman.Location = New System.Drawing.Point(10, 310)
    End Sub

    Private Sub Label_Accounting_esfand_Click(sender As Object, e As EventArgs)
        Select Case Accounting_choose_item
            Case 1
                mony_incoming_esfand_DataGridView.Visible = True
                database_show_m_i_esfand()
                GridColor(mony_incoming_esfand_DataGridView)
            Case 2
                mony_Output_esfand_DataGridView.Visible = True
                database_show_m_i_esfand()
                GridColor(mony_Output_esfand_DataGridView)
        End Select



        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False


        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If
    End Sub
    Private Sub Label_Accounting_esfand_MouseEnter(sender As Object, e As EventArgs)
        Label_Accounting_esfand.ForeColor = Color.DodgerBlue
        Label_Accounting_esfand.Location = New System.Drawing.Point(20, 350)
    End Sub
    Private Sub Label_Accounting_esfand_MouseLeave(sender As Object, e As EventArgs)
        Label_Accounting_esfand.ForeColor = Color.Black
        Label_Accounting_esfand.Location = New System.Drawing.Point(10, 350)
    End Sub





    Private Sub PictureBox_Accounting_add_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False




        Label_Accounting_money_add_1.Visible = True
        Label_Accounting_money_add_2.Visible = True
        Label_Accounting_money_add_3.Visible = True
        Label_Accounting_money_add_4.Visible = True
        Label_Accounting_money_add_5.Visible = True
        Label_Accounting_money_add_6.Visible = True
        Label_Accounting_money_add_7.Visible = True

        TextBox_Accounting_money_add_1.Visible = True
        TextBox_Accounting_money_add_2.Visible = True
        TextBox_Accounting_money_add_3.Visible = True

        PictureBox_Accounting_add_done.Visible = True


        TextBox_Accounting_money_add_1.Text = String.Empty
        TextBox_Accounting_money_add_2.Text = String.Empty
        TextBox_Accounting_money_add_3.Text = String.Empty

        TextBox_Accounting_money_add_1.Focus()
    End Sub
    Private Sub PictureBox_Accounting_add_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_add.Size = New System.Drawing.Point(60, 60)
    End Sub
    Private Sub PictureBox_Accounting_add_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_add.Size = New System.Drawing.Point(50, 50)
    End Sub

    Private Sub PictureBox_Accounting_edit_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False

        PictureBox_Accounting_edit_choose.Visible = True



        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If




        get_p_data = PersianCalendar.GetMonth(Now()).ToString

        If Accounting_choose_item = 1 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    database_show_m_i_farvardin()
                    GridColor(mony_incoming_farvardin_DataGridView)
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    database_show_m_i_ordibehesht()
                    GridColor(mony_incoming_ordibehesht_DataGridView)
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    database_show_m_i_khordad()
                    GridColor(mony_incoming_khordad_DataGridView)
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    database_show_m_i_tir()
                    GridColor(mony_incoming_tir_DataGridView)
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    database_show_m_i_mordad()
                    GridColor(mony_incoming_mordad_DataGridView)
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    database_show_m_i_shahrivar()
                    GridColor(mony_incoming_shahrivar_DataGridView)
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    database_show_m_i_mehr()
                    GridColor(mony_incoming_mehr_DataGridView)
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    database_show_m_i_aban()
                    GridColor(mony_incoming_aban_DataGridView)
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    database_show_m_i_azar()
                    GridColor(mony_incoming_azar_DataGridView)
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    database_show_m_i_dey()
                    GridColor(mony_incoming_dey_DataGridView)
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    database_show_m_i_bahman()
                    GridColor(mony_incoming_bahman_DataGridView)
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    database_show_m_i_esfand()
                    GridColor(mony_incoming_esfand_DataGridView)
            End Select
        End If


        If Accounting_choose_item = 2 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    database_show_m_o_farvardin()
                    GridColor(mony_Output_farvardin_DataGridView)
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    database_show_m_o_ordibehesht()
                    GridColor(mony_Output_ordibehesht_DataGridView)
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    database_show_m_o_khordad()
                    GridColor(mony_Output_khordad_DataGridView)
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    database_show_m_o_tir()
                    GridColor(mony_Output_tir_DataGridView)
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    database_show_m_o_mordad()
                    GridColor(mony_Output_mordad_DataGridView)
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    database_show_m_o_shahrivar()
                    GridColor(mony_Output_shahrivar_DataGridView)
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    database_show_m_o_mehr()
                    GridColor(mony_Output_mehr_DataGridView)
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    database_show_m_o_aban()
                    GridColor(mony_Output_aban_DataGridView)
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    database_show_m_o_azar()
                    GridColor(mony_Output_azar_DataGridView)
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    database_show_m_o_dey()
                    GridColor(mony_Output_dey_DataGridView)
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    database_show_m_o_bahman()
                    GridColor(mony_Output_bahman_DataGridView)
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    database_show_m_o_esfand()
                    GridColor(mony_Output_esfand_DataGridView)
            End Select
        End If
    End Sub
    Private Sub PictureBox_Accounting_edit_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_edit.Size = New System.Drawing.Point(40, 40)
    End Sub
    Private Sub PictureBox_Accounting_edit_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_edit.Size = New System.Drawing.Point(30, 30)
    End Sub

    Private Sub PictureBox_Accounting_delete_Click(sender As Object, e As EventArgs)
        PictureBox_Accounting_add.Visible = False
        PictureBox_Accounting_edit.Visible = False
        PictureBox_Accounting_delete.Visible = False

        Label_Accounting_farvardin.Visible = False
        Label_Accounting_ordibehesht.Visible = False
        Label_Accounting_khordad.Visible = False
        Label_Accounting_tir.Visible = False
        Label_Accounting_mordad.Visible = False
        Label_Accounting_shahrivar.Visible = False
        Label_Accounting_mehr.Visible = False
        Label_Accounting_aban.Visible = False
        Label_Accounting_azar.Visible = False
        Label_Accounting_dey.Visible = False
        Label_Accounting_bahman.Visible = False
        Label_Accounting_esfand.Visible = False

        PictureBox_Accounting_delete_choose.Visible = True



        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If




        get_p_data = PersianCalendar.GetMonth(Now()).ToString

        If Accounting_choose_item = 1 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    database_show_m_i_farvardin()
                    GridColor(mony_incoming_farvardin_DataGridView)
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    database_show_m_i_ordibehesht()
                    GridColor(mony_incoming_ordibehesht_DataGridView)
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    database_show_m_i_khordad()
                    GridColor(mony_incoming_khordad_DataGridView)
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    database_show_m_i_tir()
                    GridColor(mony_incoming_tir_DataGridView)
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    database_show_m_i_mordad()
                    GridColor(mony_incoming_mordad_DataGridView)
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    database_show_m_i_shahrivar()
                    GridColor(mony_incoming_shahrivar_DataGridView)
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    database_show_m_i_mehr()
                    GridColor(mony_incoming_mehr_DataGridView)
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    database_show_m_i_aban()
                    GridColor(mony_incoming_aban_DataGridView)
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    database_show_m_i_azar()
                    GridColor(mony_incoming_azar_DataGridView)
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    database_show_m_i_dey()
                    GridColor(mony_incoming_dey_DataGridView)
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    database_show_m_i_bahman()
                    GridColor(mony_incoming_bahman_DataGridView)
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    database_show_m_i_esfand()
                    GridColor(mony_incoming_esfand_DataGridView)
            End Select
        End If


        If Accounting_choose_item = 2 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    database_show_m_o_farvardin()
                    GridColor(mony_Output_farvardin_DataGridView)
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    database_show_m_o_ordibehesht()
                    GridColor(mony_Output_ordibehesht_DataGridView)
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    database_show_m_o_khordad()
                    GridColor(mony_Output_khordad_DataGridView)
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    database_show_m_o_tir()
                    GridColor(mony_Output_tir_DataGridView)
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    database_show_m_o_mordad()
                    GridColor(mony_Output_mordad_DataGridView)
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    database_show_m_o_shahrivar()
                    GridColor(mony_Output_shahrivar_DataGridView)
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    database_show_m_o_mehr()
                    GridColor(mony_Output_mehr_DataGridView)
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    database_show_m_o_aban()
                    GridColor(mony_Output_aban_DataGridView)
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    database_show_m_o_azar()
                    GridColor(mony_Output_azar_DataGridView)
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    database_show_m_o_dey()
                    GridColor(mony_Output_dey_DataGridView)
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    database_show_m_o_bahman()
                    GridColor(mony_Output_bahman_DataGridView)
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    database_show_m_o_esfand()
                    GridColor(mony_Output_esfand_DataGridView)
            End Select
        End If
    End Sub
    Private Sub PictureBox_Accounting_delete_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_delete.Size = New System.Drawing.Point(40, 40)
    End Sub
    Private Sub PictureBox_Accounting_delete_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_delete.Size = New System.Drawing.Point(30, 30)
    End Sub





    Private Sub PictureBox_Accounting_add_done_Click(sender As Object, e As EventArgs)
        Label_Accounting_money_add_1.Visible = False
        Label_Accounting_money_add_2.Visible = False
        Label_Accounting_money_add_3.Visible = False
        Label_Accounting_money_add_4.Visible = False
        Label_Accounting_money_add_5.Visible = False
        Label_Accounting_money_add_6.Visible = False
        Label_Accounting_money_add_7.Visible = False

        TextBox_Accounting_money_add_1.Visible = False
        TextBox_Accounting_money_add_2.Visible = False
        TextBox_Accounting_money_add_3.Visible = False

        PictureBox_Accounting_add_done.Visible = False




        PictureBox_search.Visible = True
        If Radio_english.Checked = True Then
            TextBox_search.Text = "Search"
            TextBox_search.Text = "Search"
        Else
            TextBox_search.Text = "جستجو"
            TextBox_search.Text = "جستجو"
        End If




        get_p_data = PersianCalendar.GetMonth(Now()).ToString '- 1

        If Accounting_choose_item = 1 And Accounting_edit = 0 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    database_add_m_i_farvardin()
                    GridColor(mony_incoming_farvardin_DataGridView)
                    count_row = mony_incoming_farvardin_DataGridView.Rows.Count - 1
                    mony_incoming_farvardin_DataGridView.CurrentCell = mony_incoming_farvardin_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_farvardin_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    database_add_m_i_ordibehesht()
                    GridColor(mony_incoming_ordibehesht_DataGridView)
                    count_row = mony_incoming_ordibehesht_DataGridView.Rows.Count - 1
                    mony_incoming_ordibehesht_DataGridView.CurrentCell = mony_incoming_ordibehesht_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_ordibehesht_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    database_add_m_i_khordad()
                    GridColor(mony_incoming_khordad_DataGridView)
                    count_row = mony_incoming_khordad_DataGridView.Rows.Count - 1
                    mony_incoming_khordad_DataGridView.CurrentCell = mony_incoming_khordad_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_khordad_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    database_add_m_i_tir()
                    GridColor(mony_incoming_tir_DataGridView)
                    count_row = mony_incoming_tir_DataGridView.Rows.Count - 1
                    mony_incoming_tir_DataGridView.CurrentCell = mony_incoming_tir_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_tir_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    database_add_m_i_mordad()
                    GridColor(mony_incoming_mordad_DataGridView)
                    count_row = mony_incoming_mordad_DataGridView.Rows.Count - 1
                    mony_incoming_mordad_DataGridView.CurrentCell = mony_incoming_mordad_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_mordad_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    database_add_m_i_shahrivar()
                    GridColor(mony_incoming_shahrivar_DataGridView)
                    count_row = mony_incoming_shahrivar_DataGridView.Rows.Count - 1
                    mony_incoming_shahrivar_DataGridView.CurrentCell = mony_incoming_shahrivar_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_shahrivar_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    database_add_m_i_mehr()
                    GridColor(mony_incoming_mehr_DataGridView)
                    count_row = mony_incoming_mehr_DataGridView.Rows.Count - 1
                    mony_incoming_mehr_DataGridView.CurrentCell = mony_incoming_mehr_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_mehr_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    database_add_m_i_aban()
                    GridColor(mony_incoming_aban_DataGridView)
                    count_row = mony_incoming_aban_DataGridView.Rows.Count - 1
                    mony_incoming_aban_DataGridView.CurrentCell = mony_incoming_aban_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_aban_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    database_add_m_i_azar()
                    GridColor(mony_incoming_azar_DataGridView)
                    count_row = mony_incoming_azar_DataGridView.Rows.Count - 1
                    mony_incoming_azar_DataGridView.CurrentCell = mony_incoming_azar_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_azar_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    database_add_m_i_dey()
                    GridColor(mony_incoming_dey_DataGridView)
                    count_row = mony_incoming_dey_DataGridView.Rows.Count - 1
                    mony_incoming_dey_DataGridView.CurrentCell = mony_incoming_dey_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_dey_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    database_add_m_i_bahman()
                    GridColor(mony_incoming_bahman_DataGridView)
                    count_row = mony_incoming_bahman_DataGridView.Rows.Count - 1
                    mony_incoming_bahman_DataGridView.CurrentCell = mony_incoming_bahman_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_bahman_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    database_add_m_i_esfand()
                    GridColor(mony_incoming_esfand_DataGridView)
                    count_row = mony_incoming_esfand_DataGridView.Rows.Count - 1
                    mony_incoming_esfand_DataGridView.CurrentCell = mony_incoming_esfand_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_incoming_esfand_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
            End Select
        End If


        If Accounting_choose_item = 2 And Accounting_edit = 0 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    database_add_m_o_farvardin()
                    GridColor(mony_Output_farvardin_DataGridView)
                    count_row = mony_Output_farvardin_DataGridView.Rows.Count - 1
                    mony_Output_farvardin_DataGridView.CurrentCell = mony_Output_farvardin_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_farvardin_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    database_add_m_o_ordibehesht()
                    GridColor(mony_Output_ordibehesht_DataGridView)
                    count_row = mony_Output_ordibehesht_DataGridView.Rows.Count - 1
                    mony_Output_ordibehesht_DataGridView.CurrentCell = mony_Output_ordibehesht_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_ordibehesht_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    database_add_m_o_khordad()
                    GridColor(mony_Output_khordad_DataGridView)
                    count_row = mony_Output_khordad_DataGridView.Rows.Count - 1
                    mony_Output_khordad_DataGridView.CurrentCell = mony_Output_khordad_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_khordad_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    database_add_m_o_tir()
                    GridColor(mony_Output_tir_DataGridView)
                    count_row = mony_Output_tir_DataGridView.Rows.Count - 1
                    mony_Output_tir_DataGridView.CurrentCell = mony_Output_tir_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_tir_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    database_add_m_o_mordad()
                    GridColor(mony_Output_mordad_DataGridView)
                    count_row = mony_Output_mordad_DataGridView.Rows.Count - 1
                    mony_Output_mordad_DataGridView.CurrentCell = mony_Output_mordad_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_mordad_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    database_add_m_o_shahrivar()
                    GridColor(mony_Output_shahrivar_DataGridView)
                    count_row = mony_Output_shahrivar_DataGridView.Rows.Count - 1
                    mony_Output_shahrivar_DataGridView.CurrentCell = mony_Output_shahrivar_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_shahrivar_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    database_add_m_o_mehr()
                    GridColor(mony_Output_mehr_DataGridView)
                    count_row = mony_Output_mehr_DataGridView.Rows.Count - 1
                    mony_Output_mehr_DataGridView.CurrentCell = mony_Output_mehr_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_mehr_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    database_add_m_o_aban()
                    GridColor(mony_Output_aban_DataGridView)
                    count_row = mony_Output_aban_DataGridView.Rows.Count - 1
                    mony_Output_aban_DataGridView.CurrentCell = mony_Output_aban_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_aban_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    database_add_m_o_azar()
                    GridColor(mony_Output_azar_DataGridView)
                    count_row = mony_Output_azar_DataGridView.Rows.Count - 1
                    mony_Output_azar_DataGridView.CurrentCell = mony_Output_azar_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_azar_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    database_add_m_o_dey()
                    GridColor(mony_Output_dey_DataGridView)
                    count_row = mony_Output_dey_DataGridView.Rows.Count - 1
                    mony_Output_dey_DataGridView.CurrentCell = mony_Output_dey_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_dey_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    database_add_m_o_bahman()
                    GridColor(mony_Output_bahman_DataGridView)
                    count_row = mony_Output_bahman_DataGridView.Rows.Count - 1
                    mony_Output_bahman_DataGridView.CurrentCell = mony_Output_bahman_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_bahman_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    database_add_m_o_esfand()
                    GridColor(mony_Output_esfand_DataGridView)
                    count_row = mony_Output_esfand_DataGridView.Rows.Count - 1
                    mony_Output_esfand_DataGridView.CurrentCell = mony_Output_esfand_DataGridView.Rows(count_row).Cells(0)
                    For b = 0 To 5
                        mony_Output_esfand_DataGridView.Rows.Item(count_row).Cells.Item(b).Style.BackColor = Color.Green
                    Next
            End Select
        End If






        If Accounting_choose_item = 1 And Accounting_edit = 1 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    database_edit_m_i_farvardin()
                    GridColor(mony_incoming_farvardin_DataGridView)
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    database_edit_m_i_ordibehesht()
                    GridColor(mony_incoming_ordibehesht_DataGridView)
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    database_edit_m_i_khordad()
                    GridColor(mony_incoming_khordad_DataGridView)
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    database_edit_m_i_tir()
                    GridColor(mony_incoming_tir_DataGridView)
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    database_edit_m_i_mordad()
                    GridColor(mony_incoming_mordad_DataGridView)
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    database_edit_m_i_shahrivar()
                    GridColor(mony_incoming_shahrivar_DataGridView)
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    database_edit_m_i_mehr()
                    GridColor(mony_incoming_mehr_DataGridView)
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    database_edit_m_i_aban()
                    GridColor(mony_incoming_aban_DataGridView)
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    database_edit_m_i_azar()
                    GridColor(mony_incoming_azar_DataGridView)
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    database_edit_m_i_dey()
                    GridColor(mony_incoming_dey_DataGridView)
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    database_edit_m_i_bahman()
                    GridColor(mony_incoming_bahman_DataGridView)
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    database_edit_m_i_esfand()
                    GridColor(mony_incoming_esfand_DataGridView)
            End Select
        End If


        If Accounting_choose_item = 2 And Accounting_edit = 1 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    database_edit_m_o_farvardin()
                    GridColor(mony_Output_farvardin_DataGridView)
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    database_edit_m_o_ordibehesht()
                    GridColor(mony_Output_ordibehesht_DataGridView)
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    database_edit_m_o_khordad()
                    GridColor(mony_Output_khordad_DataGridView)
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    database_edit_m_o_tir()
                    GridColor(mony_Output_tir_DataGridView)
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    database_edit_m_o_mordad()
                    GridColor(mony_Output_mordad_DataGridView)
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    database_edit_m_o_shahrivar()
                    GridColor(mony_Output_shahrivar_DataGridView)
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    database_edit_m_o_mehr()
                    GridColor(mony_Output_mehr_DataGridView)
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    database_edit_m_o_aban()
                    GridColor(mony_Output_aban_DataGridView)
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    database_edit_m_o_azar()
                    GridColor(mony_Output_azar_DataGridView)
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    database_edit_m_o_dey()
                    GridColor(mony_Output_dey_DataGridView)
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    database_edit_m_o_bahman()
                    GridColor(mony_Output_bahman_DataGridView)
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    database_edit_m_o_esfand()
                    GridColor(mony_Output_esfand_DataGridView)
            End Select
        End If

        Accounting_edit = 0
    End Sub
    Private Sub PictureBox_Accounting_add_done_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_add_done.BackgroundImage = Global.language_class.My.Resources.Resources.checked__2_
    End Sub
    Private Sub PictureBox_Accounting_add_done_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_add_done.BackgroundImage = Global.language_class.My.Resources.Resources.checked
    End Sub

    Private Sub PictureBox_Accounting_edit_choose_Click(sender As Object, e As EventArgs)
        Accounting_edit = 1

        Label_Accounting_money_add_1.Visible = True
        Label_Accounting_money_add_2.Visible = True
        Label_Accounting_money_add_3.Visible = True
        Label_Accounting_money_add_4.Visible = True
        Label_Accounting_money_add_5.Visible = True
        Label_Accounting_money_add_6.Visible = True
        Label_Accounting_money_add_7.Visible = True

        TextBox_Accounting_money_add_1.Visible = True
        TextBox_Accounting_money_add_2.Visible = True
        TextBox_Accounting_money_add_3.Visible = True

        PictureBox_Accounting_add_done.Visible = True

        TextBox_Accounting_money_add_1.Text = String.Empty
        TextBox_Accounting_money_add_2.Text = String.Empty
        TextBox_Accounting_money_add_3.Text = String.Empty





        PictureBox_Accounting_edit_choose.Visible = False

        TextBox_search.Visible = False
        PictureBox_search.Visible = False
        PictureBox_search.Location = New System.Drawing.Point(485, 25)


        get_p_data = PersianCalendar.GetMonth(Now()).ToString

        If Accounting_choose_item = 1 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    save_ID_number = mony_incoming_farvardin_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_farvardin_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_farvardin_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_farvardin_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    save_ID_number = mony_incoming_ordibehesht_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_ordibehesht_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_ordibehesht_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_ordibehesht_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    save_ID_number = mony_incoming_khordad_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_khordad_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_khordad_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_khordad_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    save_ID_number = mony_incoming_tir_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_tir_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_tir_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_tir_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    save_ID_number = mony_incoming_mordad_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_mordad_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_mordad_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_mordad_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    save_ID_number = mony_incoming_shahrivar_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_shahrivar_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_shahrivar_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_shahrivar_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    save_ID_number = mony_incoming_mehr_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_mehr_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_mehr_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_mehr_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    save_ID_number = mony_incoming_aban_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_aban_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_aban_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_aban_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    save_ID_number = mony_incoming_azar_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_azar_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_azar_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_azar_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    save_ID_number = mony_incoming_dey_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_dey_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_dey_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_dey_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    save_ID_number = mony_incoming_bahman_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_bahman_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_bahman_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_bahman_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    save_ID_number = mony_incoming_esfand_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_incoming_esfand_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_incoming_esfand_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_incoming_esfand_DataGridView.CurrentRow.Cells(3).Value.ToString
            End Select
        End If


        If Accounting_choose_item = 2 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    save_ID_number = mony_Output_farvardin_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_farvardin_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_farvardin_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_farvardin_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    save_ID_number = mony_Output_ordibehesht_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_ordibehesht_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_ordibehesht_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_ordibehesht_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    save_ID_number = mony_Output_khordad_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_khordad_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_khordad_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_khordad_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    save_ID_number = mony_Output_tir_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_tir_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_tir_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_tir_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    save_ID_number = mony_Output_mordad_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_mordad_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_mordad_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_mordad_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    save_ID_number = mony_Output_shahrivar_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_shahrivar_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_shahrivar_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_shahrivar_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    save_ID_number = mony_Output_mehr_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_mehr_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_mehr_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_mehr_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    save_ID_number = mony_Output_aban_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_aban_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_aban_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_aban_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    save_ID_number = mony_Output_azar_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_azar_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_azar_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_azar_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    save_ID_number = mony_Output_dey_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_dey_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_dey_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_dey_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    save_ID_number = mony_Output_bahman_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_bahman_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_bahman_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_bahman_DataGridView.CurrentRow.Cells(3).Value.ToString
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    save_ID_number = mony_Output_esfand_DataGridView.CurrentRow.Cells(0).Value
                    TextBox_Accounting_money_add_1.Text = mony_Output_esfand_DataGridView.CurrentRow.Cells(1).Value.ToString
                    TextBox_Accounting_money_add_2.Text = mony_Output_esfand_DataGridView.CurrentRow.Cells(2).Value.ToString
                    TextBox_Accounting_money_add_3.Text = mony_Output_esfand_DataGridView.CurrentRow.Cells(3).Value.ToString
            End Select
        End If





    End Sub
    Private Sub PictureBox_Accounting_edit_choose_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_edit_choose.BackgroundImage = Global.language_class.My.Resources.Resources.edit__1_
    End Sub
    Private Sub PictureBox_Accounting_edit_choose_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_edit_choose.BackgroundImage = Global.language_class.My.Resources.Resources.edit
    End Sub

    Private Sub PictureBox_Accounting_delete_choose_Click(sender As Object, e As EventArgs)
        get_p_data = PersianCalendar.GetMonth(Now()).ToString

        If Accounting_choose_item = 1 Then
            Select Case get_p_data
                Case 1
                    mony_incoming_farvardin_DataGridView.Visible = True
                    database_delete_m_i_farvardin()
                    GridColor(mony_incoming_farvardin_DataGridView)
                Case 2
                    mony_incoming_ordibehesht_DataGridView.Visible = True
                    database_delete_m_i_ordibehesht()
                    GridColor(mony_incoming_ordibehesht_DataGridView)
                Case 3
                    mony_incoming_khordad_DataGridView.Visible = True
                    database_delete_m_i_khordad()
                    GridColor(mony_incoming_khordad_DataGridView)
                Case 4
                    mony_incoming_tir_DataGridView.Visible = True
                    database_delete_m_i_tir()
                    GridColor(mony_incoming_tir_DataGridView)
                Case 5
                    mony_incoming_mordad_DataGridView.Visible = True
                    database_delete_m_i_mordad()
                    GridColor(mony_incoming_mordad_DataGridView)
                Case 6
                    mony_incoming_shahrivar_DataGridView.Visible = True
                    database_delete_m_i_shahrivar()
                    GridColor(mony_incoming_shahrivar_DataGridView)
                Case 7
                    mony_incoming_mehr_DataGridView.Visible = True
                    database_delete_m_i_mehr()
                    GridColor(mony_incoming_mehr_DataGridView)
                Case 8
                    mony_incoming_aban_DataGridView.Visible = True
                    database_delete_m_i_aban()
                    GridColor(mony_incoming_aban_DataGridView)
                Case 9
                    mony_incoming_azar_DataGridView.Visible = True
                    database_delete_m_i_azar()
                    GridColor(mony_incoming_azar_DataGridView)
                Case 10
                    mony_incoming_dey_DataGridView.Visible = True
                    database_delete_m_i_dey()
                    GridColor(mony_incoming_dey_DataGridView)
                Case 11
                    mony_incoming_bahman_DataGridView.Visible = True
                    database_delete_m_i_bahman()
                    GridColor(mony_incoming_bahman_DataGridView)
                Case 12
                    mony_incoming_esfand_DataGridView.Visible = True
                    database_delete_m_i_esfand()
                    GridColor(mony_incoming_esfand_DataGridView)
            End Select
        End If


        If Accounting_choose_item = 2 Then
            Select Case get_p_data
                Case 1
                    mony_Output_farvardin_DataGridView.Visible = True
                    database_delete_m_o_farvardin()
                    GridColor(mony_Output_farvardin_DataGridView)
                Case 2
                    mony_Output_ordibehesht_DataGridView.Visible = True
                    database_delete_m_o_ordibehesht()
                    GridColor(mony_Output_ordibehesht_DataGridView)
                Case 3
                    mony_Output_khordad_DataGridView.Visible = True
                    database_delete_m_o_khordad()
                    GridColor(mony_Output_khordad_DataGridView)
                Case 4
                    mony_Output_tir_DataGridView.Visible = True
                    database_delete_m_o_tir()
                    GridColor(mony_Output_tir_DataGridView)
                Case 5
                    mony_Output_mordad_DataGridView.Visible = True
                    database_delete_m_o_mordad()
                    GridColor(mony_Output_mordad_DataGridView)
                Case 6
                    mony_Output_shahrivar_DataGridView.Visible = True
                    database_delete_m_o_shahrivar()
                    GridColor(mony_Output_shahrivar_DataGridView)
                Case 7
                    mony_Output_mehr_DataGridView.Visible = True
                    database_delete_m_o_mehr()
                    GridColor(mony_Output_mehr_DataGridView)
                Case 8
                    mony_Output_aban_DataGridView.Visible = True
                    database_delete_m_o_aban()
                    GridColor(mony_Output_aban_DataGridView)
                Case 9
                    mony_Output_azar_DataGridView.Visible = True
                    database_delete_m_o_azar()
                    GridColor(mony_Output_azar_DataGridView)
                Case 10
                    mony_Output_dey_DataGridView.Visible = True
                    database_delete_m_o_dey()
                    GridColor(mony_Output_dey_DataGridView)
                Case 11
                    mony_Output_bahman_DataGridView.Visible = True
                    database_delete_m_o_bahman()
                    GridColor(mony_Output_bahman_DataGridView)
                Case 12
                    mony_Output_esfand_DataGridView.Visible = True
                    database_delete_m_o_esfand()
                    GridColor(mony_Output_esfand_DataGridView)
            End Select
        End If
    End Sub
    Private Sub PictureBox_Accounting_delete_choose_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Accounting_delete_choose.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button__1_
    End Sub
    Private Sub PictureBox_Accounting_delete_choose_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Accounting_delete_choose.BackgroundImage = Global.language_class.My.Resources.Resources.kids_delete_button
    End Sub

    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'charts_option
    Private Sub PictureBox_charts_show_Click(sender As Object, e As EventArgs)
        PictureBox_home.Visible = False

        Label_title.Visible = False

        Button_students.Visible = False
        Button_teachers.Visible = False
        Button_add_s.Visible = False
        Button_edit_s.Visible = False
        Button_delete_s.Visible = False
        Button_add_t.Visible = False
        Button_edit_t.Visible = False
        Button_delete_t.Visible = False

        PictureBox_setting.Visible = False

        PictureBox_more_students.Visible = False
        PictureBox_more_teachers.Visible = False

        If GroupBox_setting.Location = New System.Drawing.Point(-1, 0) Then
            PictureBox_setting.BackgroundImage = Global.language_class.My.Resources.Resources.settings_cogwheel__1_
        End If

        GroupBox_setting.Location = New System.Drawing.Point(-210, 0)
        PictureBox_setting.Location = New System.Drawing.Point(5, 25)

        PictureBox_level_test.Visible = False
        PictureBox_charts_show.Visible = False
        PictureBox_Accounting.Visible = False


        PictureBox_charts_show_back.Visible = True
        Label_charts_show_explain_in_all.Visible = True
        PictureBox_charts_show_choose_item.Visible = True
        PictureBox_charts_show_all.Visible = True
        PictureBox_charts_show_teachers.Visible = True
        PictureBox_charts_show_students.Visible = True
    End Sub

    Private Sub PictureBox_charts_show_back_Click(sender As Object, e As EventArgs)
        If PictureBox_charts_show_choose_item.Visible = True Then

            PictureBox_home.Visible = True

            Label_title.Visible = True


            Button_students.Visible = True
            Button_teachers.Visible = True
            Button_add_s.Visible = True
            Button_add_t.Visible = True

            PictureBox_setting.Visible = True

            PictureBox_more_students.Visible = True
            PictureBox_more_teachers.Visible = True
            PictureBox_more_students.BackgroundImage = Global.language_class.My.Resources.Resources.more
            PictureBox_more_teachers.BackgroundImage = Global.language_class.My.Resources.Resources.more
            If Radio_persian.Checked = True Then
                ToolTip_main.SetToolTip(PictureBox_more_students, "بیشتر")
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "بیشتر")
            Else
                ToolTip_main.SetToolTip(PictureBox_more_students, "more")
                ToolTip_main.SetToolTip(PictureBox_more_teachers, "more")
            End If

            PictureBox_level_test.Visible = True
            PictureBox_charts_show.Visible = True
            PictureBox_Accounting.Visible = True


            PictureBox_charts_show_back.Visible = False

            Label_charts_show_explain_in_all.Visible = False
            PictureBox_charts_show_choose_item.Visible = False
            PictureBox_charts_show_all.Visible = False
            PictureBox_charts_show_teachers.Visible = False
            PictureBox_charts_show_students.Visible = False
        Else
            Chart_all.Visible = False
            Chart_teachers.Visible = False
            Chart_students.Visible = False

            Label_charts_choose_language.Visible = False
            Label_charts_choose_gender.Visible = False
            Label_charts_choose_birthday.Visible = False
            Label_charts_choose_date_of_registration.Visible = False
            PictureBox_charts_2d_3d.Visible = False
            PictureBox_Part_charts_tips.Visible = False
            PictureBox_Part_charts_restore_to_default.Visible = False
            PictureBox_charts_change_type.Visible = False
            PictureBox_charts_change_color.Visible = False
            TrackBar_charts_type.Visible = False
            TrackBar_charts_color.Visible = False

            Label_Part_charts_tips_1.Visible = False
            Label_Part_charts_tips_2.Visible = False
            Label_Part_charts_tips_3.Visible = False
            Label_Part_charts_tips_4.Visible = False
            Label_Part_charts_tips_5.Visible = False

            Label_charts_show_explain_in_all.Visible = True
            PictureBox_charts_show_choose_item.Visible = True
            PictureBox_charts_show_all.Visible = True
            PictureBox_charts_show_teachers.Visible = True
            PictureBox_charts_show_students.Visible = True
        End If
    End Sub

    Private Sub PictureBox_charts_show_all_Click(sender As Object, e As EventArgs)
        Chart_all.Visible = True

        Label_charts_show_explain_in_all.Visible = False
        PictureBox_charts_show_choose_item.Visible = False
        PictureBox_charts_show_all.Visible = False
        PictureBox_charts_show_teachers.Visible = False
        PictureBox_charts_show_students.Visible = False


        Label_charts_choose_language.Visible = True
        Label_charts_choose_gender.Visible = True
        Label_charts_choose_birthday.Visible = True
        Label_charts_choose_date_of_registration.Visible = True
        PictureBox_charts_2d_3d.Visible = True
        PictureBox_Part_charts_tips.Visible = True
        PictureBox_Part_charts_restore_to_default.Visible = True
        PictureBox_charts_change_type.Visible = True
        PictureBox_charts_change_color.Visible = True
        TrackBar_charts_type.Visible = True
        TrackBar_charts_color.Visible = True

        Label_Part_charts_tips_1.Visible = False
        Label_Part_charts_tips_2.Visible = False
        Label_Part_charts_tips_3.Visible = False
        Label_Part_charts_tips_4.Visible = False
        Label_Part_charts_tips_5.Visible = False

        database_show_student()
        database_show_teacher()

        chart_all_language()

        Select Case My.Settings.p_e_language
            Case 1
                ToolTip_main.SetToolTip(Label_charts_choose_language, "Chart statistics based on the selected language")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "Chart statistics based on gender")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "Chart statistics based on age")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "Chart statistics based on Registration date")
                Label_charts_choose_language.Text = "LANGUAGE"
                Label_charts_choose_gender.Text = "GENDER"
                Label_charts_choose_birthday.Text = "AGE"
                Label_charts_choose_date_of_registration.Text = "Registration date"
            Case 0
                ToolTip_main.SetToolTip(Label_charts_choose_language, "آمار های نموداری بر اساس زبان انتخاب شده")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "آمار های نموداری بر اساس جنسیت افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "آمار های نموداری بر اساس سن افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "آمار های نموداری بر اساس تاریخ ثبت نام")
                Label_charts_choose_language.Text = "زبان"
                Label_charts_choose_gender.Text = "جنسیت"
                Label_charts_choose_birthday.Text = "سن"
                Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
        End Select
        Label_charts_choose_language.Size = New System.Drawing.Point(85, 60)
        Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)
        Label_charts_choose_language.ForeColor = Color.Crimson
        Label_charts_choose_gender.ForeColor = Color.Black
        Label_charts_choose_birthday.ForeColor = Color.Black
        Label_charts_choose_date_of_registration.ForeColor = Color.Black
        Label_charts_choose_language.Text = "🛑" & vbNewLine & Label_charts_choose_language.Text

        TrackBar_charts_color.Value = Part_charts_color_all
        TrackBar_charts_type.Value = Part_charts_type_all

        PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp
    End Sub
    Private Sub PictureBox_charts_show_teachers_Click(sender As Object, e As EventArgs)
        Chart_teachers.Visible = True

        Label_charts_show_explain_in_all.Visible = False
        PictureBox_charts_show_choose_item.Visible = False
        PictureBox_charts_show_all.Visible = False
        PictureBox_charts_show_teachers.Visible = False
        PictureBox_charts_show_students.Visible = False


        Label_charts_choose_language.Visible = True
        Label_charts_choose_gender.Visible = True
        Label_charts_choose_birthday.Visible = True
        Label_charts_choose_date_of_registration.Visible = True
        PictureBox_charts_2d_3d.Visible = True
        PictureBox_Part_charts_tips.Visible = True
        PictureBox_Part_charts_restore_to_default.Visible = True
        PictureBox_charts_change_type.Visible = True
        PictureBox_charts_change_color.Visible = True
        TrackBar_charts_type.Visible = True
        TrackBar_charts_color.Visible = True

        Label_Part_charts_tips_1.Visible = False
        Label_Part_charts_tips_2.Visible = False
        Label_Part_charts_tips_3.Visible = False
        Label_Part_charts_tips_4.Visible = False
        Label_Part_charts_tips_5.Visible = False

        database_show_student()
        database_show_teacher()

        chart_teachers_language()

        Select Case My.Settings.p_e_language
            Case 1
                ToolTip_main.SetToolTip(Label_charts_choose_language, "Chart statistics based on the selected language")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "Chart statistics based on gender")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "Chart statistics based on age")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "Chart statistics based on Employment date")
                Label_charts_choose_language.Text = "LANGUAGE"
                Label_charts_choose_gender.Text = "GENDER"
                Label_charts_choose_birthday.Text = "AGE"
                Label_charts_choose_date_of_registration.Text = "Employment date"
            Case 0
                ToolTip_main.SetToolTip(Label_charts_choose_language, "آمار های نموداری بر اساس زبان انتخاب شده")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "آمار های نموداری بر اساس جنسیت افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "آمار های نموداری بر اساس سن افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "آمار های نموداری بر اساس تاریخ استخدام")
                Label_charts_choose_language.Text = "زبان"
                Label_charts_choose_gender.Text = "جنسیت"
                Label_charts_choose_birthday.Text = "سن"
                Label_charts_choose_date_of_registration.Text = "تاریخ استخدام"
        End Select
        Label_charts_choose_language.Size = New System.Drawing.Point(85, 60)
        Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)
        Label_charts_choose_language.ForeColor = Color.Crimson
        Label_charts_choose_gender.ForeColor = Color.Black
        Label_charts_choose_birthday.ForeColor = Color.Black
        Label_charts_choose_date_of_registration.ForeColor = Color.Black
        Label_charts_choose_language.Text = "🛑" & vbNewLine & Label_charts_choose_language.Text

        TrackBar_charts_color.Value = Part_charts_color_teachers
        TrackBar_charts_type.Value = Part_charts_type_teachers

        PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp
    End Sub
    Private Sub PictureBox_charts_show_students_Click(sender As Object, e As EventArgs)
        Chart_students.Visible = True

        Label_charts_show_explain_in_all.Visible = False
        PictureBox_charts_show_choose_item.Visible = False
        PictureBox_charts_show_all.Visible = False
        PictureBox_charts_show_teachers.Visible = False
        PictureBox_charts_show_students.Visible = False


        Label_charts_choose_language.Visible = True
        Label_charts_choose_gender.Visible = True
        Label_charts_choose_birthday.Visible = True
        Label_charts_choose_date_of_registration.Visible = True
        PictureBox_charts_2d_3d.Visible = True
        PictureBox_Part_charts_tips.Visible = True
        PictureBox_Part_charts_restore_to_default.Visible = True
        PictureBox_charts_change_type.Visible = True
        PictureBox_charts_change_color.Visible = True
        TrackBar_charts_type.Visible = True
        TrackBar_charts_color.Visible = True

        Label_Part_charts_tips_1.Visible = False
        Label_Part_charts_tips_2.Visible = False
        Label_Part_charts_tips_3.Visible = False
        Label_Part_charts_tips_4.Visible = False
        Label_Part_charts_tips_5.Visible = False

        database_show_student()
        database_show_teacher()

        chart_students_language()

        Select Case My.Settings.p_e_language
            Case 1
                ToolTip_main.SetToolTip(Label_charts_choose_language, "Chart statistics based on the selected language")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "Chart statistics based on gender")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "Chart statistics based on age")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "Chart statistics based on Registration date")
                Label_charts_choose_language.Text = "LANGUAGE"
                Label_charts_choose_gender.Text = "GENDER"
                Label_charts_choose_birthday.Text = "AGE"
                Label_charts_choose_date_of_registration.Text = "Registration date"
            Case 0
                ToolTip_main.SetToolTip(Label_charts_choose_language, "آمار های نموداری بر اساس زبان انتخاب شده")
                ToolTip_main.SetToolTip(Label_charts_choose_gender, "آمار های نموداری بر اساس جنسیت افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_birthday, "آمار های نموداری بر اساس سن افراد")
                ToolTip_main.SetToolTip(Label_charts_choose_date_of_registration, "آمار های نموداری بر اساس تاریخ ثبت نام")
                Label_charts_choose_language.Text = "زبان"
                Label_charts_choose_gender.Text = "جنسیت"
                Label_charts_choose_birthday.Text = "سن"
                Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
        End Select
        Label_charts_choose_language.Size = New System.Drawing.Point(85, 60)
        Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)
        Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)
        Label_charts_choose_language.ForeColor = Color.Crimson
        Label_charts_choose_gender.ForeColor = Color.Black
        Label_charts_choose_birthday.ForeColor = Color.Black
        Label_charts_choose_date_of_registration.ForeColor = Color.Black
        Label_charts_choose_language.Text = "🛑" & vbNewLine & Label_charts_choose_language.Text

        TrackBar_charts_color.Value = Part_charts_color_students
        TrackBar_charts_type.Value = Part_charts_type_students

        PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp
    End Sub


    Private Sub Label_charts_choose_language_Click(sender As Object, e As EventArgs)
        If Label_charts_choose_language.Text = "🛑" & vbNewLine & "LANGUAGE" Or Label_charts_choose_language.Text = "🛑" & vbNewLine & "زبان" Then
        Else
            Label_charts_choose_language.Text = "🛑" & vbNewLine & Label_charts_choose_language.Text
            Label_charts_choose_language.Size = New System.Drawing.Point(85, 60)

            Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
            Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)
            Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)

            Label_charts_choose_language.ForeColor = Color.Crimson
            Label_charts_choose_gender.ForeColor = Color.Black
            Label_charts_choose_birthday.ForeColor = Color.Black
            Label_charts_choose_date_of_registration.ForeColor = Color.Black

            Select Case My.Settings.p_e_language
                Case 1
                    Label_charts_choose_gender.Text = "GENDER"
                    Label_charts_choose_birthday.Text = "AGE"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "Employment date"
                    Else
                        Label_charts_choose_date_of_registration.Text = "Registration date"
                    End If
                Case 0
                    Label_charts_choose_gender.Text = "جنسیت"
                    Label_charts_choose_birthday.Text = "سن"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "تاریخ استخدام"
                    Else
                        Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
                    End If
            End Select
        End If

        database_show_student()
        database_show_teacher()
        If Chart_all.Visible = True Then chart_all_language()
        If Chart_teachers.Visible = True Then chart_teachers_language()
        If Chart_students.Visible = True Then chart_students_language()
    End Sub
    Private Sub Label_charts_choose_language_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_charts_choose_language.ForeColor = Color.Crimson Then
            Label_charts_choose_language.ForeColor = Color.DarkOrange
        End If
    End Sub
    Private Sub Label_charts_choose_language_MouseLeave(sender As Object, e As EventArgs)
        If Not Label_charts_choose_language.ForeColor = Color.Crimson Then
            Label_charts_choose_language.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_charts_choose_gender_Click(sender As Object, e As EventArgs)

        If Label_charts_choose_gender.Text = "🛑" & vbNewLine & "GENDER" Or Label_charts_choose_gender.Text = "🛑" & vbNewLine & "جنسیت" Then
        Else
            Label_charts_choose_gender.Text = "🛑" & vbNewLine & Label_charts_choose_gender.Text
            Label_charts_choose_gender.Size = New System.Drawing.Point(80, 60)

            Label_charts_choose_language.Size = New System.Drawing.Point(85, 40)
            Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)
            Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)

            Label_charts_choose_gender.ForeColor = Color.Crimson
            Label_charts_choose_language.ForeColor = Color.Black
            Label_charts_choose_birthday.ForeColor = Color.Black
            Label_charts_choose_date_of_registration.ForeColor = Color.Black

            Select Case My.Settings.p_e_language
                Case 1
                    Label_charts_choose_language.Text = "LANGUAGE"
                    Label_charts_choose_birthday.Text = "AGE"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "Employment date"
                    Else
                        Label_charts_choose_date_of_registration.Text = "Registration date"
                    End If
                Case 0
                    Label_charts_choose_language.Text = "زبان"
                    Label_charts_choose_birthday.Text = "سن"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "تاریخ استخدام"
                    Else
                        Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
                    End If
            End Select
        End If

        database_show_student()
        database_show_teacher()
        If Chart_all.Visible = True Then chart_all_gender()
        If Chart_teachers.Visible = True Then chart_teachers_gender()
        If Chart_students.Visible = True Then chart_students_gender()
    End Sub
    Private Sub Label_charts_choose_gender_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_charts_choose_gender.ForeColor = Color.Crimson Then
            Label_charts_choose_gender.ForeColor = Color.DarkOrange
        End If
    End Sub
    Private Sub Label_charts_choose_gender_MouseLeave(sender As Object, e As EventArgs)
        If Not Label_charts_choose_gender.ForeColor = Color.Crimson Then
            Label_charts_choose_gender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_charts_choose_birthday_Click(sender As Object, e As EventArgs)

        If Label_charts_choose_birthday.Text = "🛑" & vbNewLine & "AGE" Or Label_charts_choose_birthday.Text = "🛑" & vbNewLine & "سن" Then
        Else
            Label_charts_choose_birthday.Text = "🛑" & vbNewLine & Label_charts_choose_birthday.Text
            Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 60)

            Label_charts_choose_language.Size = New System.Drawing.Point(85, 40)
            Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
            Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 40)

            Label_charts_choose_birthday.ForeColor = Color.Crimson
            Label_charts_choose_language.ForeColor = Color.Black
            Label_charts_choose_gender.ForeColor = Color.Black
            Label_charts_choose_date_of_registration.ForeColor = Color.Black

            Select Case My.Settings.p_e_language
                Case 1
                    Label_charts_choose_language.Text = "LANGUAGE"
                    Label_charts_choose_gender.Text = "GENDER"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "Employment date"
                    Else
                        Label_charts_choose_date_of_registration.Text = "Registration date"
                    End If
                Case 0
                    Label_charts_choose_language.Text = "زبان"
                    Label_charts_choose_gender.Text = "جنسیت"
                    If Chart_teachers.Visible = True Then
                        Label_charts_choose_date_of_registration.Text = "تاریخ استخدام"
                    Else
                        Label_charts_choose_date_of_registration.Text = "تاریخ ثبت نام"
                    End If
            End Select
        End If

        database_show_student()
        database_show_teacher()
        If Chart_all.Visible = True Then chart_all_birthday()
        If Chart_teachers.Visible = True Then chart_teachers_birthday()
        If Chart_students.Visible = True Then chart_student_birthday()
    End Sub
    Private Sub Label_charts_choose_birthday_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_charts_choose_birthday.ForeColor = Color.Crimson Then
            Label_charts_choose_birthday.ForeColor = Color.DarkOrange
        End If
    End Sub
    Private Sub Label_charts_choose_birthday_MouseLeave(sender As Object, e As EventArgs)
        If Not Label_charts_choose_birthday.ForeColor = Color.Crimson Then
            Label_charts_choose_birthday.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label_charts_choose_date_of_registration_Click(sender As Object, e As EventArgs)

        If Label_charts_choose_date_of_registration.Text = "🛑" & vbNewLine & "Registration date" Or Label_charts_choose_date_of_registration.Text = "🛑" & vbNewLine & "تاریخ ثبت نام" Or Label_charts_choose_date_of_registration.Text = "🛑" & vbNewLine & "Employment date" Or Label_charts_choose_date_of_registration.Text = "🛑" & vbNewLine & "تاریخ استخدام" Then
        Else
            Label_charts_choose_date_of_registration.Text = "🛑" & vbNewLine & Label_charts_choose_date_of_registration.Text
            Label_charts_choose_date_of_registration.Size = New System.Drawing.Point(95, 60)

            Label_charts_choose_language.Size = New System.Drawing.Point(85, 40)
            Label_charts_choose_gender.Size = New System.Drawing.Point(80, 40)
            Label_charts_choose_birthday.Size = New System.Drawing.Point(80, 40)

            Label_charts_choose_date_of_registration.ForeColor = Color.Crimson
            Label_charts_choose_language.ForeColor = Color.Black
            Label_charts_choose_gender.ForeColor = Color.Black
            Label_charts_choose_birthday.ForeColor = Color.Black

            Select Case My.Settings.p_e_language
                Case 1
                    Label_charts_choose_language.Text = "LANGUAGE"
                    Label_charts_choose_gender.Text = "GENDER"
                    Label_charts_choose_birthday.Text = "AGE"
                Case 0
                    Label_charts_choose_language.Text = "زبان"
                    Label_charts_choose_gender.Text = "جنسیت"
                    Label_charts_choose_birthday.Text = "سن"
            End Select
        End If

        database_show_student()
        database_show_teacher()
        If Chart_all.Visible = True Then chart_all_date_of_registration()
        If Chart_teachers.Visible = True Then chart_teachers_date_of_registration()
        If Chart_students.Visible = True Then chart_student_date_of_registration()
    End Sub
    Private Sub Label_charts_choose_date_of_registration_MouseEnter(sender As Object, e As EventArgs)
        If Not Label_charts_choose_date_of_registration.ForeColor = Color.Crimson Then
            Label_charts_choose_date_of_registration.ForeColor = Color.DarkOrange
        End If
    End Sub
    Private Sub Label_charts_choose_date_of_registration_MouseLeave(sender As Object, e As EventArgs)
        If Not Label_charts_choose_date_of_registration.ForeColor = Color.Crimson Then
            Label_charts_choose_date_of_registration.ForeColor = Color.Black
        End If
    End Sub



    Private Sub PictureBox_charts_2d_3d_Click(sender As Object, e As EventArgs)
        If Chart_all.ChartAreas(0).Area3DStyle.Enable3D = False Then
            Chart_all.ChartAreas(0).Area3DStyle.Enable3D = True
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._2d
        Else
            Chart_all.ChartAreas(0).Area3DStyle.Enable3D = False
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._3d
        End If

        If Chart_teachers.ChartAreas(0).Area3DStyle.Enable3D = False Then
            Chart_teachers.ChartAreas(0).Area3DStyle.Enable3D = True
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._2d
        Else
            Chart_teachers.ChartAreas(0).Area3DStyle.Enable3D = False
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._3d
        End If

        If Chart_students.ChartAreas(0).Area3DStyle.Enable3D = False Then
            Chart_students.ChartAreas(0).Area3DStyle.Enable3D = True
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._2d
        Else
            Chart_students.ChartAreas(0).Area3DStyle.Enable3D = False
            PictureBox_charts_2d_3d.BackgroundImage = Global.language_class.My.Resources.Resources._3d
        End If
    End Sub
    Private Sub PictureBox_charts_2d_3d_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_charts_2d_3d.Size = New System.Drawing.Point(40, 40)
    End Sub
    Private Sub PictureBox_charts_2d_3d_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_charts_2d_3d.Size = New System.Drawing.Point(30, 30)
    End Sub

    Private Sub PictureBox_Part_charts_tips_Click(sender As Object, e As EventArgs)
        If Label_Part_charts_tips_1.Visible = False Then
            Label_Part_charts_tips_1.Visible = True
            Label_Part_charts_tips_2.Visible = True
            Label_Part_charts_tips_3.Visible = True
            Label_Part_charts_tips_4.Visible = True
            Label_Part_charts_tips_5.Visible = True
            PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp_1_
        Else
            Label_Part_charts_tips_1.Visible = False
            Label_Part_charts_tips_2.Visible = False
            Label_Part_charts_tips_3.Visible = False
            Label_Part_charts_tips_4.Visible = False
            Label_Part_charts_tips_5.Visible = False
            PictureBox_Part_charts_tips.BackgroundImage = Global.language_class.My.Resources.Resources.lamp
        End If
    End Sub
    Private Sub PictureBox_Part_charts_tips_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Part_charts_tips.Size = New System.Drawing.Point(40, 40)
    End Sub
    Private Sub PictureBox_Part_charts_tips_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Part_charts_tips.Size = New System.Drawing.Point(30, 30)
    End Sub

    Private Sub PictureBox_Part_charts_restore_to_default_Click(sender As Object, e As EventArgs)

        If Chart_all.Visible = True Then
            Part_charts_type_all = 9
            Part_charts_color_all = 2

            Chart_all.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_all.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_all.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_all.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut

            Chart_all.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_all.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_all.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_all.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        End If

        If Chart_teachers.Visible = True Then
            Part_charts_type_teachers = 9
            Part_charts_color_teachers = 2

            Chart_teachers.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_teachers.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_teachers.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_teachers.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut

            Chart_teachers.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_teachers.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_teachers.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_teachers.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        End If

        If Chart_students.Visible = True Then
            Part_charts_type_students = 9
            Part_charts_color_students = 2

            Chart_students.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_students.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_students.Series(2).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            Chart_students.Series(3).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut

            Chart_students.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_students.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_students.Series(2).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            Chart_students.Series(3).Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
        End If


        TrackBar_charts_type.Value = 9
        TrackBar_charts_color.Value = 2
    End Sub
    Private Sub PictureBox_Part_charts_restore_to_default_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_Part_charts_restore_to_default.BackgroundImage = Global.language_class.My.Resources.Resources.restore_1_
        PictureBox_Part_charts_restore_to_default.Size = New System.Drawing.Point(40, 40)
    End Sub
    Private Sub PictureBox_Part_charts_restore_to_default_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_Part_charts_restore_to_default.BackgroundImage = Global.language_class.My.Resources.Resources.restore
        PictureBox_Part_charts_restore_to_default.Size = New System.Drawing.Point(30, 30)
    End Sub

    Private Sub TrackBar_charts_type_Scroll(sender As Object, e As EventArgs)
        charts_type_Scroll()
    End Sub
    Private Sub TrackBar_charts_color_Scroll(sender As Object, e As EventArgs)
        charts_color_Scroll()
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'password_recovery
    Private Sub Label_forgotten_password_Click(sender As Object, e As EventArgs)
        Label_Timer_lock_app.Visible = False
        Label_password.Visible = False
        TextBox_password.Visible = False
        PictureBox_password.Visible = False
        Label_forgotten_password.Visible = False

        Label_return_password.Visible = True
        Textbox_return_password.Visible = True
        PictureBox_return_password.Visible = True
        PictureBox_back_to_password.Visible = True

        Textbox_return_password.Text = String.Empty
        Textbox_return_password.Focus()

        PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next

        If My.Settings.p_e_language = 1 Then
            ToolTip_main.SetToolTip(PictureBox_return_password, "next level")
        Else
            ToolTip_main.SetToolTip(PictureBox_return_password, "مرحله بعد")
        End If

        If My.Settings.p_e_language = 1 Then
            Label_return_password.Text = "Enter the purchase serial number in the box below to recover your password"
        Else
            Label_return_password.Text = "برای بازیابی رمز عبور شماره سریال خرید را در کادر زیر وارد نمایید"
        End If
    End Sub
    Private Sub Label_forgotten_password_MouseEnter(sender As Object, e As EventArgs)
        Label_forgotten_password.ForeColor = Color.DarkOrange
    End Sub
    Private Sub Label_forgotten_password_MouseLeave(sender As Object, e As EventArgs)
        Label_forgotten_password.ForeColor = Color.Blue
    End Sub

    Private Sub Textbox_return_password_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox_return_password_Click(sender As Object, e As EventArgs)
        If Panel_change_password.Visible = True Then
            If Textbox_return_password.Text = "6070012020" Then
                Label_Timer_lock_app.Visible = False
                My.Settings.Timer_lock_app = "0"

                Label_password.Visible = False
                TextBox_password.Visible = False
                PictureBox_password.Visible = False
                Label_return_password.Visible = False
                Textbox_return_password.Visible = False
                PictureBox_return_password.Visible = False
                PictureBox_back_to_password.Visible = False

                Label_change_password_1.Visible = True
                Label_change_password_2.Visible = True

                TextBox_change_password_1.Visible = True
                TextBox_change_password_2.Visible = True

                PictureBox_change_password_leave.Visible = True
                PictureBox_change_password_done.Visible = True

                TextBox_change_password_1.Focus()
            Else
                If My.Settings.p_e_language = 1 Then
                    MessageBox.Show("The entered serial number is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("شماره سریال وارد شده اشتباه است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            End If
        Else
            Select Case Textbox_return_password.Visible
                Case True
                    If Textbox_return_password.Text = "6070012020" Then
                        Textbox_return_password_p_1.Visible = True
                        Textbox_return_password_p_2.Visible = True
                        Label_return_password_p_1.Visible = True
                        Label_return_password_p_2.Visible = True

                        Textbox_return_password.Visible = False

                        Textbox_return_password_p_1.Text = String.Empty
                        Textbox_return_password_p_2.Text = String.Empty

                        Textbox_return_password_p_1.Focus()

                        Label_return_password.Location = New System.Drawing.Point(100, 100)
                        PictureBox_return_password.Location = New System.Drawing.Point(475.5, 330)

                        PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._return

                        If My.Settings.p_e_language = 1 Then
                            ToolTip_main.SetToolTip(PictureBox_return_password, "Recovery")
                            Label_return_password.Text = "Please select a new password"
                            Label_return_password_p_1.Text = "New password"
                            Label_return_password_p_2.Text = "Repeat new password"
                            Label_return_password_p_1.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                            Label_return_password_p_2.Font = New System.Drawing.Font("B nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        Else
                            ToolTip_main.SetToolTip(PictureBox_return_password, "بازیابی")
                            Label_return_password.Text = "لطفا یک رمز جدید انتخاب کنید"
                            Label_return_password_p_1.Text = "رمز جدید"
                            Label_return_password_p_2.Text = "تکرار رمز جدید"
                            Label_return_password_p_1.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                            Label_return_password_p_2.Font = New System.Drawing.Font("B nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                        End If
                    Else
                        If My.Settings.p_e_language = 1 Then
                            MessageBox.Show("The entered serial number is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Else
                            MessageBox.Show("شماره سریال وارد شده اشتباه است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                Case False
                    If Textbox_return_password_p_1.Text = Textbox_return_password_p_2.Text Then
                        My.Settings.change_password = Textbox_return_password_p_2.Text
                        My.Settings.Timer_lock_app = "0"

                        Label_return_password.Visible = False
                        Textbox_return_password.Visible = False
                        PictureBox_return_password.Visible = False
                        Textbox_return_password_p_1.Visible = False
                        Textbox_return_password_p_2.Visible = False
                        Label_return_password_p_1.Visible = False
                        Label_return_password_p_2.Visible = False
                        PictureBox_back_to_password.Visible = False

                        Label_password.Visible = True
                        TextBox_password.Visible = True
                        PictureBox_password.Visible = True
                        Label_forgotten_password.Visible = True


                        Label_return_password.Location = New System.Drawing.Point(100, 190)
                        PictureBox_return_password.Location = New System.Drawing.Point(475.5, 290)

                        PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next

                        Label_return_password.ForeColor = Color.Black

                        TextBox_password.Text = String.Empty
                        TextBox_password.Focus()

                        Label_forgotten_password.Visible = False

                        If My.Settings.p_e_language = 1 Then
                            ToolTip_main.SetToolTip(PictureBox_return_password, "next level")
                            Label_return_password.Text = "Enter the purchase serial number in the box below to recover your password"
                        Else
                            ToolTip_main.SetToolTip(PictureBox_return_password, "مرحله بعد")
                            Label_return_password.Text = "برای بازیابی رمز عبور شماره سریال خرید را در کادر زیر وارد نمایید"
                        End If

                        Label_password.ForeColor = Color.Black
                        If My.Settings.p_e_language = 1 Then
                            Label_password.Text = "Please enter password"
                        Else
                            Label_password.Text = "رمز ورود را وارد کنید"
                        End If
                        If My.Settings.p_e_language = 1 Then
                            MessageBox.Show("Password changed successfully", "Passwors changed", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Else
                            MessageBox.Show("تغییر گذرواژه با موفقیت انجام شد", "تغییر گذروازه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        Label_return_password.ForeColor = Color.Red
                        If My.Settings.p_e_language = 1 Then
                            Label_return_password.Text = "Field mismatch"
                        Else
                            Label_return_password.Text = "عدم مطابقت فیلد ها"
                        End If
                        Textbox_return_password_p_1.Text = String.Empty
                        Textbox_return_password_p_2.Text = String.Empty
                        Textbox_return_password_p_1.Focus()
                    End If
            End Select
        End If
    End Sub
    Private Sub PictureBox_return_password_MouseEnter(sender As Object, e As EventArgs)
        If Textbox_return_password.Visible = True Then
            PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources.next__1_
        Else
            PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources.return__1_
        End If
    End Sub
    Private Sub PictureBox_return_password_MouseLeave(sender As Object, e As EventArgs)
        If Textbox_return_password.Visible = True Then
            PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next
        Else
            PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._return
        End If
    End Sub

    Private Sub PictureBox_back_to_password_Click(sender As Object, e As EventArgs)
        If Textbox_return_password.Visible = True Then
            Label_Timer_lock_app.Visible = True
            Label_password.Visible = True
            TextBox_password.Visible = True
            PictureBox_password.Visible = True
            Label_forgotten_password.Visible = True

            Label_return_password.Visible = False
            Textbox_return_password.Visible = False
            PictureBox_return_password.Visible = False
            PictureBox_back_to_password.Visible = False
        Else
            Label_return_password.Visible = True
            Textbox_return_password.Visible = True
            PictureBox_return_password.Visible = True

            Textbox_return_password_p_1.Visible = False
            Textbox_return_password_p_2.Visible = False
            Label_return_password_p_1.Visible = False
            Label_return_password_p_2.Visible = False

            Label_return_password.Location = New System.Drawing.Point(100, 190)
            PictureBox_return_password.Location = New System.Drawing.Point(475.5, 290)

            PictureBox_return_password.BackgroundImage = Global.language_class.My.Resources.Resources._next

            Label_return_password.ForeColor = Color.Black

            If My.Settings.p_e_language = 1 Then
                ToolTip_main.SetToolTip(PictureBox_return_password, "next level")
                Label_return_password.Text = "Enter the purchase serial number in the box below to recover your password"
            Else
                ToolTip_main.SetToolTip(PictureBox_return_password, "مرحله بعد")
                Label_return_password.Text = "برای بازیابی رمز عبور شماره سریال خرید را در کادر زیر وارد نمایید"
            End If
        End If
    End Sub
    Private Sub PictureBox_back_to_password_MouseEnter(sender As Object, e As EventArgs)
        PictureBox_back_to_password.BackgroundImage = Global.language_class.My.Resources.Resources.back__1_
    End Sub
    Private Sub PictureBox_back_to_password_MouseLeave(sender As Object, e As EventArgs)
        PictureBox_back_to_password.BackgroundImage = Global.language_class.My.Resources.Resources.back
    End Sub
    '
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    ''''''''''''''''''''''''''''''''''''''''''''''''''')
    '
    'app_off
    Sub app_off()
        Label_Timer_lock_app.Visible = False
        Label_password.Visible = False
        TextBox_password.Visible = False
        PictureBox_password.Visible = False


        PictureBox_app_off.Visible = True
        Label_1_app_off.Visible = True
        Label_2_app_off.Visible = True
        TextBox_app_off.Visible = True

        TextBox_app_off.Text = String.Empty


        If Radio_english.Checked = True Then
            Label_1_app_off.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label_1_app_off.Text = "The application has been completely unavailable. because more than 10 times entered incorrect password" & vbNewLine & "Email to below address your calling information to retrieve the app"
        Else
            Label_1_app_off.Text = "به دلیل اشتباه وارد کردن رمز عبور بیش از 10 مرتبه اپلیکیشن به طور کامل از دسترس خارج شده است " & vbNewLine & "برای بازیابی اپلیکیشن اطلاعات تماس خود را به آدرس زیر ایمیل بزنید"
        End If

        Label_2_app_off.Text = "Mr.danial.khodarahmi@gmail.com"

    End Sub
    Private Sub TextBox_app_off_DoubleClick(sender As Object, e As EventArgs)
        If TextBox_app_off.Text = "danip" Then
            My.Settings.Timer_lock_app = "0"
            PictureBox_app_off.Visible = False
            Label_1_app_off.Visible = False
            Label_2_app_off.Visible = False
            TextBox_app_off.Visible = False

            Label_Timer_lock_app.Visible = False

            Label_password.Visible = True
            TextBox_password.Visible = True
            PictureBox_password.Visible = True
            If Radio_english.Checked = True Then
                Label_password.Text = "Please enter password"
            Else
                Label_password.Text = "رمز ورود را وارد کنید"
            End If
            Label_password.ForeColor = Color.Black
            TextBox_password.Text = String.Empty
            TextBox_password.UseSystemPasswordChar = True
        End If
    End Sub





    Private Sub Label_msg_box_option_1_Click(sender As Object, e As EventArgs)
        Panel_msg_box.Visible = False


        Button_students.Enabled = True
        Button_teachers.Enabled = True
        Button_delete_s.Enabled = True
        Button_edit_s.Enabled = True
        Button_add_s.Enabled = True
        Button_add_t.Enabled = True
        Button_edit_t.Enabled = True
        Button_delete_t.Enabled = True

        PictureBox_back_to_home_from_students_and_teachers_list.Enabled = True
        PictureBox_complete_registration_students.Enabled = True
        PictureBox_complete_registration_teachers.Enabled = True
        PictureBox_back_to_home_from_registration_students.Enabled = True
        PictureBox_back_to_home_from_registration_teachers.Enabled = True
        PictureBox_more_students.Enabled = True
        PictureBox_more_teachers.Enabled = True
        PictureBox_edit_students.Enabled = True
        PictureBox_edit_teachers.Enabled = True
        PictureBox_delete_students.Enabled = True
        PictureBox_delete_teachers.Enabled = True
        PictureBox_about_us.Enabled = True
        PictureBox_back_to_home_from_about_us.Enabled = True
        PictureBox_change_password_done.Enabled = True
        PictureBox_change_password_leave.Enabled = True
        PictureBox_password.Enabled = True
        PictureBox_change_passwors.Enabled = True
        PictureBox_setting.Enabled = True
        PictureBox_level_s.Enabled = True
        PictureBox_search.Enabled = True
        PictureBox_select_language_next_level.Enabled = True
        PictureBox_level_test.Enabled = True
        PictureBox_b_f_level_test.Enabled = True
        PictureBox_return_password.Enabled = True
        PictureBox_back_to_password.Enabled = True
        PictureBox_msg_box_left.Enabled = True
        PictureBox_msg_box_right.Enabled = True
        PictureBox_charts_show.Enabled = True
        PictureBox_charts_show_all.Enabled = True
        PictureBox_charts_show_teachers.Enabled = True
        PictureBox_charts_show_students.Enabled = True
        PictureBox_charts_show_back.Enabled = True
        PictureBox_charts_2d_3d.Enabled = True
        PictureBox_charts_change_type.Enabled = True
        PictureBox_charts_change_color.Enabled = True
        PictureBox_Part_charts_tips.Enabled = True
        PictureBox_Part_charts_restore_to_default.Enabled = True
        PictureBox_music.Enabled = True
        PictureBox_Accounting.Enabled = True

        Label_l_t_answer_1.Enabled = True
        Label_l_t_answer_2.Enabled = True
        Label_l_t_answer_3.Enabled = True
        Label_l_t_answer_4.Enabled = True
        Label_forgotten_password.Enabled = True
        Label_charts_choose_language.Enabled = True
        Label_charts_choose_gender.Enabled = True
        Label_charts_choose_birthday.Enabled = True
        Label_charts_choose_date_of_registration.Enabled = True

        GroupBox_setting.Enabled = True

        TrackBar_charts_type.Enabled = True
        TrackBar_charts_color.Enabled = True

        Panel_change_password.Enabled = True

        Radio_persian.Enabled = True
        Radio_english.Enabled = True
        RadioButton_male_s.Enabled = True
        RadioButton_female_s.Enabled = True
        RadioButton_male_t.Enabled = True
        RadioButton_female_t.Enabled = True

        CheckBox_en.Enabled = True
        CheckBox_tur.Enabled = True
        CheckBox_spa.Enabled = True
        CheckBox_ita.Enabled = True
        CheckBox_fre.Enabled = True
        CheckBox_arab.Enabled = True
        CheckBox_chi.Enabled = True
        CheckBox_japa.Enabled = True
        CheckBox_kor.Enabled = True

        TextBox_name_s.Enabled = True
        TextBox_name_father_s.Enabled = True
        TextBox_name_mother_s.Enabled = True
        TextBox_phone_s.Enabled = True
        TextBox_phone_father_s.Enabled = True
        TextBox_phone_mother_s.Enabled = True
        TextBox_telephone.Enabled = True
        TextBox_address.Enabled = True
        TextBox_codemeli_s.Enabled = True
        TextBox_datebirth_s_day.Enabled = True
        TextBox_datebirth_s_month.Enabled = True
        TextBox_datebirth_s_year.Enabled = True
        TextBox_datebirth_s_result.Enabled = True
        TextBox_date_s_day.Enabled = True
        TextBox_date_s_month.Enabled = True
        TextBox_date_s_year.Enabled = True
        TextBox_date_s_result.Enabled = True
        TextBox_gender_s.Enabled = True
        TextBox_level_s.Enabled = True
        TextBox_name_t.Enabled = True
        TextBox_lastname_t.Enabled = True
        TextBox_phone_t.Enabled = True
        TextBox_telephone_t.Enabled = True
        TextBox_address_t.Enabled = True
        TextBox_codemeli_t.Enabled = True
        TextBox_evidence.Enabled = True
        TextBox_datebirth_t_day.Enabled = True
        TextBox_datebirth_t_month.Enabled = True
        TextBox_datebirth_t_year.Enabled = True
        TextBox_datebirth_t_result.Enabled = True
        TextBox_date_t_day.Enabled = True
        TextBox_date_t_month.Enabled = True
        TextBox_date_t_year.Enabled = True
        TextBox_date_t_result.Enabled = True
        TextBox_gender_t.Enabled = True
        TextBox_password.Enabled = True
        TextBox_change_password_1.Enabled = True
        TextBox_change_password_2.Enabled = True
        TextBox_app_off.Enabled = True
        TextBox_search.Enabled = True
        Textbox_return_password.Enabled = True
        Textbox_return_password_p_1.Enabled = True
        Textbox_return_password_p_2.Enabled = True

        ComboBox_level_s.Enabled = True
        ComboBox_language_s_edit.Enabled = True
        ComboBox_language_t_edit.Enabled = True
    End Sub
    Private Sub Label_msg_box_option_1_MouseEnter(sender As Object, e As EventArgs)
        Label_msg_box_option_1.BackColor = System.Drawing.Color.FromArgb(135, 255, 242)
    End Sub
    Private Sub Label_msg_box_option_1_MouseLeave(sender As Object, e As EventArgs)
        Label_msg_box_option_1.BackColor = System.Drawing.Color.FromArgb(189, 255, 248)
    End Sub

    Private Sub Label_msg_box_option_2_Click(sender As Object, e As EventArgs)
        Panel_msg_box.Visible = False


        Button_students.Enabled = True
        Button_teachers.Enabled = True
        Button_delete_s.Enabled = True
        Button_edit_s.Enabled = True
        Button_add_s.Enabled = True
        Button_add_t.Enabled = True
        Button_edit_t.Enabled = True
        Button_delete_t.Enabled = True

        PictureBox_back_to_home_from_students_and_teachers_list.Enabled = True
        PictureBox_complete_registration_students.Enabled = True
        PictureBox_complete_registration_teachers.Enabled = True
        PictureBox_back_to_home_from_registration_students.Enabled = True
        PictureBox_back_to_home_from_registration_teachers.Enabled = True
        PictureBox_more_students.Enabled = True
        PictureBox_more_teachers.Enabled = True
        PictureBox_edit_students.Enabled = True
        PictureBox_edit_teachers.Enabled = True
        PictureBox_delete_students.Enabled = True
        PictureBox_delete_teachers.Enabled = True
        PictureBox_about_us.Enabled = True
        PictureBox_back_to_home_from_about_us.Enabled = True
        PictureBox_change_password_done.Enabled = True
        PictureBox_change_password_leave.Enabled = True
        PictureBox_password.Enabled = True
        PictureBox_change_passwors.Enabled = True
        PictureBox_setting.Enabled = True
        PictureBox_level_s.Enabled = True
        PictureBox_search.Enabled = True
        PictureBox_select_language_next_level.Enabled = True
        PictureBox_level_test.Enabled = True
        PictureBox_b_f_level_test.Enabled = True
        PictureBox_return_password.Enabled = True
        PictureBox_back_to_password.Enabled = True
        PictureBox_msg_box_left.Enabled = True
        PictureBox_msg_box_right.Enabled = True
        PictureBox_charts_show.Enabled = True
        PictureBox_charts_show_all.Enabled = True
        PictureBox_charts_show_teachers.Enabled = True
        PictureBox_charts_show_students.Enabled = True
        PictureBox_charts_show_back.Enabled = True
        PictureBox_charts_2d_3d.Enabled = True
        PictureBox_charts_change_type.Enabled = True
        PictureBox_charts_change_color.Enabled = True
        PictureBox_Part_charts_tips.Enabled = True
        PictureBox_Part_charts_restore_to_default.Enabled = True
        PictureBox_music.Enabled = True
        PictureBox_Accounting.Enabled = True

        Label_l_t_answer_1.Enabled = True
        Label_l_t_answer_2.Enabled = True
        Label_l_t_answer_3.Enabled = True
        Label_l_t_answer_4.Enabled = True
        Label_forgotten_password.Enabled = True
        Label_charts_choose_language.Enabled = True
        Label_charts_choose_gender.Enabled = True
        Label_charts_choose_birthday.Enabled = True
        Label_charts_choose_date_of_registration.Enabled = True

        GroupBox_setting.Enabled = True

        TrackBar_charts_type.Enabled = True
        TrackBar_charts_color.Enabled = True

        Panel_change_password.Enabled = True

        Radio_persian.Enabled = True
        Radio_english.Enabled = True
        RadioButton_male_s.Enabled = True
        RadioButton_female_s.Enabled = True
        RadioButton_male_t.Enabled = True
        RadioButton_female_t.Enabled = True

        CheckBox_en.Enabled = True
        CheckBox_tur.Enabled = True
        CheckBox_spa.Enabled = True
        CheckBox_ita.Enabled = True
        CheckBox_fre.Enabled = True
        CheckBox_arab.Enabled = True
        CheckBox_chi.Enabled = True
        CheckBox_japa.Enabled = True
        CheckBox_kor.Enabled = True

        TextBox_name_s.Enabled = True
        TextBox_name_father_s.Enabled = True
        TextBox_name_mother_s.Enabled = True
        TextBox_phone_s.Enabled = True
        TextBox_phone_father_s.Enabled = True
        TextBox_phone_mother_s.Enabled = True
        TextBox_telephone.Enabled = True
        TextBox_address.Enabled = True
        TextBox_codemeli_s.Enabled = True
        TextBox_datebirth_s_day.Enabled = True
        TextBox_datebirth_s_month.Enabled = True
        TextBox_datebirth_s_year.Enabled = True
        TextBox_datebirth_s_result.Enabled = True
        TextBox_date_s_day.Enabled = True
        TextBox_date_s_month.Enabled = True
        TextBox_date_s_year.Enabled = True
        TextBox_date_s_result.Enabled = True
        TextBox_gender_s.Enabled = True
        TextBox_level_s.Enabled = True
        TextBox_name_t.Enabled = True
        TextBox_lastname_t.Enabled = True
        TextBox_phone_t.Enabled = True
        TextBox_telephone_t.Enabled = True
        TextBox_address_t.Enabled = True
        TextBox_codemeli_t.Enabled = True
        TextBox_evidence.Enabled = True
        TextBox_datebirth_t_day.Enabled = True
        TextBox_datebirth_t_month.Enabled = True
        TextBox_datebirth_t_year.Enabled = True
        TextBox_datebirth_t_result.Enabled = True
        TextBox_date_t_day.Enabled = True
        TextBox_date_t_month.Enabled = True
        TextBox_date_t_year.Enabled = True
        TextBox_date_t_result.Enabled = True
        TextBox_gender_t.Enabled = True
        TextBox_password.Enabled = True
        TextBox_change_password_1.Enabled = True
        TextBox_change_password_2.Enabled = True
        TextBox_app_off.Enabled = True
        TextBox_search.Enabled = True
        Textbox_return_password.Enabled = True
        Textbox_return_password_p_1.Enabled = True
        Textbox_return_password_p_2.Enabled = True

        ComboBox_level_s.Enabled = True
        ComboBox_language_s_edit.Enabled = True
        ComboBox_language_t_edit.Enabled = True
    End Sub
    Private Sub Label_msg_box_option_2_MouseEnter(sender As Object, e As EventArgs)
        Label_msg_box_option_2.BackColor = System.Drawing.Color.FromArgb(135, 255, 242)
    End Sub
    Private Sub Label_msg_box_option_2_MouseLeave(sender As Object, e As EventArgs)
        Label_msg_box_option_2.BackColor = System.Drawing.Color.FromArgb(189, 255, 248)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        msg_box_two_option()
        msg_box_one_option()
        msg_box_type_info()
        msg_box_type_attention()
        Label_msg_box_title.Text = "حذف دانش آموزان"
        Label_msg_box_detail.Text = "برای حذف ابتدا بر روی اطلاعات شخص مورد نظر کلیک کرده سپس بر روی علامت ضربدر کلیک کنید" & vbNewLine & " توجه:ردیف اول به صورت پیش فرض انتخاب شده است"
        Label_msg_box_option_1.Text = "باشه"
        Label_msg_box_option_2.Text = "نه"

    End Sub


















    Private Sub Button2_Click(sender As Object, e As EventArgs)

        database_show_m_i_bahman()


        ' aaaaaa = mony_incoming_bahman_DataGridView.Rows.Count - 1

        '  For i = 0 To aaaaaa
        'Label1.Text = Val(Label1.Text.ToString) + Val(mony_incoming_bahman_DataGridView.Rows(i).Cells(1).Value.ToString)
        '  Next




    End Sub

End Class