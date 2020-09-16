import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Camera } from './camera';

@Injectable({
  providedIn: 'root'
})
export class CameraDataService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }


  getCameras(): Observable<Camera[]> {
    return this.http.get<Camera[]>(`${this.baseUrl}cameras`);
  }
}
