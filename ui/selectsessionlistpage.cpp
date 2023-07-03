#include "ui/selectsessionlistpage.h"
#include "ui_selectsessionlistpage.h"

#include "blglue.h"

SelectSessionListPage::SelectSessionListPage( QWidget *parent) :
    /*
     * Galim:
     * Поменяли стартовую страницу
     *
     */
    //BasePage( pgidSelectSession, parent ),
    BasePage( pgidStart, parent ),
    ui(new Ui::SelectSessionListPage)
{
    ui->setupUi(this);

    BlGlue::Instance().ConnectionStart();

    QString err_str;
    BlGlue::Instance().OpenServoConnection( err_str );


    if( !BlGlue::Instance().Core().bDebugMode )
    {
        ui->pushButton_TestMode->setVisible( false );
        ui->groupBox_test_settings->setVisible( false );
    }

    ui->doubleSpinBox_gain_1->setValue( CStreamControl::dbCoefficient[0] );
    ui->doubleSpinBox_gain_2->setValue( CStreamControl::dbCoefficient[1] );
    ui->doubleSpinBox_gain_3->setValue( CStreamControl::dbCoefficient[2] );
    ui->doubleSpinBox_gain_4->setValue( CStreamControl::dbCoefficient[3] );
}

SelectSessionListPage::~SelectSessionListPage()
{
    delete ui;
}

void SelectSessionListPage::on_pushButton_begin_session_clicked()
{
    if( ui->checkBox_write_log->isChecked() )
        BlGlue::Instance().ResetLog();
    MoveToPage( pgidExerciseConfig, Page() );
    Log( "Начать сессию" );
}

void SelectSessionListPage::on_pushButton_TestMode_clicked()
{
    BlGlue::Instance().OpenTestMode();
    Log( "Нажата кнопка тестового режима" );
}

void SelectSessionListPage::on_pushButton_exit_clicked()
{
    Log( "Выход" );
    QApplication::quit();
}

void SelectSessionListPage::on_doubleSpinBox_gain_1_valueChanged(double arg1)
{
    CStreamControl::dbCoefficient[0] = arg1;
    QSettings settings("AppConfig.ini",QSettings::IniFormat);
    settings.setValue("DbCoeff1",  qreal(CStreamControl::dbCoefficient[0]));
    settings.sync();
}

void SelectSessionListPage::on_doubleSpinBox_gain_2_valueChanged(double arg1)
{
    CStreamControl::dbCoefficient[1] = arg1;
    QSettings settings("AppConfig.ini",QSettings::IniFormat);
    settings.setValue("DbCoeff2",  qreal(CStreamControl::dbCoefficient[1]));
    settings.sync();
}

void SelectSessionListPage::on_doubleSpinBox_gain_3_valueChanged(double arg1)
{
    CStreamControl::dbCoefficient[2] = arg1;
    QSettings settings("AppConfig.ini",QSettings::IniFormat);
    settings.setValue("DbCoeff3",  qreal(CStreamControl::dbCoefficient[2]));
    settings.sync();
}

void SelectSessionListPage::on_doubleSpinBox_gain_4_valueChanged(double arg1)
{
    CStreamControl::dbCoefficient[3] = arg1;
    QSettings settings("AppConfig.ini",QSettings::IniFormat);
    settings.setValue("DbCoeff4",  qreal(CStreamControl::dbCoefficient[3]));
    settings.sync();
}

void SelectSessionListPage::on_pushButton_passive_mode_clicked()
{
    MoveToPage( pgidExercisePassive );
}

void SelectSessionListPage::on_pushButton_active_passive_mode_clicked()
{
    MoveToPage( pgidExerciseWithTenzosensors );
}
