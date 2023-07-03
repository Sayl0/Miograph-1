#include "ex_activepage.h"
#include "ui_ex_activepage.h"

#include "exercisecontroller.h"
#include "leg_animation_drawer.h"
#include <QDebug>

Ex_ActivePage::Ex_ActivePage(QWidget *parent) :
    BasePage(pgidEx_Active, parent),
    ui(new Ui::Ex_ActivePage)
{
    ui->setupUi(this);

    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( DEFAULT_LEG_POS, 10, 10 );

    SetButtonsAvailability();


    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 16 );
}

Ex_ActivePage::~Ex_ActivePage()
{
    delete ui;
}

void Ex_ActivePage::OnTimer()
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

            //Galim:
            ui->lineEdit__steps_count->setText( QString::number(ExerciseController::Instance().Settings().mSteps ) );
            ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle ) );
            ui->lineEdit_exercise_duration->setText( QString::number( ExerciseController::Instance().RemainingMins() ));

        }
    }

    //Где я это взял, не помню:
    /*
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
    }*/

}


void Ex_ActivePage::on_pushButton_cancel_clicked()
{
    ExerciseController::Instance().StopExercise();
    SetLabelsInvisible();
    MoveToPage( pgidModeSelection );
    //Backward();
}

//Galim
//Вот тут бардак:
void Ex_ActivePage::on_pushButton_exercise_clicked()
{
    Log( "Нажатие кнопки:" + ui->pushButton_exercise->text() );

    if( !ExerciseController::Instance().ExerciseStarted() )
    {
        ui->pushButton_exercise->setText("Пауза");
        ExerciseController::Instance().StartExercise();
    }
    else
    {
        if( !ExerciseController::Instance().OnPause() )
        {
            ui->pushButton_exercise->setText("Снять с паузы");
            ExerciseController::Instance().Pause();
        }
        else
        {
            ui->pushButton_exercise->setText("Пауза");
            ExerciseController::Instance().UnPause();
        }
    }
    SetButtonsAvailability();

}


void Ex_ActivePage::on_pushButton_diagnostics_clicked()
{
    //MoveToPage(pgidDiagnosisAngle, Page());
    MoveToPage(pgidDiagnosisAngle,pgidEx_Active);
}


void Ex_ActivePage::on_pushButton_diagnostics_2_clicked()
{
    // BlGlue::Instance().OpenTestMode();
    //BlGlue::Instance().OpenTestModeNew();
    //MoveToPage(pgidCMiographTester, Page());
    MoveToPage(pgidCMiographTester, pgidEx_Active);

}


void Ex_ActivePage::on_pushButton_diagnostics_3_clicked()
{
     //BlGlue::Instance().OpenTestMode();
    MoveToPage(pgidDiagnosisMaxStrength, pgidEx_Active);
}


void Ex_ActivePage::SetButtonsAvailability()
{
    /*
    bool visible = ExerciseController::Instance().ExerciseStarted() && ExerciseController::Instance().OnPause();
    ui->lineEdit_max_angle->setVisible( visible );
    ui->lineEdit_max_angle_2->setVisible( visible );
    ui->lineEdit_max_angle_3->setVisible( visible );
    ui->labelGrades->setVisible(visible);
*/
    bool visible = ExerciseController::Instance().ExerciseStarted() && ExerciseController::Instance().OnPause();
    ui->lineEdit_max_angle->setVisible( visible );
    ui->lineEdit_max_angle_2->setVisible( visible );
    ui->lineEdit_max_angle_3->setVisible( visible );
    ui->labelGrades->setVisible(visible);
    //if(visible){
     //   ;
    //}
}

void Ex_ActivePage::SetLabelsVisible()
{
    ui->lineEdit_max_angle->setVisible( true );
    ui->lineEdit_max_angle_2->setVisible( true );
    ui->lineEdit_max_angle_3->setVisible( true );
    ui->labelGrades->setVisible(true);
    /*
    ui->pushButton_diagnostics->setEnabled(false);
    ui->pushButton_diagnostics_2->setEnabled(false);
    ui->pushButton_diagnostics_3->setEnabled(false);
    */
    ui->pushButton_diagnostics->disconnect();
    ui->pushButton_diagnostics_2->disconnect();
    ui->pushButton_diagnostics_3->disconnect();
    //QObject::disconnect(ui->pushButton_diagnostics, SLOT(on_pushButton_diagnostics_clicked()));
    //QObject::disconnect(ui->pushButton_diagnostics_2, SLOT(on_pushButton_diagnostics_2_clicked()));
    //QObject::disconnect(ui->pushButton_diagnostics_3, SLOT(on_pushButton_diagnostics_2_clicked()));
    ui->pushButton_diagnostics->setIcon(QIcon(":/images/knee_statistics.png"));//:/images/knee_statistics.png
    ui->pushButton_diagnostics_2->setIcon(QIcon(":/images/strength_01.png"));//:/images/strength_01.png
    ui->pushButton_diagnostics_3->setIcon(QIcon(":/images/strength_02.png"));//:/images/strength_02.png
}

void Ex_ActivePage::SetLabelsInvisible()
{
    ui->lineEdit_max_angle->setVisible( false );
    ui->lineEdit_max_angle_2->setVisible( false );
    ui->lineEdit_max_angle_3->setVisible( false );
    ui->labelGrades->setVisible(false);
    /*
    ui->pushButton_diagnostics->setEnabled(true);
    ui->pushButton_diagnostics_2->setEnabled(true);
    ui->pushButton_diagnostics_3->setEnabled(true);
    */
    /*
    connect(this, SIGNAL(clicked), this, SLOT(on_pushButton_diagnostics_clicked()));
    connect(this, SIGNAL(clicked), this, SLOT(on_pushButton_diagnostics_2_clicked()));
    connect(this, SIGNAL(clicked), this, SLOT(on_pushButton_diagnostics_3_clicked()));
    */
    QObject::connect(ui->pushButton_diagnostics, SIGNAL(clicked), this,  SLOT(on_pushButton_diagnostics_clicked()));
    QObject::connect(ui->pushButton_diagnostics_2, SIGNAL(clicked), this,  SLOT(on_pushButton_diagnostics_2_clicked()));
    QObject::connect(ui->pushButton_diagnostics_3, SIGNAL(clicked), this,  SLOT(on_pushButton_diagnostics_3_clicked()));

    ui->pushButton_diagnostics->setIcon(QIcon(":/images/calibre_01.png"));
    ui->pushButton_diagnostics_2->setIcon(QIcon(":/images/calibre_02.png"));
    ui->pushButton_diagnostics_3->setIcon(QIcon(":/images/calibre_02.png"));
}
