#include "ex_passivepage.h"
#include "ui_ex_passivepage.h"
#include "exercisecontroller.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include <QDebug>


Ex_PassivePage::Ex_PassivePage(QWidget *parent) :
    BasePage(pgidEx_Passive, parent),
    ui(new Ui::Ex_PassivePage)
{
    ui->setupUi(this);
    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
    ui->lineEdit_speed_Settings->setText( QString::number(ExerciseController::Instance().Settings().mVel ) );
}

Ex_PassivePage::~Ex_PassivePage()
{
    delete ui;
}


void Ex_PassivePage::showEvent(QShowEvent *e)
{
    SetStartButtonText();
    ui->lineEdit_max_Angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
    MyParent::showEvent( e );
}

void Ex_PassivePage::OnTimer()
{
    DrawAnimation();

    if( ExerciseController::Instance().ExerciseStarted() && !ExerciseController::Instance().OnPause() )
    {
        ui->lineEdit__steps_Count->setText( QString::number(ExerciseController::Instance().Settings().mSteps ) );
        ui->lineEdit_max_Angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle ) );
        ui->lineEdit_exercise_Duration->setText( QString::number( ExerciseController::Instance().RemainingMins() ));
        mPrevExState = true;
    }
    else if( mPrevExState == true )
    {
        mPrevExState = false;
        SetStartButtonText();
        ui->lineEdit_exercise_Duration->setText( QString::number( ExerciseController::Instance().Settings().mTime ));
        ui->lineEdit__steps_Count->setText( QString::number( 20 ) );
    }
}

void Ex_PassivePage::on_pushButton_Exercise_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ExerciseController::Instance().Settings().mActive = false;
        ExerciseController::Instance().Settings().mMaxFlexAngle = ui->lineEdit_max_Angle->text().toInt();
        ExerciseController::Instance().Settings().mVel = ui->lineEdit_speed_Settings->text().toUInt();
        ExerciseController::Instance().Settings().mSteps = ui->lineEdit__steps_Count->text().toUInt();
        ExerciseController::Instance().Settings().mTime = ui->lineEdit_exercise_Duration->text().toUInt();
        ExerciseController::Instance().StartExercise( ExerciseController::exmPassive );
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

void Ex_PassivePage::on_pushButton_cancel_clicked()
{
    ExerciseController::Instance().StopExercise();
    MoveToPage( pgidModeSelection );
}


void Ex_PassivePage::on_lineEdit_exercise_Duration_textEdited(const QString &arg1)
{
    ExerciseController::Instance().Settings().mTime = arg1.toUInt();
}


void Ex_PassivePage::on_lineEdit_speed_Settings_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mVel = arg1.toUInt();
}


void Ex_PassivePage::on_lineEdit_max_Angle_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mSteps = arg1.toUInt();
}


void Ex_PassivePage::ToggleFieldAvailability()
{
    bool editable = !ExerciseController::Instance().ExerciseStarted() || ExerciseController::Instance().OnPause();
    ui->lineEdit_max_Angle->setEnabled( editable );
    ui->lineEdit_speed_Settings->setEnabled( editable );
    ui->lineEdit__steps_Count->setEnabled( editable );
    ui->lineEdit_exercise_Duration->setEnabled( editable );
}


void Ex_PassivePage::DrawAnimation()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        LegAnimationDrawer::Instance().SetLabel( ui->label_Leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
    }
}


void Ex_PassivePage::SetStartButtonText()
{
    ui->pushButton_Exercise->setText( ExerciseController::Instance().ExerciseStarted() ? ( ExerciseController::Instance().OnPause() ? "Снять с паузы" : "Пауза" ) : "Приступить" );
}


void Ex_PassivePage::on_pushButtonDiagnosisAngle_clicked()
{
    MoveToPage(pgidDiagnosisAngle, Page());
}

