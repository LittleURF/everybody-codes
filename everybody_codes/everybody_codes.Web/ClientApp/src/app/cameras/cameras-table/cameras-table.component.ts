import { Component, Input, OnChanges, ChangeDetectionStrategy, SimpleChanges } from '@angular/core';
import { Camera } from 'src/app/core/camera';

enum FilterBy {
  Indivisible = 0,
  Divisible = 1,
}

@Component({
  selector: 'app-cameras-table',
  templateUrl: './cameras-table.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CamerasTableComponent implements OnChanges {
  @Input() cameras: Camera[];

  camerasDivisibleBy3: Camera[];
  camerasDivisibleBy5: Camera[];
  camerasDivisibleBy3and5: Camera[];
  camerasIndivisibleBy3And5: Camera[];

  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes.cameras.currentValue) {
      this.setupCamerasSections();
    }
  }

  setupCamerasSections(): void {
    this.camerasDivisibleBy3 = this.filterCamerasByDivisibility(FilterBy.Divisible, 3);
    this.camerasDivisibleBy5 = this.filterCamerasByDivisibility(FilterBy.Divisible, 5);
    this.camerasDivisibleBy3and5 = this.filterCamerasByDivisibility(FilterBy.Divisible, 3, 5);
    this.camerasIndivisibleBy3And5 = this.filterCamerasByDivisibility(FilterBy.Indivisible, 3, 5);
  }

  filterCamerasByDivisibility(filterBy: FilterBy, ...numbers: number[]) {
    return this.cameras.filter(camera => {
      const isDivisible = numbers.every(number => camera.number % number === 0);

      return filterBy === FilterBy.Divisible ? isDivisible : !isDivisible;
    });
  }

}
