#include "ex_anklepassivepage.h"
#include "ui_ex_anklepassivepage.h"

#include "exercisecontroller.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include <QDebug>

Ex_AnklePassivePage::Ex_AnklePassivePage(QWidget *parent) :
    BasePage(pgidEx_AnklePassive, parent),
    ui(new Ui::Ex_AnklePassivePage)
{
    ui->setupUi(this);
    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
    ui->lineEdit_exercise_Duration->setText( QString::number(ExerciseController::Instance().Settings().mTime ) );
    ui->lineEdit_speed_Settings->setText( QString::number(ExerciseController::Instance().Settings().mVel ) );
    ui->lineEdit_range->setText( QString::number(ExerciseController::Instance().Settings().mRange ) );

}

Ex_AnklePassivePage::~Ex_AnklePassivePage()
{
    delete ui;
}

void Ex_AnklePassivePage::showEvent(QShowEvent *e)
{
    SetStartButtonText();
    //ui->lineEdit_max_Angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    //Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
    MyParent::showEvent( e );
}


//Переделать внимательно:
void Ex_AnklePassivePage::OnTimer()
{
    DrawAnimation();

    if( ExerciseController::Instance().ExerciseStarted() && !ExerciseController::Instance().OnPause() )
    {
        ui->lineEdit_speed_Settings->setText( QString::number(ExerciseController::Instance().Settings().mVel ) );
        ui->lineEdit_range->setText( QString::number(ExerciseController::Instance().Settings().mRange ) ); //Надо завести нового члена класса
        ui->lineEdit_exercise_Duration->setText( QString::number( ExerciseController::Instance().RemainingMins() ));
        mPrevExState = true;
    }
    else if( mPrevExState == true )
    {
        mPrevExState = false;
        SetStartButtonText();
        ui->lineEdit_exercise_Duration->setText( QString::number( ExerciseController::Instance().Settings().mTime ));
        ui->lineEdit_speed_Settings->setText( QString::number(ExerciseController::Instance().Settings().mVel ) );
        ui->lineEdit_range->setText( QString::number(ExerciseController::Instance().Settings().mRange ) );
    }
}


void Ex_AnklePassivePage::on_pushButton_Exercise_clicked()
{
    //При нажатии начинаем передавать пакеты $3XY#, где Х - скорость, Y - диапазон
    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ExerciseController::Instance().Settings().mActive = false;
        ExerciseController::Instance().Settings().mVel = ui->lineEdit_speed_Settings->text().toUInt();
        ExerciseController::Instance().Settings().mTime = ui->lineEdit_exercise_Duration->text().toUInt();
        ExerciseController::Instance().Settings().mRange=ui->lineEdit_range->text().toUInt();
        ExerciseController::Instance().StartExercise( ExerciseController::exmPassiveAnkle );
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

void Ex_AnklePassivePage::ToggleFieldAvailability()
{
    bool editable = !ExerciseController::Instance().ExerciseStarted() || ExerciseController::Instance().OnPause();
    ui->lineEdit_exercise_Duration->setEnabled( editable );
    ui->lineEdit_range->setEnabled( editable );
    ui->lineEdit_exercise_Duration->setEnabled( editable );
}


void Ex_AnklePassivePage::DrawAnimation()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        LegAnimationDrawer::Instance().SetLabel( ui->label_Leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
    }
}


void Ex_AnklePassivePage::SetStartButtonText()
{
    ui->pushButton_Exercise->setText( ExerciseController::Instance().ExerciseStarted() ? ( ExerciseController::Instance().OnPause() ? "Снять с паузы" : "Пауза" ) : "Приступить" );
}



void Ex_AnklePassivePage::on_pushButton_cancel_clicked()
{
    ExerciseController::Instance().StopExercisePassiveAnkle();
    MoveToPage( pgidModeSelection );
}

