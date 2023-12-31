import { Genre } from "./Genre"
import { Trope } from "./Trope"

export interface Book {
  id: string
  aaName: string
  author: string
  series: string
  ownedOrWish: boolean
  status: Status
  score: Score
  comment: string
  tropes: Trope[]
  genres: Genre[]
}

export enum Status {
  NotStarted,
  CurrentlyReading,
  Read,
  WantToReadSoon
}

export enum Score {
  One,
  Two,
  Three,
  Four,
  Five
}

export interface StatusDisplay {
  key: Status
  value: string
}

export interface ScoreDisplay {
  key: Score
  value: string
}
