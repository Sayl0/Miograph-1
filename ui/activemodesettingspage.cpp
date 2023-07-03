#include "activemodesettingspage.h"
#include "ui_activemodesettingspage.h"
#include "exercisecontroller.h"
#include "leg_animation_drawer.h"
#include <QDebug>

ActiveModeSettingsPage::ActiveModeSettingsPage(QWidget *parent) :
    BasePage(pgidActiveModeSettings, parent),
    ui(new Ui::ActiveModeSettingsPage)
{
    ui->setupUi(this);
}

ActiveModeSettingsPage::~ActiveModeSettingsPage()
{
    delete ui;
}


void ActiveModeSettingsPage::showEvent(QShowEvent *e)
{
    //Это из пассивного режима:
    //SetStartButtonText();
    //ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    //Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
    quint16 pos = ExerciseController::Instance().Pos();
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
    MyParent::showEvent( e );
}

void ActiveModeSettingsPage::on_pushButtonDiagnosisAngle_clicked()
{
    MoveToPage(pgidDiagnosisAngle,Page());
}


void ActiveModeSettingsPage::on_pushButtonDiagnosisAngle_2_clicked()
{
    MoveToPage(pgidCMiographTester, Page());
}


void ActiveModeSettingsPage::on_pushButtonDiagnosisAngle_3_clicked()
{
   MoveToPage(pgidDiagnosisMaxStrength, Page());
}


void ActiveModeSettingsPage::on_pushButton_forward_clicked()
{
    ExerciseSettings settings;

    settings.mActive = true;
    settings.mSteps = ui->lineEdit_steps->text().toInt();
    settings.mTime = 480;
    settings.mVel = ui->lineEdit_speed->text().toInt();

    Log( "Настройки упражнения:" );
    Log( QString("Режим активный? ") + (settings.mActive ? "да" : "нет") );
    Log( "Шаги: " + QString::number( settings.mSteps ));
    Log( "Время: " + QString::number( settings.mTime ));
    Log( "Скорость: " + QString::number( settings.mVel ));

    ExerciseController::Instance().SetExerciseConfig( settings );
    MoveToPage( pgidActiveModeStart, Page() );
}

