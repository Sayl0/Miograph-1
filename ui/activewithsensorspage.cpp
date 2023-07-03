#include "activewithsensorspage.h"
#include "ui_activewithsensorspage.h"
#include "exercisecontroller.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include <QDebug>


ActiveWithSensorsPage::ActiveWithSensorsPage(QWidget *parent) :
    MyParent( pgidExerciseWithTenzosensors, parent),
    ui(new Ui::ActiveWithSensorsPage)
{
    ui->setupUi(this);
    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
}

ActiveWithSensorsPage::~ActiveWithSensorsPage()
{
    delete ui;
}

void ActiveWithSensorsPage::showEvent(QShowEvent */*e*/)
{
    SetStartButtonText();
    ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
}

void ActiveWithSensorsPage::OnTimer()
{
    DrawAnimation();

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

void ActiveWithSensorsPage::on_pushButton_exercise_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ExerciseController::Instance().Settings().mActive = false;
        ExerciseController::Instance().Settings().mMaxFlexAngle = ui->lineEdit_max_angle->text().toInt();
        ExerciseController::Instance().Settings().mVel = ui->lineEdit_speed_settings->text().toUInt();
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

void ActiveWithSensorsPage::on_pushButton_cancel_clicked()
{

    ExerciseController::Instance().StopExercise();
    /*
    Galim:
    Поменяем стартовую страницу
    */
    //MoveToPage( pgidSelectSession );
    MoveToPage( pgidStart );
}

void ActiveWithSensorsPage::on_lineEdit_exercise_duration_textEdited(const QString &arg1)
{
    ExerciseController::Instance().Settings().mTime = arg1.toUInt();
}

void ActiveWithSensorsPage::on_lineEdit_speed_settings_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mVel = arg1.toUInt();
}

void ActiveWithSensorsPage::on_lineEdit_max_angle_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mMaxFlexAngle = arg1.toUInt();
}

void ActiveWithSensorsPage::on_lineEdit__steps_count_textChanged(const QString &arg1)
{
    ExerciseController::Instance().Settings().mSteps = arg1.toUInt();
}

void ActiveWithSensorsPage::on_pushButton_to_start_pos_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() || ExerciseController::Instance().OnPause() )
    {
        ExerciseController::Instance().ToInitPos();
    }
}

void ActiveWithSensorsPage::on_pushButton_to_end_pos_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() || ExerciseController::Instance().OnPause() )
    {
        ExerciseController::Instance().ToEndPos();
    }
}

void ActiveWithSensorsPage::on_pushButton_ToMaxAngle_clicked()
{
    if( !ExerciseController::Instance().ExerciseStarted() || ExerciseController::Instance().OnPause() )
    {
        ExerciseController::Instance().ToMaxAnglePos();
    }
}

void ActiveWithSensorsPage::DrawAnimation()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
    }
}

void ActiveWithSensorsPage::SetStartButtonText()
{
    ui->pushButton_exercise->setText( ExerciseController::Instance().ExerciseStarted() ? ( ExerciseController::Instance().OnPause() ? "Снять с паузы" : "Пауза" ) : "Приступить" );
}

void ActiveWithSensorsPage::on_pushButton_diagnostics_clicked()
{
    MoveToPage( pgidSettingLegBend, Page() );
}


void ActiveWithSensorsPage::on_lineEdit_tenzo_1_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mD1 = arg1.toFloat() / 100;
}


void ActiveWithSensorsPage::on_lineEdit_tenzo_2_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mD2 = arg1.toFloat() / 100;
}


void ActiveWithSensorsPage::on_lineEdit_tenzo_error_textEdited(const QString &arg1)
{
    ExerciseController::Instance().mDeviation = arg1.toFloat() / 100;
}

