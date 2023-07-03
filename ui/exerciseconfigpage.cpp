#include "exerciseconfigpage.h"
#include "ui_exerciseconfigpage.h"
#include "exercisecontroller.h"
#include <QDebug>

ExerciseConfigPage::ExerciseConfigPage(QWidget *parent) :
    BasePage( pgidExerciseConfig, parent),
    ui(new Ui::ExerciseConfigPage)
{
    ui->setupUi(this);
}

ExerciseConfigPage::~ExerciseConfigPage()
{
    delete ui;
}

void ExerciseConfigPage::showEvent(QShowEvent * e)
{
    ui->lineEdit_max_angle->setText( QString::number(ExerciseController::Instance().Settings().mMaxFlexAngle) );
    Log( "Текущий макс. угол для упражнения: " + QString::number( ExerciseController::Instance().Settings().mMaxFlexAngle ) );
    MyParent::showEvent( e );
}

void ExerciseConfigPage::on_pushButton_forward_clicked()
{
    ExerciseSettings settings;

    settings.mActive = true;
    settings.mSteps = ui->lineEdit_steps->text().toInt();
    settings.mTime = 480;
    settings.mMaxFlexAngle = ui->lineEdit_max_angle->text().toInt();

    Log( "Настройки упражнения:" );
    Log( QString("Режим активный? ") + (settings.mActive ? "да" : "нет") );
    Log( "Шаги: " + QString::number( settings.mSteps ));
    Log( "Время: " + QString::number( settings.mTime ));
    Log( "Макс. угол: " + QString::number( settings.mMaxFlexAngle ));

    ExerciseController::Instance().SetExerciseConfig( settings );
    MoveToPage( pgidExercise, Page() );
}

void ExerciseConfigPage::on_pushButton_to_start_pos_clicked()
{
    ExerciseController::Instance().ToInitPos();
}


void ExerciseConfigPage::on_pushButton_calibration_clicked()
{
    MoveToPage( pgidSettingCalibration, Page() );
}


void ExerciseConfigPage::on_pushButton_diagnostics_clicked()
{
    MoveToPage( pgidSettingLegBend, Page());
}

