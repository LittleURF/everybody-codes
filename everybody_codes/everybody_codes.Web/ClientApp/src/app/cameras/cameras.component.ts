import { Component, OnInit } from '@angular/core';
import { Camera } from '../core/camera';
import { CameraDataService } from '../core/camera-data.service';

@Component({
  selector: 'app-cameras',
  templateUrl: './cameras.component.html',
  styleUrls: ['./cameras.component.scss']
})
export class CamerasComponent implements OnInit {
  cameras: Camera[];

  constructor(private cameraDataService: CameraDataService) {
  }

  ngOnInit() {
    this.cameraDataService.getCameras().subscribe(cameras => {
      this.cameras = cameras;
    });
  }
}
