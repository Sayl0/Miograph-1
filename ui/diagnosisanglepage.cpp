#include "diagnosisanglepage.h"
#include "ui_diagnosisanglepage.h"
#include "blglue.h"
#include "leg_animation_drawer.h"
#include "exercisecontroller.h"


DiagnosisAnglePage::DiagnosisAnglePage(QWidget *parent) :
    BasePage(pgidDiagnosisAngle, parent),
    ui(new Ui::DiagnosisAnglePage)
{
    ui->setupUi(this);
    LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
    LegAnimationDrawer::Instance().Draw( 0, 0, 0 );

    connect( &mTimer, SIGNAL(timeout()), this, SLOT(OnTimer()) );
    mTimer.start( 20 );
}

DiagnosisAnglePage::~DiagnosisAnglePage()
{
    delete ui;
}

void DiagnosisAnglePage::OnTimer()
{
    if( isVisible() )
    {
        quint16 pos = ExerciseController::Instance().Pos();
        // угол
        ui->label_angle->setText( QString::number( AngleFromPos( pos ) ) + "°" );

        LegAnimationDrawer::Instance().SetLabel( ui->label_leg );
        LegAnimationDrawer::Instance().Draw( static_cast<quint8>( pos ), 0, 0 );
        qDebug()<<"LegBendMeasurePage::OnTimer"<<"Pos"<<pos;

        // Galim
        ui->lineEdit_carriage_position->setText(QString::number(BlGlue::Instance().Servo().Pos()));
    }
}

void DiagnosisAnglePage::showEvent(QShowEvent */*e*/)
{
    OnTimer();
}

void DiagnosisAnglePage::hideEvent(QHideEvent * e)
{
    auto config = ExerciseController::Instance().Settings();
    quint16 pos = ExerciseController::Instance().Pos();
    config.mMaxFlexAngle = AngleFromPos( pos );
    ExerciseController::Instance().SetExerciseConfig( config );
    Log( "Exercise angle:" + QString::number( config.mMaxFlexAngle ) );

    MyParent::hideEvent( e );
}

void DiagnosisAnglePage::on_pushButton_flexion_clicked()
{
    BlGlue::Instance().Servo().SendControlPkg( CMioServoConnection::edirBackward, 5, 1 );
    Log( "Сгибание" );
}

void DiagnosisAnglePage::on_pushButton_extension_clicked()
{
    BlGlue::Instance().Servo().SendControlPkg( CMioServoConnection::edirForward, 5, 1 );
    Log( "Разгибание" );
}

void DiagnosisAnglePage::on_pushButton_stop_clicked()
{
    BlGlue::Instance().Servo().SendStop();
    Log( "Стоп" );
}


