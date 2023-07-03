#include "activemodestartpage.h"
#include "ui_activemodestartpage.h"

#include "leg_animation_drawer.h"
#include "exercisecontroller.h"


ActiveModeStartPage::ActiveModeStartPage(QWidget *parent) :
    MyParent(pgidActiveModeStart, parent),
    ui(new Ui::ActiveModeStartPage)
{
    ui->setupUi(this);
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( DEFAULT_LEG_POS, 10, 10 );

    SetButtonsAvailability();

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 16 );
}

ActiveModeStartPage::~ActiveModeStartPage()
{
    delete ui;
}
/*
void ActiveModeStartPage::showEvent(QShowEvent *e)
{
    //Это из пассивного режима притащено:
    //SetStartButtonText();
    //ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    //Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
    quint16 pos = ExerciseController::Instance().Pos();
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );

    MyParent::showEvent( e );
}
*/
void ActiveModeStartPage::OnTimer()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        quint8 top_level = 10;
        quint8 bottom_level = 10;
        if( CStreamControl::StreamHandlers.size() > 3 )
        {
            //Никита:
            //"Да, 2 меняем на 0, 1 так и остается"
            top_level = GetLevelFromStreamHandler( 0 );
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
            QString angle_text = "угол " + QString::number( angle ) + "/" + QString::number( ExerciseController::Instance().Settings().mVel) + "°" ;
            ui->label_speed->setText( angle_text );
        }
    }
}


void ActiveModeStartPage::on_pushButton_start_pause_exercise_clicked()
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


void ActiveModeStartPage::SetButtonsAvailability()
{
    bool visible = ExerciseController::Instance().ExerciseStarted() && ExerciseController::Instance().OnPause();
    //ui->pushButton_extension->setVisible( visible );
    //ui->pushButton_flexion->setVisible( visible );
    ui->pushButton_stop->setVisible( visible );
}

void ActiveModeStartPage::on_pushButton_stop_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_stop->text() );
    ExerciseController::Instance().Stop();
}


void ActiveModeStartPage::on_pushButton_stop_exercise_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_stop_exercise->text() );
    ExerciseController::Instance().StopExercise();
    MoveToPage( pgidModeSelection );
}

