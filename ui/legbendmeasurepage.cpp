#include "legbendmeasurepage.h"
#include "ui_legbendmeasurepage.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include "exercisecontroller.h"

LegBendMeasurePage::LegBendMeasurePage(QWidget *parent) :
    BasePage( pgidSettingLegBend, parent),
    ui(new Ui::LegBendMeasurePage)
{
    ui->setupUi(this);

    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( 0, 0, 0 );

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
}

LegBendMeasurePage::~LegBendMeasurePage()
{
    delete ui;
}

void LegBendMeasurePage::showEvent(QShowEvent */*e*/)
{
    OnTimer();
}

void LegBendMeasurePage::hideEvent(QHideEvent * e)
{
    auto config = ExerciseController::Instance().Settings();
    quint16 pos = ExerciseController::Instance().Pos();
    config.mMaxFlexAngle = AngleFromPos( pos );
    ExerciseController::Instance().SetExerciseConfig( config );
    Log( "Exercise angle:" + QString::number( config.mMaxFlexAngle ) );

    MyParent::hideEvent( e );
}

void LegBendMeasurePage::OnTimer()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        // угол
        ui->label_angle->setText( QString::number( AngleFromPos( pos ) ) + "°" );

        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
        qDebug()<<"LegBendMeasurePage::OnTimer"<<"Pos"<<pos;
    }
}

void LegBendMeasurePage::on_pushButton_flexion_clicked()
{
    BlGlue::Instance().Servo().SendControlPkg( CMioServoConnection::edirBackward, 5, 1 );
    Log( "Сгибание" );
}

void LegBendMeasurePage::on_pushButton_extension_clicked()
{
    BlGlue::Instance().Servo().SendControlPkg( CMioServoConnection::edirForward, 5, 1 );
    Log( "Разгибание" );
}

void LegBendMeasurePage::on_pushButton_stop_clicked()
{
    BlGlue::Instance().Servo().SendStop();
    Log( "Стоп" );
}
