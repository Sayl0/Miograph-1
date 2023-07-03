#include "exercisepage.h"
#include "ui_exercisepage.h"
#include "leg_animation_drawer.h"
#include "exercisecontroller.h"

ExercisePage::ExercisePage(QWidget *parent) :
    BasePage( pgidExercise, parent),
    ui(new Ui::ExercisePage)
{
    ui->setupUi(this);
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( DEFAULT_LEG_POS, 10, 10 );

    SetButtonsAvailability();

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 16 );
}

ExercisePage::~ExercisePage()
{
    delete ui;
}

void ExercisePage::OnTimer()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        quint8 top_level = 10;
        quint8 bottom_level = 10;
        if( CStreamControl::StreamHandlers.size() > 3 )
        {
            top_level = GetLevelFromStreamHandler( 2 );
            bottom_level = GetLevelFromStreamHandler( 1 );
            //qDebug()<<"top:"<<top_level<<"bottom:"<<bottom_level;
        }
        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), top_level, bottom_level );

        if( ExerciseController::Instance().ExerciseStarted() )
        {
            quint64 mins_passed = ExerciseController::Instance().ElapsedSecs() / 60;
            QString time_text = "время " + QString::number( mins_passed ) + "/30 мин";
            ui->label_time->setText( time_text );
            auto angle = AngleFromPos( pos );
            QString angle_text = "угол " + QString::number( angle ) + "/" + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle) + "°" ;
            ui->label_angle->setText( angle_text );
        }
    }
}

void ExercisePage::on_pushButton_start_pause_exercise_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_start_pause_exercise->text() );

    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ui->pushButton_start_pause_exercise->setText("Пауза");
        ExerciseController::Instance().StartExercise();
    }
    else
    {
        if( !ExerciseController::Instance().OnPause() )
        {
            ui->pushButton_start_pause_exercise->setText("Снять с паузы");
            ExerciseController::Instance().Pause();
        }
        else
        {
            ui->pushButton_start_pause_exercise->setText("Пауза");
            ExerciseController::Instance().UnPause();
        }
    }
    SetButtonsAvailability();
}

void ExercisePage::on_pushButton_stop_exercise_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_stop_exercise->text() );
    ExerciseController::Instance().StopExercise();
    /*
    Galim
    */
    //MoveToPage( pgidSelectSession );
    MoveToPage( pgidStart );
}

void ExercisePage::on_pushButton_extension_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_extension->text() );
    ExerciseController::Instance().Backward();
}

void ExercisePage::on_pushButton_stop_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_stop->text() );
    ExerciseController::Instance().Stop();
}

void ExercisePage::on_pushButton_flexion_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_flexion->text() );
    ExerciseController::Instance().Forward();
}

void ExercisePage::SetButtonsAvailability()
{
    bool visible = ExerciseController::Instance().ExerciseStarted() && ExerciseController::Instance().OnPause();
    ui->pushButton_extension->setVisible( visible );
    ui->pushButton_flexion->setVisible( visible );
    ui->pushButton_stop->setVisible( visible );
}

void ExercisePage::on_pushButton_cancel_clicked()
{

}

