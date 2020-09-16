import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CamerasComponent } from './../cameras/cameras.component';
import { CamerasMapComponent } from './cameras-map/cameras-map.component';
import { CamerasTableComponent } from './cameras-table/cameras-table.component';
import { GoogleMapsModule } from '@angular/google-maps';


@NgModule({
  declarations: [
    CamerasComponent,
    CamerasMapComponent,
    CamerasTableComponent
  ],
  imports: [
    CommonModule,
    GoogleMapsModule
  ]
})
export class CamerasModule { }
