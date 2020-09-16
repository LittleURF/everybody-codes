import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { GoogleMapsModule } from '@angular/google-maps';

import { AppComponent } from './app.component';
import { CamerasModule } from './cameras/cameras.module';
import { CamerasComponent } from './cameras/cameras.component';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    GoogleMapsModule,
    CamerasModule,
    RouterModule.forRoot([
      { path: '', component: CamerasComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
