#include "ex_activepassivepage.h"
#include "ui_ex_activepassivepage.h"

#include "exercisecontroller.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include <QDebug>

Ex_ActivePassivePage::Ex_ActivePassivePage(QWidget *parent) :
    MyParent(pgidEx_ActivePassive, parent),
    ui(new Ui::Ex_ActivePassivePage)
{
    ui->setupUi(this);
    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
}

Ex_ActivePassivePage::~Ex_ActivePassivePage()
{
    delete ui;
}

void Ex_ActivePassivePage::showEvent(QShowEvent */*e*/)
{
    SetStartButtonText();
    ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );

}

void Ex_ActivePassivePage::OnTimer()
{
    DrawAnimation();
    //Galim:
    ui->lineEdit_tenzo_1->setText(QString::number(BlGlue::Instance().Servo().FirstSensor()));
    ui->lineEdit_tenzo_2->setText(QString::number(BlGlue::Instance().Servo().SecondSensor()));
    Log( "Значение тензо 1: " + QString::number(BlGlue::Instance().Servo().FirstSensor()));
    Log( "Значение тензо 2: " + QString::number(BlGlue::Instance().Servo().SecondSensor()));

    if( ExerciseController::Instance().ExerciseStarted() && !ExerciseController::Instance().OnPause() )
    {
        ui->lineEdit__steps_count->setText( QString::number(ExerciseController::Instance().Settings().mSteps ) );
        ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle ) );
        ui->lineEdit_exercise_duration->setText( QString::number( ExerciseController::Instance().RemainingMins() ));


        mPrevExState = true;
    }
    else if( mPrevExState == true )
    {
        mPrevExState = false;
        SetStartButtonText();
        ui->lineEdit_exercise_duration->setText( QString::number( ExerciseController::Instance().Settings().mTime ));
        ui->lineEdit__steps_count->setText( QString::number( 20 ) );
    }
}

void Ex_ActivePassivePage::DrawAnimation()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
    }
}

void Ex_ActivePassivePage::SetStartButtonText()
{
    ui->pushButton_exercise->setText( ExerciseController::Instance().ExerciseStarted() ? ( ExerciseController::Instance().OnPause() ? "Снять с паузы" : "Пауза" ) : "Приступить" );
}

void Ex_ActivePassivePage::on_pushButton_cancel_clicked()
{
    ExerciseController::Instance().StopExercise();
    MoveToPage( pgidStart );
}

void Ex_ActivePassivePage::on_pushButton_exercise_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ExerciseController::Instance().Settings().mActive = false;
        ExerciseController::Instance().Settings().mMaxFlexAngle = ui->lineEdit_max_angle->text().toInt();
        //ExerciseController::Instance().Settings().mVel = ui->lineEdit_speed_settings->text().toUInt();
        ExerciseController::Instance().Settings().mSteps = ui->lineEdit__steps_count->text().toUInt();
        ExerciseController::Instance().Settings().mTime = ui->lineEdit_exercise_duration->text().toUInt();
        ExerciseController::Instance().StartExercise( ExerciseController::exmActivePassiveWithSensors );
    }
    else
    {
        if( !ExerciseController::Instance().OnPause() )
            ExerciseController::Instance().Pause();
        else
            ExerciseController::Instance().UnPause();
    }
    SetStartButtonText();
}

void Ex_ActivePassivePage::on_pushButton_diagnostics_clicked()
{
    MoveToPage(pgidDiagnosisAngle, Page());
}

void Ex_ActivePassivePage::on_pushButton_diagnostics_ankle_clicked()
{
    MoveToPage(pgidDiagnosisAnkleMobStr, Page());
}

void Ex_ActivePassivePage::on_lineEdit_exercise_duration_textEdited(const QString &arg1)
{
    ExerciseController::Instance().Settings().mTime = arg1.toUInt();
}

void Ex_ActivePassivePage::on_lineEdit__steps_count_textChanged(const QString &arg1)
{
   ExerciseController::Instance().Settings().mSteps = arg1.toUInt();
}

void Ex_ActivePassivePage::on_lineEdit_max_angle_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mMaxFlexAngle = arg1.toUInt();
}




