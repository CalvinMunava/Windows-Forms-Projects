# Generated by Django 3.2.4 on 2021-06-28 14:30

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Appointment',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('StudentNumber', models.CharField(max_length=200)),
                ('StudentName', models.CharField(max_length=200)),
                ('AppointmentDate', models.DateField(null=True)),
                ('AppointmentDescription', models.TextField(max_length=1000)),
            ],
        ),
    ]
