import { Component, OnInit, ViewChild, Input, OnChanges, ChangeDetectionStrategy } from '@angular/core';
import { CameraDataService } from '../../core/camera-data.service';
import { GoogleMap } from '@angular/google-maps';

import { Camera } from '../../core/camera';
import { Marker } from './marker';
import { Location } from './location';

@Component({
  selector: 'app-cameras-map',
  templateUrl: './cameras-map.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CamerasMapComponent implements OnInit {
  @Input() cameras: Camera[];

  defaultMapCenter: Location = { lat: 52.093421, lng: 5.118278 };
  markers: Marker[];
  @ViewChild(GoogleMap, { static: true }) map: GoogleMap;

  constructor() { }

  ngOnInit(): void {
    this.map.center = this.defaultMapCenter;
  }

}
